import * as React from "react";
import { WordList } from "../components/index";
import { Word } from "../models";
import wordService from "../services/word";

interface HomeProps { compiler: string; framework: string; }
interface HomeStates { word: string; }

class Home extends React.Component<HomeProps, HomeStates> {

    public constructor(props: HomeProps) {
        super(props);
        this.state = { word: '' };
    }

    /**
     * handle submit
     */
    public handleSubmit(event: React.FormEvent<HTMLFormElement>) {
        wordService.save(new Word(this.state.word)).then(function () {
            WordList.update();
        });

        return event.preventDefault();
    }

    /**
     * handle word change
     */
    public handleWordChange(event: React.ChangeEvent<HTMLInputElement>) {
        this.setState({ word: event.target.value });
    }

    /**
     * render
     */
    public render(): JSX.Element {
        return (
            <article className="container">
                <section className="well">
                    <form onSubmit={e => this.handleSubmit(e)}>
                        <div className="form-group">
                            <input type="text" className="form-control" placeholder="Type an word" value={this.state.word} onChange={e => this.handleWordChange(e)} />
                        </div>
                        <button type="submit" className="btn btn-default">Salvar</button>
                    </form>
                </section>
                <section className="home-list">
                    <WordList />
                </section>
                <pre>{JSON.stringify(this.state)}</pre>
            </article>
        );
    }
}

export = Home;
