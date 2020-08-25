(function () {
    window.Words = (window.Words || {});

    var Actions = function () {
    }

    Actions.prototype = {
        ADD_WORD: "ADD_WORD",
        REMOVE_WORD: "REMOVE_WORD",

        addWord: function (text) {
            return {
                type: this.ADD_WORD,
                text: text
            };
        },

        removeWord: function (id) {
            return {
                type: this.ADD_WORD,
                id: id
            };
        }
    };

    window.Words.actions = new Actions();
})();
