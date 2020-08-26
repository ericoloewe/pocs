/**
 * @description Word model
 */
export class Word {
    private _id: number;
    private _name: string;

    constructor(id: number = null, name: string = null) {
        this._id = id;
        this._name = name;
    }

    get id(): number {
        return this._id;
    }

    set id(value: number) {
        this._id = value;
    }

    get name(): string {
        return this._name;
    }

    set name(value: string) {
        this._name = value;
    }

    /**
     * to save the word at api
     */
    public toApiSave() {
        return {
            id: this.id,
            name: this.name
        };
    }
}
