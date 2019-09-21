import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { EventSearchParameter } from '../models/search-paramters/event-search-paramter';
import { JsonResult } from '../models/JsonResult';
import { Observable } from 'rxjs';
import { Event } from '../models/event';

@Injectable()
export class EventService {

  httpClient: HttpClient;
  url: string;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.url = baseUrl;
    this.httpClient = http;
  }
  getEvents(searchParamter: EventSearchParameter): Observable<JsonResult<Event[]>> {
    return this.httpClient.post<JsonResult<Event[]>>(this.url + `api/Event`, searchParamter);
  }
  getTopFive(): Observable<JsonResult<Event[]>> {
    return this.httpClient.get<JsonResult<Event[]>>(this.url + `api/Event/GetTopFive`);
  }
  getEvent(id: string): Observable<JsonResult<Event>> {
    return this.httpClient.get<JsonResult<Event>>(this.url + `api/Event/${id}`);
  }
}
