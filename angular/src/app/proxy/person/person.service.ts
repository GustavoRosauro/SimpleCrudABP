import type { CreateUpdatePersonDto, PersonDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class PersonService {
  apiName = 'Default';

  create = (input: CreateUpdatePersonDto) =>
    this.restService.request<any, PersonDto>({
      method: 'POST',
      url: '/api/app/person',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/person/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, PersonDto>({
      method: 'GET',
      url: `/api/app/person/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<PersonDto>>({
      method: 'GET',
      url: '/api/app/person',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdatePersonDto) =>
    this.restService.request<any, PersonDto>({
      method: 'PUT',
      url: `/api/app/person/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
