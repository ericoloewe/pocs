import * as React from "react";
import { Router, browserHistory } from "react-router";

export class Routes {
    private routes: Array<RouteConfig>;

    public constructor() {
        this.load();
    }

    /**
     * generate the routes
     */
    public generate(): JSX.Element {
        var routes = this.routes.map(function (route) {
            let View = require("../../views" + route.path);
            return {
                path: route.url,
                component: View,
            };
        });

        return <Router history={browserHistory}>{routes}</Router>;
    }

    /**
     * load
     */
    private load(): void {
        this.routes = require("../constants/routes.json");
    }
}
