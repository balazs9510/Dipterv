import { Component, OnInit, ViewChildren } from '@angular/core';
import { Event as MyEvent } from '../../models/event';
import { ActivatedRoute, Router } from '@angular/router';
import { EventService } from '../../services/event.service';
import { EventSearchParameter } from '../../models/search-paramters/event-search-paramter';
import { NgbDate } from '@ng-bootstrap/ng-bootstrap/datepicker/ngb-date';
import { HtmlHelperService } from '../../services/html-helper.service';

declare var $: any;
@Component({
  selector: 'app-event-list-page',
  templateUrl: './event-list-page.component.html',
  styleUrls: ['./event-list-page.component.css']
})
export class EventListPageComponent implements OnInit {
  events: MyEvent[];
  date: NgbDate;
  searchParameter: EventSearchParameter = {
    ServiceId: '',
    BeginDate: null,
    Name: ''
  };
  serviceId = '';
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private eventService: EventService,
    private htmlHelper: HtmlHelperService) {
  }

  ngOnInit() {
    this.searchParameter.ServiceId = this.route.snapshot.paramMap.get('id');
    this.serviceId = this.searchParameter.ServiceId;
    this.onSearch();
  }
  onSearch() {
    if (this.date != null) {
      this.searchParameter.BeginDate = new Date(this.date.year, this.date.month, this.date.day);
    } else {
      this.searchParameter.BeginDate = null;
    }
    this.eventService.getEvents(this.searchParameter).subscribe(result => {
      if (!result.success) {
        this.htmlHelper.showErrorMessage(result.message);
      }
      this.events = result.result;
    }, error => {
      this.htmlHelper.showErrorMessage('Hiba az események betöltése során.');
    });
  }
}
