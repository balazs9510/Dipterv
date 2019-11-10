import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EventService } from '../../services/event.service';
import { Event as MyEvent } from '../../models/event';
import { Service } from '../../models/service';
import { ServiceService } from '../../services/service.service';
import { HtmlHelperService } from '../../services/html-helper.service';
@Component({
  selector: 'app-home',
  styleUrls: ['./home.component.css'],
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  events: MyEvent[];
  services: Service[];
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private htmlHelper: HtmlHelperService,
    private eventService: EventService, 
    private serviceService: ServiceService) {
  }
  ngOnInit() {
    this.eventService.getTopFive().subscribe(result => {
      if (!result.success) {
        this.htmlHelper.showErrorMessage(result.message);
      }
      this.events = result.result;
    }, error => {
      this.htmlHelper.showErrorMessage('Hiba az események betöltése során.');
    });
    this.serviceService.getTopFive().subscribe(result => {
      if (!result.success) {
        this.htmlHelper.showErrorMessage(result.message);
      }
      this.services = result.result;
    }, error => {
      this.htmlHelper.showErrorMessage('Hiba a szolgáltatások betöltése során.');
    });
  }
}
