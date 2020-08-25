"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var index_js_1 = require("../routes/index.js");
var index_js_2 = require("../components/index.js");
var http_1 = require('@angular/http');
var forms_1 = require('@angular/forms');
var AppComponent = (function () {
    function AppComponent() {
    }
    AppComponent = __decorate([
        core_1.Component({
            selector: "my-app",
            templateUrl: "views/app.html"
        }), 
        __metadata('design:paramtypes', [])
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
var AppModule = (function () {
    function AppModule() {
    }
    AppModule.generateImports = function () {
        var imports = [
            platform_browser_1.BrowserModule,
            index_js_1.AppRoutingModule,
            http_1.HttpModule,
            forms_1.FormsModule
        ];
        return imports;
    };
    AppModule.generateDeclarations = function () {
        var declarations = [
            AppComponent
        ];
        return declarations
            .concat(index_js_1.AppRoutingModule.generateImports())
            .concat(index_js_2.AppComponentModule.generateImports());
    };
    AppModule = __decorate([
        core_1.NgModule({
            imports: AppModule.generateImports(),
            declarations: AppModule.generateDeclarations(),
            bootstrap: [AppComponent]
        }), 
        __metadata('design:paramtypes', [])
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.js.map