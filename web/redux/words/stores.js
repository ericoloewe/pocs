(function () {
    window.Words = (window.Words || {});

    window.Words.store = Redux.createStore(window.Words.reducers);
})();
