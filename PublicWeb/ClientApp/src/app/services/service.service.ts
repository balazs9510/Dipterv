import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { JsonResult } from '../models/JsonResult';
import { ServiceType } from '../models/service-type';

@Injectable()
export class ServiceService {

  constructor() { }
  getServiceTypes() : JsonResult<ServiceType[]>{
    
    return {message: "", success: true, result: [{id : "1", name : "teszt"},{id : "2", name : "teszt 2"}]};
  }
}
