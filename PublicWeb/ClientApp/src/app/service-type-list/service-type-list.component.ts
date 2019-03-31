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
    this.serviceService.getServiceTypes().subscribe(result => {
      if (!result.success) {
        //TODO
      }
      this.serviceTypes = result.result;
    }, error => {
      //TODO
      console.error(error);
    });
  }

}
