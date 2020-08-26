"use strict";
var ROUTES = [
    {
        "url": "",
        "controller": "Bootstrap"
    },
    {
        "url": "home",
        "controller": "HomeController"
    },
    {
        "url": "about",
        "controller": "AboutController"
    }
];
exports.ROUTES = ROUTES;
var ENDPOINTS = {
    "WORDS": {
        "GET_ALL": "/word",
        "SAVE": "/word"
    }
};
exports.ENDPOINTS = ENDPOINTS;
var COMPONENTS = [
    {
        "name": "WordListComponent"
    },
    {
        "name": "WordItemComponent"
    }
];
exports.COMPONENTS = COMPONENTS;
//# sourceMappingURL=index.js.map