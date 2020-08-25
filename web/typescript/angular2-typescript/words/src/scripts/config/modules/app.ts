import { NgModule, Component } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { AppRoutingModule } from "../routes/index.js";
import { AppComponentModule } from "../components/index.js";
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';
import * as Controllers from "../../controllers/index.js";

@Component({
    selector: "my-app",
    templateUrl: "views/app.html"
})
export class AppComponent {
}

@NgModule({
    imports: AppModule.generateImports(),
    declarations: AppModule.generateDeclarations(),
    bootstrap: [AppComponent]
})
export class AppModule {
    public static generateImports() {
        let imports = [
            BrowserModule,
            AppRoutingModule,
            HttpModule,
            FormsModule
        ];

        return imports;
    }

    public static generateDeclarations() {
        let declarations = [
            AppComponent
        ];

        return declarations
            .concat(AppRoutingModule.generateImports())
            .concat(AppComponentModule.generateImports());
    }

}
