import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';

import { BasicServicesModule } from '@basic/basic.services.module';

import { ApiServicesModule } from './api.services.module';

@NgModule({
  imports: [
    HttpClientModule,
    BasicServicesModule,
    ApiServicesModule,
  ]
})
export class GuitarServicesModule { }
