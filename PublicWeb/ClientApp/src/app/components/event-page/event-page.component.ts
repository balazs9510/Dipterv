import { Component, OnInit, Input, Output, EventEmitter, OnChanges } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EventService } from '../../services/event.service';
import { EventScheduleDateGroup } from '../../models/eventschedule-dategroup';
import { EventScheduleService } from '../../services/event-schedule.service';
import { Event as MyEvent } from '../../models/event';
import { Service } from '../../models/service';
import { ServiceService } from '../../services/service.service';
import { HtmlHelperService } from '../../services/html-helper.service';

@Component({
  selector: 'app-event',
  templateUrl: './event-page.component.html',
  styleUrls: ['./event-page.component.css']
})
export class EventPageComponent implements OnInit {
  myEvent: MyEvent;
  serviceId: string;
  eventDateGroup: EventScheduleDateGroup[];
  eventServiceList: Service[];
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private eventScheduleService: EventScheduleService,
    private serviceService: ServiceService,
    private eventService: EventService,
    private htmlHelper: HtmlHelperService
  ) { }

  ngOnInit() {
    const id = this.route.snapshot.paramMap.get('id');
    this.serviceId = this.route.snapshot.paramMap.get('serviceId') || '';
    this.eventService.getEvent(id).subscribe(result => {
      if (!result.success) {
        this.htmlHelper.showErrorMessage(result.message);
      }
      this.myEvent = result.result;
    }, error => {
      this.htmlHelper.showErrorMessage('Hiba az esemény betöltése során.');
    });
    if (this.serviceId != null && this.serviceId != '') {
      this.eventScheduleService.getEventDateGroups(id, this.serviceId).subscribe(result => {
        if (!result.success) {
          this.htmlHelper.showErrorMessage(result.message);
          this.eventDateGroup = null;
        }
        this.eventDateGroup = result.result;
      }, error => {
        this.htmlHelper.showErrorMessage('Hiba az ütemezések betöltése során.');
        this.eventDateGroup = null;
      });
    }
    this.loadServices(id);
  }
  loadServices(id: string) {
    this.serviceService.getServicesOfEvent(id).subscribe(result => {
      if (!result.success) {
        this.htmlHelper.showErrorMessage(result.message);
      }
      this.eventServiceList = result.result;
    }, error => {
      this.htmlHelper.showErrorMessage('Hiba a szolgáltatások betöltése során.');
    });

  }
  onServiceChanged() {
    this.eventScheduleService.getEventDateGroups(this.myEvent.id, this.serviceId).subscribe(result => {
      if (!result.success) {
        this.htmlHelper.showErrorMessage(result.message);
        this.eventDateGroup = null;
      }
      this.eventDateGroup = result.result;
    }, error => {
      this.htmlHelper.showErrorMessage('Hiba az ütemezések betöltése során.');
      this.eventDateGroup = null;
    });
  }
}
