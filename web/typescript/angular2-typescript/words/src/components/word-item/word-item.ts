import { Component, Input } from '@angular/core';
import { Word } from '../../scripts/models/index.js';

@Component({
    selector: 'word-item',
    templateUrl: 'components/word-item/word-item.html'
})
export class WordItemComponent {
    @Input('word')
    private _word: Word;

    public get word(): Word {
        return this._word;
    }

    public set word(value: Word) {
        this._word = value;
    }
}
