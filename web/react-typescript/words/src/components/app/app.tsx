import * as React from "react";
import "./app.css";

const logo = require("../../media/images/logo.svg");

export class App extends React.Component<null, null> {
    /**
     * render
     */
    public render() {
        return (
            <div className="app">
                <div className="app-header">
                    <img src={logo} className="app-logo" alt="logo" />
                    <h2>Welcome to React</h2>
                </div>
                <p className="app-intro">
                    To get started, edit <code>src/App.tsx</code> and save to reload.
                </p>
            </div>
        );
    }
}
