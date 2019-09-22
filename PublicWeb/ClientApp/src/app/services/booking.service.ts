import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PendingBooking } from '../models/pending-booking';
import { Observable } from 'rxjs';
import { JsonResult } from '../models/JsonResult';
import { CreateBooking } from '../models/create-booking';

@Injectable()
export class BookingService {
  httpClient: HttpClient;
  url: string;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.url = baseUrl;
    this.httpClient = http;
  }
  createPendingBooking(pBooking: PendingBooking): Observable<JsonResult<PendingBooking>> {
    return this.httpClient.post<JsonResult<any>>(this.url + `api/Booking/createPendingBooking`, pBooking);
  }
  createBooking(booking: CreateBooking): Observable<JsonResult<any>>{
    return this.httpClient.post<JsonResult<any>>(this.url + `api/Booking`, booking);
  }
}
