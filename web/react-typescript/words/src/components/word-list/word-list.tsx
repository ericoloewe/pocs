import * as React from "react";
import "./word-list.css";
import { WordItem } from "../index";
import { Word } from "../../models";
import wordService from "../../services/word";

export class WordList extends React.Component<null, null> {

    private static words: Array<Word> = new Array<Word>();

    public static update() {
        return wordService.getAll().then((words) => {
            WordList.words = words;
        });
    }

    public constructor() {
        super();

        var self = this;

        WordList.update().then(function () {
            self.forceUpdate();
        });
    }

    /**
     * render
     */
    public render() {
        return (
            <ul className="list-group">
                {
                    WordList.words.map(function (word, index) {
                        return <WordItem key={index} id={word.id} name={word.name} />;
                    })
                }
            </ul>
        );
    }
}
