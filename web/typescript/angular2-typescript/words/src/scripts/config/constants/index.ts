const ROUTES = [
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

const ENDPOINTS = {
    "WORDS": {
        "GET_ALL": "/word",
        "SAVE": "/word"
    }
};

const COMPONENTS = [
    {
        "name": "WordListComponent"
    },
    {
        "name": "WordItemComponent"
    }
];

export { COMPONENTS, ENDPOINTS, ROUTES };
