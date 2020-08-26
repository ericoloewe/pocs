import { Injectable, EventEmitter } from '@angular/core';
import { Word } from '../models/index.js';
import { Http, Response } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';

@Injectable()
export class WordService {
    private static _onWordsUpdate: EventEmitter<Word | Array<Word>>;

    public constructor(private http: Http) {
        this.reset();
    }

    /**
     * @description get on words update event
     */
    public get onWordsUpdate(): Observable<Word | Array<Word>> {
        return WordService._onWordsUpdate.asObservable();
    }

    /**
     * @description get all
     */
    public getAll(): Promise<any> {
        return this.http.get('/api/word')
            .map((response) => {
                return response.json();
            })
            .catch(this.handleError)
            .forEach(words => {
                WordService._onWordsUpdate.emit(words.map((w: ReceivedWord) => {
                    return new Word(w.id, w.name);
                }));
            });
    }

    /**
     * @description save the word
     */
    public save(word: Word): Promise<any> {
        return this.http.post('/api/word', word.toApiSave())
            .map((response) => {
                return response.json();
            })
            .catch(this.handleError)
            .forEach(w => {
                WordService._onWordsUpdate.emit(new Word(w.id, w.name));
            });
    }

    private reset() {
        WordService._onWordsUpdate = new EventEmitter();
    }

    private handleError(error: Response | any) {
        // In a real world app, we might use a remote logging infrastructure
        let errMsg: string;

        if (error instanceof Response) {
            const body = error.json() || '';
            const err = body.error || JSON.stringify(body);
            errMsg = `${error.status} - ${error.statusText || ''} ${err}`;
        } else {
            errMsg = error.message ? error.message : error.toString();
        }

        console.error(errMsg);
        return Observable.throw(errMsg);
    }
}
