import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { ServiceService } from '../services/service.service';
import { Service } from '../models/service';
import { ServiceSearchParamter } from '../models/search-paramters/service-search-paramter';
import { HtmlHelperService } from '../services/html-helper.service';

@Component({
  selector: 'app-service-list',
  templateUrl: './service-list.component.html',
  styleUrls: ['./service-list.component.css']
})
export class ServiceListComponent implements OnInit {

  services: Service[];
  serviceTypeName: string;
  page = 1;
  serviceSearchParameter: ServiceSearchParamter = {
    name: '',
    serviceTypeId: '',
    city: ''
  };
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private serviceService: ServiceService,
    private htmlHelper: HtmlHelperService) { }

  ngOnInit() {
    this.serviceSearchParameter.serviceTypeId = this.route.snapshot.paramMap.get('id');
    this.serviceTypeName = this.route.snapshot.paramMap.get('name');
    this.htmlHelper.showLoader();
    this.serviceService.getServices(this.serviceSearchParameter).subscribe(result => {
      if (!result.success) {
        this.htmlHelper.showErrorMessage('Hiba a szolgáltatások betöltése során.');
      }
      this.services = result.result;
      this.htmlHelper.hideLoader();
    }, error => {
      this.htmlHelper.showErrorMessage('Hiba a szolgáltatások betöltése során.');
    });
  }
  onSearch() {
    this.htmlHelper.showLoader();
    this.serviceService.getServices(this.serviceSearchParameter).subscribe(result => {
      if (!result.success) {
        this.htmlHelper.showErrorMessage('Hiba a szolgáltatások betöltése során.');
      }
      this.services = result.result;
      this.htmlHelper.hideLoader();
    }, error => {
      this.htmlHelper.showErrorMessage('Hiba a szolgáltatások betöltése során.');
    });
  }

}
