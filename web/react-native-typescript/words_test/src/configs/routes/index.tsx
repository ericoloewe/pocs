import * as React from "react";
import { ROUTES } from "../index";
import * as Containers from "../../containers/index";
import { Router, Scene } from 'react-native-router-flux';

export class Routes {
    private routes: Array<RouteConfig>;

    public constructor() {
        this.load();
    }

    /**
     * generate the routes
     */
    public generate(): JSX.Element {
        return (<Router>{generateScenes(this.routes)}</Router>);

        function generateScenes(scenes: Array<RouteConfig>): Array<JSX.Element> {
            return scenes.map((sceneConfig) => {
                let Component = Containers[sceneConfig.component];
                let scene: JSX.Element;

                if (sceneConfig.scenes === undefined) {
                    scene = (<Scene key={sceneConfig.key} component={Component} initial={sceneConfig.initial} hideNavBar={sceneConfig.hideNavBar} />);
                } else {
                    scene = (<Scene key={sceneConfig.key} component={Component} initial={sceneConfig.initial} hideNavBar={sceneConfig.hideNavBar}>{generateScenes(sceneConfig.scenes)}</Scene>);
                }

                return scene;
            });
        }
    }

    /**
     * load
     */
    private load(): void {
        this.routes = ROUTES;
    }
}
