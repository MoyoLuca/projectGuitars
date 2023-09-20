import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { ButtonComponent } from './button/button.component';
import { UIGridComponent } from './grid/grid.component';

const components = [ButtonComponent, UIGridComponent];

@NgModule({
  declarations: components,
  imports: [BrowserModule, FormsModule],
  exports: components,
})
export class UiModule {}
