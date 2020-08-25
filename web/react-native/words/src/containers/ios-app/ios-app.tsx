import * as React from "react";
import { Routes } from "../../configs/index";

export class IosApp extends React.Component<any, any> {
    /**
     * @description render the template
     */
    public render() {
        return (
            new Routes().generate()
        );
    }
}

export { IosApp as Component };
