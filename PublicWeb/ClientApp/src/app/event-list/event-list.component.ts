import { Component, OnInit, ViewChildren } from '@angular/core';
import { Event as MyEvent } from '../models/event';
import { ActivatedRoute, Router } from '@angular/router';
import { EventService } from '../services/event.service';
import { EventSearchParameter } from '../models/search-paramters/event-search-paramter';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { FormControl } from '@angular/forms';
import { BaseComponent } from '../base/base.component';
import { Overlay } from '@angular/cdk/overlay';
import { ComponentPortal } from '@angular/cdk/portal';

@Component({
  selector: 'app-event-list',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.css']
})
export class EventListComponent implements OnInit {
  loading: boolean = false;
  events: MyEvent[];
  date = new FormControl();
  selectedEvent: MyEvent;
  searchParameter: EventSearchParameter = {
    ServiceId: "",
    BeginDate: null,
    Name: ""
  }
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private eventService: EventService) {
  }

  ngOnInit() {
    this.searchParameter.ServiceId = this.route.snapshot.paramMap.get('id');
    this.onSearch();
  }
  onSearch() {
    this.loading = true;
    this.searchParameter.BeginDate = this.date.value;
    this.eventService.getEvents(this.searchParameter).subscribe(result => {
      if (!result.success) {
        //TODO
      }
      this.events = result.result;
      console.log(result.result);
      this.loading = false;
    }, error => {
      //TODO
      console.error(error);
    });
  }
  onEventSelect(selected: MyEvent) {
    console.log(selected);
    this.selectedEvent = selected;
  }
  onLoading(event) {
    if (event)
      this.loading = true;
    else
      this.loading = false;
  }
}
