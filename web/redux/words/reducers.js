(function () {
    window.Words = (window.Words || {});

    var Word = window.Words.models.Word;
    var actions = window.Words.actions;
    var initialWordReducerState = [];

    function WordReducer(state, action) {
        var nextState = initialWordReducerState;

        if (state !== undefined) {
            nextState = Object.assign([], state);

            switch (action.type) {
                case actions.ADD_WORD: {
                    var word = new Word(action.text);

                    nextState.push(word);

                    word.id = nextState.indexOf(word);
                    break;
                }
                case actions.REMOVE_WORD: {
                    var index = 0;
                    var wordToRemove = nextState.find(function (word) {
                        return word.id === action.id;
                    });

                    index = nextState.indexOf(wordToRemove);

                    nextState.splice(index, 1);

                    break;
                }
            }
        }

        return nextState;
    }

    window.Words.reducers = Redux.combineReducers({
        words: WordReducer
    });
})();
