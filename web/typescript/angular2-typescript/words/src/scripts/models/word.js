"use strict";
/**
 * @description Word model
 */
var Word = (function () {
    function Word(id, name) {
        if (id === void 0) { id = null; }
        if (name === void 0) { name = null; }
        this._id = id;
        this._name = name;
    }
    Object.defineProperty(Word.prototype, "id", {
        get: function () {
            return this._id;
        },
        set: function (value) {
            this._id = value;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Word.prototype, "name", {
        get: function () {
            return this._name;
        },
        set: function (value) {
            this._name = value;
        },
        enumerable: true,
        configurable: true
    });
    /**
     * to save the word at api
     */
    Word.prototype.toApiSave = function () {
        return {
            id: this.id,
            name: this.name
        };
    };
    return Word;
}());
exports.Word = Word;
//# sourceMappingURL=word.js.map