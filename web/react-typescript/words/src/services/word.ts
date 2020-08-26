import { ENDPOINTS } from "../config/constants/index";
import { Word } from "../models";

class WordService {
    /**
     * @description get all
     */
    public getAll(): Promise<any> {
        return fetch(ENDPOINTS.WORDS.GET_ALL)
            .then((response: Response) => {
                return response.json();
            });
    }

    /**
     * @description save a word
     */
    public save(word: Word): Promise<any> {
        return fetch(ENDPOINTS.WORDS.SAVE, {
            method: "POST",
            headers: {
                'Accept': 'application/json, text/plain, */*',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ name: word.name })
        }).then((response: Response) => {
            return response.json();
        });
    }
}

export default new WordService();
