import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { ServiceService } from '../../services/service.service';
import { Service } from '../../models/service';
import { ServiceSearchParamter } from '../../models/search-paramters/service-search-paramter';
import { HtmlHelperService } from '../../services/html-helper.service';
import { ServiceType } from '../../models/service-type';

@Component({
  selector: 'app-service-list-page',
  templateUrl: './service-list-page.component.html',
  styleUrls: ['./service-list-page.component.css']
})
export class ServiceListPageComponent implements OnInit {

  services: Service[];
  page = 1;
  serviceSearchParameter: ServiceSearchParamter;
  serviceTypes: ServiceType[];
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private serviceService: ServiceService,
    private htmlHelper: HtmlHelperService) {
    this.serviceSearchParameter = {
      name: '',
      serviceTypeId: '',
      city: ''
    };
    this.serviceTypes = [];
  }

  ngOnInit() {
    this.serviceService.getServiceTypes().subscribe(res => {
      if (!res.success) {
        this.htmlHelper.showErrorMessage(res.message);
      }
      this.serviceTypes = res.result;
    }, error => {
      this.htmlHelper.showErrorMessage('Hiba a szolgáltatástípusok betöltése során.');
    });
    this.onSearch();
  }
  onSearch() {
    this.serviceService.getServices(this.serviceSearchParameter).subscribe(result => {
      if (!result.success) {
        this.htmlHelper.showErrorMessage(result.message);
      }
      this.services = result.result;
    }, error => {
      this.htmlHelper.showErrorMessage('Hiba a szolgáltatások betöltése során.');
    });
  }

}
