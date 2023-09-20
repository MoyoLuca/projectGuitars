import { Injectable } from '@angular/core';

import { HttpService } from '@basic/http.service';
import { StorageService } from '@basic/storage.service';

import { UsersCommonService } from '@common/users.common.extension.service';


@Injectable({
  providedIn: 'root'
})
export class UsersService extends UsersCommonService<User> {

  constructor(public override httpService: HttpService, public override storageService: StorageService) {
    super(httpService, storageService, { cacheableDataRetrieval: { getDefault: true, get: false, query: false, search: false }, cacheExpiration: { shouldPersist: true, persistanceDuration: { timeUnit: 'hours', value: 24 } } });
  }

  /**********
   *  All common methods are implemented in UsersCommonService
   ********/
}

export interface User {
  Id?: number;
  GUID?: string;
  CreationDate?: string;

  Subscriber?: any;
  FullName?: string;

  FirstName?: string;
  LastName?: string;
  UserEmail?: string;
  Phone?: string;
  Password?: string;
  AcceptTermsAndConditions?: boolean;

  OldPassword?: string;
  BusinessInfo?: any;

  IsDeleted?: boolean;
  UpdatedAt?: string;
}
