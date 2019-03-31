import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { ServiceService } from '../services/service.service';
import { Service } from '../models/service';
import { ServiceSearchParamter } from '../models/search-paramters/service-search-paramter';

@Component({
  selector: 'app-service-list',
  templateUrl: './service-list.component.html',
  styleUrls: ['./service-list.component.css']
})
export class ServiceListComponent implements OnInit {

  services: Service[];
  serviceTypeName: string;
  page: number = 1;
  serviceSearchParameter: ServiceSearchParamter = {
    name: "",
    serviceTypeId: "",
    city: ""
  };
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private serviceService: ServiceService) { }

  ngOnInit() {
    this.serviceSearchParameter.serviceTypeId = this.route.snapshot.paramMap.get('id');
    this.serviceTypeName = this.route.snapshot.paramMap.get('name');
    this.serviceService.getServices(this.serviceSearchParameter).subscribe(result => {
      if (!result.success) {
        //TODO
      }
      this.services = result.result;
      console.log(result.result);
    }, error => {
      //TODO
      console.error(error);
    });
  }
  onSearch(){
    this.serviceService.getServices(this.serviceSearchParameter).subscribe(result => {
      if (!result.success) {
        //TODO
      }
      this.services = result.result;
      console.log(result.result);
    }, error => {
      //TODO
      console.error(error);
    });
  }

}
