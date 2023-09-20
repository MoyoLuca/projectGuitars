import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule } from "@angular/router";
import { GuitarServicesModule } from "@guitangweb/services.module";
import { TaigaUIModule } from "../ui/taiga.ui.module";

import { UiModule } from "../ui/ui.module";

import { ContactRoutingModule } from "./contact/contact-routing.module";
import { ContactComponent } from "./contact/contact.component";
import { HomeComponent } from "./home/home.component";


@NgModule ({
declarations:[
    ContactComponent,
    HomeComponent
],
imports:[
    BrowserModule,
    FormsModule,
    UiModule,
    FormsModule,
    ReactiveFormsModule,
    TaigaUIModule,
    RouterModule,
    GuitarServicesModule
],
exports:[
    ContactComponent,
],

})
export class PagesModule {

}