/**
 * Server task
 */
const gulp = require("gulp");
const path = require("path");
const browserSync = require("browser-sync");
const httpPlease = require('connect-http-please');
const { disableCompression, errorHandler, parseHost, replaceHost, replaceHtmlBody, rewriteLocationHeader } = require("./middlewares/speed-middleware");

let task = null;
const accountName = 'ecoke';

class ServerTask {
  static start() {
    if (!task) {
      task = new ServerTask();
    }

    task.start();
  }

  start() {
    gulp.task('server', () => {
      var browserSyncServer = browserSync.create();

      const host = `https://loja.cocacola.com.br`;
      const localHost = parseHost(accountName, true);

      browserSyncServer.init({
        host: localHost,
        https: true,
        proxy: {
          target: host,
          middleware: [
            replaceHtmlBody(accountName)
          ]
        }
      }, () => console.log("STARTED"));
    });
  }
}

module.exports = { ServerTask };