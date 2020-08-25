import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { AppModule } from "./config/modules/index.js";

class App {
    constructor() {
        this.loadBootstrapModule();
    }

    private loadBootstrapModule() {
        platformBrowserDynamic().bootstrapModule(AppModule);
    }
}

export = new App();
