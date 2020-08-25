(function () {
    window.Words = (window.Words || {});

    var Word = function (name) {
        this.name = name || '';
    };

    window.Words.models = {
        Word: Word
    };
})();
