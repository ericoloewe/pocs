import { NgModule } from "@angular/core";
import { COMPONENTS } from "../constants/index.js";
import * as Components from "../../../components/index.js";

@NgModule({})
export class AppComponentModule {
    /**
     * generate the imports
     */
    public static generateImports() {
        let imports = new Array();

        return imports.concat(
            COMPONENTS.map((config: ComponentConfig) => {
                return Components[config.name];
            })
        );
    }

    public constructor() {
    }
}
