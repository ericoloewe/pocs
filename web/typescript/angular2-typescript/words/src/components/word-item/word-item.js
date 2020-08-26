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
var index_js_1 = require('../../scripts/models/index.js');
var WordItemComponent = (function () {
    function WordItemComponent() {
    }
    Object.defineProperty(WordItemComponent.prototype, "word", {
        get: function () {
            return this._word;
        },
        set: function (value) {
            this._word = value;
        },
        enumerable: true,
        configurable: true
    });
    __decorate([
        core_1.Input('word'), 
        __metadata('design:type', index_js_1.Word)
    ], WordItemComponent.prototype, "_word", void 0);
    WordItemComponent = __decorate([
        core_1.Component({
            selector: 'word-item',
            templateUrl: 'components/word-item/word-item.html'
        }), 
        __metadata('design:paramtypes', [])
    ], WordItemComponent);
    return WordItemComponent;
}());
exports.WordItemComponent = WordItemComponent;
//# sourceMappingURL=word-item.js.map