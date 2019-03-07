import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { EventSchedule } from '../models/event-schedule';
import { Observable } from 'rxjs/Observable';
import { JsonResult } from '../models/JsonResult';

@Injectable()
export class EventScheduleService {
  httpClient: HttpClient;
  url: string;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.url = baseUrl;
    this.httpClient = http;
  }
  getSchedule(id: string): Observable<JsonResult<EventSchedule>> {
    if (id)
      return this.httpClient.get<JsonResult<EventSchedule>>(this.url + `api/EventSchedule/${id}`);
    else
      return this.httpClient.get<JsonResult<EventSchedule>>(this.url + `api/EventSchedule/`);
  }
}
