let proxy = require('http-proxy-middleware');
let fallback = require('connect-history-api-fallback');

module.exports = {
  server: {
    baseDir: "src",
    routes: {
      "/node_modules": "node_modules"
    },
    middleware: [
      proxy("/api", {
        target: "http://127.0.0.1:8181",
        changeOrigin: true
      }),
      fallback({
        index: "/index.html",
        verbose: true
      })
    ]
  }
}
