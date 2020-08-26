import { Component } from "@angular/core";
import { WordService } from '../services/index.js';
import { Word } from '../models/index.js';

@Component({
    selector: "home",
    templateUrl: "views/home.html",
    providers: [WordService]
})
export class HomeController {
    private _word: Word;

    public constructor(private wordService: WordService) {
        this.reset();
    }

    public get word(): Word {
        return this._word;
    }

    public set word(value: Word) {
        this._word = value;
    }

    private reset() {
        this._word = new Word();
    }

    public onSubmit(word: Word) {
        this.wordService.save(word).then(w => {
            this.reset();
        });
    }
}
