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
var index_js_1 = require('../services/index.js');
var index_js_2 = require('../models/index.js');
var HomeController = (function () {
    function HomeController(wordService) {
        this.wordService = wordService;
        this.reset();
    }
    Object.defineProperty(HomeController.prototype, "word", {
        get: function () {
            return this._word;
        },
        set: function (value) {
            this._word = value;
        },
        enumerable: true,
        configurable: true
    });
    HomeController.prototype.reset = function () {
        this._word = new index_js_2.Word();
    };
    HomeController.prototype.onSubmit = function (word) {
        var _this = this;
        this.wordService.save(word).then(function (w) {
            _this.reset();
        });
    };
    HomeController = __decorate([
        core_1.Component({
            selector: "home",
            templateUrl: "views/home.html",
            providers: [index_js_1.WordService]
        }), 
        __metadata('design:paramtypes', [index_js_1.WordService])
    ], HomeController);
    return HomeController;
}());
exports.HomeController = HomeController;
//# sourceMappingURL=home.js.map