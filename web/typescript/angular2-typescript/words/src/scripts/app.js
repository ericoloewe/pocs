"use strict";
var platform_browser_dynamic_1 = require("@angular/platform-browser-dynamic");
var index_js_1 = require("./config/modules/index.js");
var App = (function () {
    function App() {
        this.loadBootstrapModule();
    }
    App.prototype.loadBootstrapModule = function () {
        platform_browser_dynamic_1.platformBrowserDynamic().bootstrapModule(index_js_1.AppModule);
    };
    return App;
}());
module.exports = new App();
//# sourceMappingURL=app.js.map