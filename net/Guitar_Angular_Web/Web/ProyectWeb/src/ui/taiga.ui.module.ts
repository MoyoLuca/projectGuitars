import { NgModule } from '@angular/core';
import {
  TuiButtonModule,
  TuiDropdownModule,
  TuiLoaderModule,
} from '@taiga-ui/core';
import { TuiInputModule } from '@taiga-ui/kit';

const TaigaUIModules = [
  TuiButtonModule,
  TuiDropdownModule,
  TuiLoaderModule,
  TuiInputModule,
];

@NgModule({
  imports: TaigaUIModules,
  exports: TaigaUIModules,
})
export class TaigaUIModule {}
