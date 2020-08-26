import * as React from "react";
import { Content } from 'native-base';
import { WordItem } from "../index";
import { Word } from "../../models/index";

export class WordList extends React.Component<null, null> {

    private words: Array<Word>;

    public constructor() {
        super();
        this.words = new Array<Word>();
    }

    /**
     * @description render the template
     */
    public render() {
        return (
            <Content>
                {
                    this.words.map(function (word, index) {
                        return <WordItem key={index} id={word.id} name={word.name} />;
                    })
                }
            </Content>
        );
    }
}
