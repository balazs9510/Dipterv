import { Component, OnInit, ViewChildren } from '@angular/core';
import { Event as MyEvent } from '../models/event';
import { ActivatedRoute, Router } from '@angular/router';
import { EventService } from '../services/event.service';
import { EventSearchParameter } from '../models/search-paramters/event-search-paramter';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { FormControl } from '@angular/forms';
import { Overlay } from '@angular/cdk/overlay';
import { ComponentPortal } from '@angular/cdk/portal';
import { Image } from '../models/image';
import { NgbDate } from '@ng-bootstrap/ng-bootstrap/datepicker/ngb-date';
declare var $: any;
@Component({
  selector: 'app-event-list',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.css']
})
export class EventListComponent implements OnInit {
  loading = false;
  events: MyEvent[];
  date: NgbDate;
  selectedEvent: MyEvent;
  searchParameter: EventSearchParameter = {
    ServiceId: '',
    BeginDate: null,
    Name: ''
  };
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
    if (this.date != null)
      this.searchParameter.BeginDate = new Date(this.date.year, this.date.month, this.date.day)
    else
      this.searchParameter.BeginDate = null;
    this.eventService.getEvents(this.searchParameter).subscribe(result => {
      if (!result.success) {
        //TODO
      }
      this.events = result.result;
      for (let i = 0; i < this.events.length; i++) {
        const item = this.events[i];
        //this.createImageFromBlob(item.image);
      }
      console.log(result.result);
      console.log(this.events);
      this.loading = false;
    }, error => {
      //TODO
      console.error(error);
    });
  }
  // createImageFromBlob(image: Image) {
  //   let reader = new FileReader();
  //   reader.addEventListener("load", () => {
  //     image.display = reader.result;
  //   }, false);
  //   if (image) {
  //     let blob = new Blob([image.content], { type: `image/jpeg` });
  //     reader.readAsDataURL(blob);
  //   }
  // }
  onEventSelect(selected: MyEvent) {
    console.log(selected);
    this.selectedEvent = selected;
  }
}
