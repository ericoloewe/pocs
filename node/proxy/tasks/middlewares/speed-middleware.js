const cheerio = require('cheerio');

const ignoreReplace = [
  /\.js(\?.*)?$/, /\.css(\?.*)?$/, /\.svg(\?.*)?$/, /\.ico(\?.*)?$/, /\.woff(\?.*)?$/, /\.png(\?.*)?$/, /\.jpg(\?.*)?$/, /\.jpeg(\?.*)?$/, /\.gif(\?.*)?$/, /\.pdf(\?.*)?$/
];

const vtexEnvironment = 'vtexcommercestable';
const vtexLocalEnvironment = 'vtexlocal';

class VtexSpeedMiddleware {
  constructor() {
    this.replaceHost = this.replaceHost.bind(this);
    this.rewriteLocationHeader = this.rewriteLocationHeader.bind(this);
  }

  disableCompression(req, res, next) {
    req.headers['accept-encoding'] = 'identity';
    return next();
  };

  errorHandler(err, req, res, next) {
    var errString, ref, ref1;

    errString = (ref = (ref1 = err.code) != null ? ref1.red : void 0) != null ? ref : err.toString().red;

    return console.log(errString, req.url.yellow);
  }

  parseHost(accountName, local = false) {
    let environment = vtexEnvironment;

    if (local) {
      environment = vtexLocalEnvironment;
    }

    return `${accountName}.${environment}.com.br`;
  }

  replaceHtmlBody(accountName, environment = vtexEnvironment, secureUrl = true) {
    return (req, res, next) => {
      if (ignoreReplace.some((ignore) => ignore.test(req.url))) {
        return next();
      }

      let data = '';
      let write = res.write;
      let end = res.end;
      let writeHead = res.writeHead;
      let proxyStatusCode = null;
      let proxyHeaders = null;

      res.write = (chunk) => data += chunk;

      res.end = (chunk, encoding) => {
        if (chunk) {
          data += chunk;
        }

        if (data) {
          const $ = cheerio.load(data);

          $(`main`).html($("<h1>").text("Our home 🤘"));

          data = $.html();
          data = data.replace(new RegExp(environment, "g"), vtexLocalEnvironment);
          data = data.replace(new RegExp("vteximg", "g"), vtexLocalEnvironment);

          if (secureUrl) {
            data = data.replace(new RegExp(`https:\/\/${accountName}`, "g"), `http://${accountName}`);
          }
        }

        res.write = write;
        res.end = end;

        return res.end(data, encoding);
      };

      return next();
    };
  }

  replaceHost(accountName) {
    const host = this.parseHost(accountName);

    return (req, res, next) => {
      req.headers.host = host;

      return next();
    };
  }

  rewriteLocationHeader(req, res, next) {
    var writeHead = res.writeHead;

    res.writeHead = (statusCode, headers) => {
      if (headers && headers.location) {
        headers.location = this._rewriteLocation(headers.location);
      }

      res.writeHead = writeHead;

      return res.writeHead(statusCode, headers);
    };

    return next();
  };

  _rewriteLocation(location) {
    return location
      .replace('https:', 'http:')
      .replace(vtexEnvironment, vtexLocalEnvironment);
  }
}


module.exports = new VtexSpeedMiddleware();