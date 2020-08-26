(function () {
    window.Words = (window.Words || {});

    var actions = window.Words.actions;
    var store = window.Words.store;

    var WordForm = function () {
        this.fetchElements();
        this.bindEvents();
    }

    WordForm.prototype = {
        fetchElements: function () {
            $(function () {
                this.$wordForm = $('.word-form');
                this.$wordList = $('.word-list');
            }.bind(this));
        },

        bindEvents: function () {
            $(function () {
                this.bindFormSubmitEvent();
                this.bindWordListUpdateEvent();
            }.bind(this));
        },

        bindFormSubmitEvent: function () {
            this.$wordForm.on('submit', function (e) {
                var formData = new FormData(this);

                store.dispatch({ type: actions.ADD_WORD, text: formData.get('wordName') });

                this.reset();

                return e.preventDefault();
            });
        },

        bindWordListUpdateEvent: function () {
            store.subscribe(function () {
                this.updateWordList(store.getState().words);
            }.bind(this));
        },

        updateWordList: function (words) {
            this.$wordList.empty();

            this.$wordList.append(words.map(function (word) {
                return $("<li>")
                    .addClass('word-item list-group-item')
                    .attr("data-word-id", word.id)
                    .html(word.name)
                    .append(
                    $("<button>")
                        .attr("type", "button")
                        .attr("aria-label", "Close")
                        .addClass("close")
                        .append(
                        $("<span>")
                            .attr("aria-label", "Close")
                            .html('&times;')
                        )
                        .on('click', function () {
                            store.dispatch({ type: actions.REMOVE_WORD, id: word.id });
                        })
                    );
            }));
        }
    };

    window.Words.index = {
        wordForm: new WordForm()
    }
})();
