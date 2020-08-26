import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { FisrtComponentComponent } from './fisrt-component/fisrt-component.component';
import { FirstDirectiveDirective } from './first-directive.directive';
import { FirstPipePipe } from './first-pipe.pipe';

@NgModule({
  declarations: [
    AppComponent,
    FisrtComponentComponent,
    FirstDirectiveDirective,
    FirstPipePipe
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
