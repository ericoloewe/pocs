/**
 * CWI Speed middleware
 */
const util = require('util')
const cheerio = require('cheerio')
const fs = require('fs')

class ReplaceContentMiddleware {
  constructor() {
    this.fs = fs
    this.ignoreReplace = /\.((js)|(css)|(svg)|(ico)|(woff)|(png)|(jpg)|(jpeg)|(gif)|(pdf))(\?.*)?$/g
    this.buildPath = `dist`
    this.templatePath = `${this.buildPath}/templates`
    this.STATIC_CONTENT_ATTR = 'data-content-static'
    this.CONTENT_ATTR = 'data-content'
  }

  create({ contentReplace }) {
    return (req, res, next) => {
      if (this.ignoreReplace.test(req.url)) {
        return next()
      }

      let content
      let write = res.write
      let end = res.end

      res.write = (chunk) => {
        if (content == null) {
          content = chunk;
        } else {
          content = Buffer.concat([content, chunk])
        }
      }

      res.end = async (chunk, encoding) => {
        if (chunk) {
          content = Buffer.concat([content, chunk])
        }

        content = await this._prepareContent(res, content, contentReplace)

        res.write = write
        res.end = end

        return res.end(content, encoding)
      }

      return next()
    }
  }

  /**
   * Set current file system
   * @param {import('fs')} fileSystem 
   */
  setFileSystem(fileSystem) {
    this.fs = fileSystem
  }

  async _prepareContent(res, content, contentReplace) {
    const contentType = `${res.getHeader('content-type')}`;

    try {
      if (content && contentType.indexOf('text/html') >= 0) {
        const preparedHtml = await this._replaceHtml(content);

        content = Buffer.from(preparedHtml)

        if (typeof (contentReplace) === 'function') {
          content = Buffer.from(contentReplace(content));
        }
      }
    } catch (ex) {
      console.error('There are some problems to replace content', ex)
    }

    return content;
  }

  async _replaceHtml(content) {
    const $ = cheerio.load(content)

    await this._replaceDevContents($)
    this._replaceHtmlScriptsAndImages($)
    this._replaceHtmlLinksAndStyles($)

    content = $.html()
    content = this._replaceHtmlMark(content)

    return content
  }

  async _replaceDevContents($) {
    const { CONTENT_ATTR } = this
    const self = this
    const $contents = $(`[${CONTENT_ATTR}]`);
    const promises = []

    $contents.each(function () {
      try {
        const $el = $(this)
        const contentName = $el.attr(CONTENT_ATTR)
        const filePath = `${self.templatePath}/${contentName}.html`

        if (filePath != null) {
          promises.push(self._replaceDevContentByDistFile(filePath, contentName, $el))
        }
      } catch (ex) {
        console.error('Stack', ex)
        promises.push(new Error('There are some problem to replace the dev content'))
      }
    })

    return Promise.all(promises)
  }

  async _replaceDevContentByDistFile(filePath, contentName, $el) {
    const readFileAsync = util.promisify(this.fs.readFile)
    const fileContent = await readFileAsync(filePath)
    const $c = cheerio.load(fileContent)
    const $content = $c(`[${this.CONTENT_ATTR}="${contentName}"]`)

    this._replaceStaticDevContent($c, $content, $el)

    $el.html($content.html())
    $content.each(function () {
      if (this.attribs != null) {
        Object.keys(this.attribs)
          .forEach(k => $el.attr(k, this.attribs[k]))
      }
    })
  }

  _replaceHtmlScriptsAndImages($) {
    const self = this

    $('script,img').each(function () {
      const $el = $(this)
      let source = $el.attr('src')

      if (source != null && source.indexOf('js') >= 0) {
        const scriptType = $el.data('script-type')

        if (scriptType != null) {
          source = source.replace('arquivos/', `${scriptType}/`)
        } else {
          source = source.replace('arquivos/', 'templates/')
        }

        if (source.indexOf('vtex.viewPart.ajaxLoader_V2') >= 0) {
          $el.remove()
        }

        $el.attr('src', source)
      }
    })
  }

  _replaceHtmlLinksAndStyles($) {
    const self = this

    $('a,link').each(function () {
      const $el = $(this)
      let source = $el.attr('href')

      if (source != null && source.indexOf('css') >= 0) {
        source = source.replace('arquivos/', 'styles/')
        $el.attr('href', source)
      }
    })
  }

  _replaceHtmlMark(htmlContent) {
    return htmlContent
      .replace('<html>', `<!DOCTYPE html>
        <html xmlns="http://www.w3.org/1999/xhtml" xmlns:vtex="http://www.vtex.com.br/2009/vtex-common" xmlns:vtex.cmc="http://www.vtex.com.br/2009/vtex-commerce" lang="pt-br">
      `)
  }

  _replaceStaticDevContent($c, $actualContent, $serverContent) {
    const { STATIC_CONTENT_ATTR } = this

    $actualContent.find(`[${STATIC_CONTENT_ATTR}]`).each(function () {
      const $contentStaticEl = $c(this)
      const staticContentName = $contentStaticEl.attr(STATIC_CONTENT_ATTR)
      const $staticContent = $serverContent.find(`[${STATIC_CONTENT_ATTR}="${staticContentName}"]`)

      if ($staticContent.html() != null) {
        $contentStaticEl.html($staticContent.html())
      } else {
        console.warn(`There is no static content with name ${staticContentName} in server`)
      }
    })
  }
}

exports.replaceContentMiddleware = new ReplaceContentMiddleware()
