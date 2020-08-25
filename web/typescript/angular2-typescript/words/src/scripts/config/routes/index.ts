import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { ROUTES } from "../constants/index.js";
import * as Controllers from "../../controllers/index.js";

@NgModule({
    imports: [
        RouterModule.forRoot(AppRoutingModule.generate())
    ],
    exports: [RouterModule]
})
export class AppRoutingModule {
    /**
     * generate the routes
     */
    public static generate() {
        return ROUTES.map((route: RouteConfig) => {
            return {
                path: route.url,
                component: Controllers[route.controller],
            };
        });
    }

    /**
     * generate the imports
     */
    public static generateImports() {
        let imports = new Array();

        return imports.concat(
            ROUTES.map((route: RouteConfig) => {
                return Controllers[route.controller];
            }).filter((controller, index, controllers) => {
                return controllers.indexOf(controller) === index;
            })
        );
    }

    public constructor() {
    }
}
