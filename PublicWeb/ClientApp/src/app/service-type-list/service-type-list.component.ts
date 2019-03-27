import { Component, OnInit } from '@angular/core';
import { ServiceType } from '../models/service-type';
import { ServiceService } from '../services/service.service';
import * as $ from 'jquery';
@Component({
  selector: 'app-service-type-list',
  templateUrl: './service-type-list.component.html',
  styleUrls: ['./service-type-list.component.css']
})
export class ServiceTypeListComponent implements OnInit {

  serviceTypes : ServiceType[];
  constructor(private serviceService: ServiceService,) { }

  ngOnInit() {
    let res = this.serviceService.getServiceTypes();
    if(res.success){
      this.serviceTypes = res.result;
    }else{

    }
  }

}
