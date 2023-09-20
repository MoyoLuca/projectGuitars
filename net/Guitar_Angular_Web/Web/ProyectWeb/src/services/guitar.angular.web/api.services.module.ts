import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { Router } from '@angular/router';

import { CookiesService } from '@basic/cookie.service';
import { HttpInterceptorService } from '@basic/http.interceptor.service';
import { HttpService } from '@basic/http.service';
import { LoggerService } from '@basic/logger.service';
import { RouterService } from '@basic/routes.service';
import { StorageService } from '@basic/storage.service';
import { MessageService } from '@basic/message.service';
import { UtilsService } from '@basic/utils.service';

import { UsersService } from '@guitangweb/users.service';

import { TuiAlertService } from '@taiga-ui/core';

export function servicesDependencyOfHttpServiceFactory<T>(service: { new(httpService: HttpService, storageService: StorageService): T }): (httpService: HttpService, storageService: StorageService) => T {
  return (httpService: HttpService, storageService: StorageService) => {
    return new service(httpService, storageService);
  };
}

@NgModule({
  imports: [
    HttpClientModule
  ],
  providers: [
    { provide: UsersService, useFactory: servicesDependencyOfHttpServiceFactory(UsersService), deps: [HttpService, StorageService] },
    { provide: HTTP_INTERCEPTORS, useClass: HttpInterceptorService, multi: true },
  ]
})
export class ApiServicesModule { }
