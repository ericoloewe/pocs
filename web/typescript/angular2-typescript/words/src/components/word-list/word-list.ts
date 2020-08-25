import { Component, OnInit } from '@angular/core';
import { Word } from '../../scripts/models/index.js';
import { WordService } from '../../scripts/services/index.js';

@Component({
    selector: 'word-list',
    templateUrl: 'components/word-list/word-list.html',
    providers: [WordService]
})
export class WordListComponent implements OnInit {
    private _words: Array<Word>;

    public constructor(private wordService: WordService) {
        this.reset();
    }

    public get words(): Array<Word> {
        return this._words;
    }

    public ngOnInit() {
        this.bindEvents();
        this.load();
    }

    private reset() {
        this._words = new Array();
    }

    private load() {
        this.wordService.getAll();
    }

    public bindEvents() {
        this.bindWordsUpdate();
    }

    public bindWordsUpdate() {
        this.wordService.onWordsUpdate.forEach((words: Word | Array<Word>) => {
            if (Array.isArray(words)) {
                this._words = words;
            } else {
                this._words.push(words);
            }
        });
    }
}
