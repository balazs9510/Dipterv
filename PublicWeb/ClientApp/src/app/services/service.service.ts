import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import { JsonResult } from '../models/JsonResult';
import { ServiceType } from '../models/service-type';
import { HttpClient } from '@angular/common/http';
import { Service } from '../models/service';
import { ServiceSearchParamter } from '../models/search-paramters/service-search-paramter';

@Injectable()
export class ServiceService {
  httpClient: HttpClient;
  url: string;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.url = baseUrl;
    this.httpClient = http;
  }
  getServiceTypes(): Observable<JsonResult<ServiceType[]>> {
    return this.httpClient.get<JsonResult<ServiceType[]>>(this.url + `api/Service/GetServiceTypes`);
  }
  getServices(searchParamter: ServiceSearchParamter): Observable<JsonResult<Service[]>> {
    return this.httpClient.post<JsonResult<Service[]>>(this.url + `api/Service`, searchParamter);
  }
  getServicesOfEvent(id: string): Observable<JsonResult<Service[]>> {
    return this.httpClient.get<JsonResult<Service[]>>(this.url + `api/Service/GetServiceOfEvent?eventId=${id}`);
  }
  getTopFive(): Observable<JsonResult<Service[]>> {
    return this.httpClient.get<JsonResult<Service[]>>(this.url + `api/Service/GetTopFive`);
  }
}
