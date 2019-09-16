import { Component, OnInit } from '@angular/core';
import { ServiceType } from '../models/service-type';
import { ServiceService } from '../services/service.service';
import { HtmlHelperService } from '../services/html-helper.service';
declare var $: any;
@Component({
  selector: 'app-service-type-list',
  templateUrl: './service-type-list.component.html',
  styleUrls: ['./service-type-list.component.css']
})
export class ServiceTypeListComponent implements OnInit {

  serviceTypes: ServiceType[];
  constructor(private serviceService: ServiceService,
    private helper: HtmlHelperService) { }

  ngOnInit() {
    this.helper.showLoader();
    this.serviceService.getServiceTypes().subscribe(result => {
      if (!result.success) {
        this.helper.showErrorMessage('Hiba a típusok letöltése során');
      }
      this.serviceTypes = result.result;
      this.helper.hideLoader();
    }, error => {
      this.helper.showErrorMessage('Hiba a típusok letöltése során');
      console.error(error);
    });
  }

}
