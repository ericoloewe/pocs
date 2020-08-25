import * as React from "react";
import { Routes } from "../../configs/index";

export class AndroidApp extends React.Component<AndroidAppProps, AndroidAppStates> {
    /**
     * @description render the template
     */
    public render() {
        return (
            new Routes().generate()
        );
    }
}

export { AndroidApp as Component };
