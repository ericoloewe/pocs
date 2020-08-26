import * as React from "react";
import "./word-item.css";

interface WordItemProps { id: number; name: string; }
interface WordItemStates { }

export class WordItem extends React.Component<WordItemProps, WordItemStates> {
    /**
     * render
     */
    public render() {
        return (
            <li className="list-group-item">
                {`${this.props.id} - ${this.props.name}`}
            </li>
        );
    }
}
