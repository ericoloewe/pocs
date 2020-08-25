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
var index_js_1 = require('../models/index.js');
var http_1 = require('@angular/http');
var Observable_1 = require('rxjs/Observable');
require('rxjs/add/operator/catch');
require('rxjs/add/operator/map');
var WordService = (function () {
    function WordService(http) {
        this.http = http;
        this.reset();
    }
    Object.defineProperty(WordService.prototype, "onWordsUpdate", {
        /**
         * @description get on words update event
         */
        get: function () {
            return WordService._onWordsUpdate.asObservable();
        },
        enumerable: true,
        configurable: true
    });
    /**
     * @description get all
     */
    WordService.prototype.getAll = function () {
        return this.http.get('/api/word')
            .map(function (response) {
            return response.json();
        })
            .catch(this.handleError)
            .forEach(function (words) {
            WordService._onWordsUpdate.emit(words.map(function (w) {
                return new index_js_1.Word(w.id, w.name);
            }));
        });
    };
    /**
     * @description save the word
     */
    WordService.prototype.save = function (word) {
        return this.http.post('/api/word', word.toApiSave())
            .map(function (response) {
            return response.json();
        })
            .catch(this.handleError)
            .forEach(function (w) {
            WordService._onWordsUpdate.emit(new index_js_1.Word(w.id, w.name));
        });
    };
    WordService.prototype.reset = function () {
        WordService._onWordsUpdate = new core_1.EventEmitter();
    };
    WordService.prototype.handleError = function (error) {
        // In a real world app, we might use a remote logging infrastructure
        var errMsg;
        if (error instanceof http_1.Response) {
            var body = error.json() || '';
            var err = body.error || JSON.stringify(body);
            errMsg = error.status + " - " + (error.statusText || '') + " " + err;
        }
        else {
            errMsg = error.message ? error.message : error.toString();
        }
        console.error(errMsg);
        return Observable_1.Observable.throw(errMsg);
    };
    WordService = __decorate([
        core_1.Injectable(), 
        __metadata('design:paramtypes', [http_1.Http])
    ], WordService);
    return WordService;
}());
exports.WordService = WordService;
//# sourceMappingURL=word-service.js.map