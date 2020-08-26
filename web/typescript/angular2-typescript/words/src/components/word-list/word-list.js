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
var core_1 = require('@angular/core');
var index_js_1 = require('../../scripts/services/index.js');
var WordListComponent = (function () {
    function WordListComponent(wordService) {
        this.wordService = wordService;
        this.reset();
    }
    Object.defineProperty(WordListComponent.prototype, "words", {
        get: function () {
            return this._words;
        },
        enumerable: true,
        configurable: true
    });
    WordListComponent.prototype.ngOnInit = function () {
        this.bindEvents();
        this.load();
    };
    WordListComponent.prototype.reset = function () {
        this._words = new Array();
    };
    WordListComponent.prototype.load = function () {
        this.wordService.getAll();
    };
    WordListComponent.prototype.bindEvents = function () {
        this.bindWordsUpdate();
    };
    WordListComponent.prototype.bindWordsUpdate = function () {
        var _this = this;
        this.wordService.onWordsUpdate.forEach(function (words) {
            if (Array.isArray(words)) {
                _this._words = words;
            }
            else {
                _this._words.push(words);
            }
        });
    };
    WordListComponent = __decorate([
        core_1.Component({
            selector: 'word-list',
            templateUrl: 'components/word-list/word-list.html',
            providers: [index_js_1.WordService]
        }), 
        __metadata('design:paramtypes', [index_js_1.WordService])
    ], WordListComponent);
    return WordListComponent;
}());
exports.WordListComponent = WordListComponent;
//# sourceMappingURL=word-list.js.map