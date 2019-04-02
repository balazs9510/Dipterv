import { Component, OnInit, Input, Output, EventEmitter, OnChanges } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EventService } from '../services/event.service';
import { EventScheduleDateGroup } from '../models/eventschedule-dategroup';
import { EventScheduleService } from '../services/event-schedule.service';
import { Event } from '../models/event';
import { Service } from '../models/service';
import { ServiceService } from '../services/service.service';

@Component({
  selector: 'app-event',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.css']
})
export class EventComponent implements OnChanges {
  @Input() public event: Event;
  @Output() load = new EventEmitter<boolean>();
  eventDateGroup: EventScheduleDateGroup[];
  eventServiceList: Service[];
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private eventScheduleService: EventScheduleService,
    private serviceService: ServiceService
  ) { }

  ngOnChanges() {
    console.log(this.event);
    this.load.emit(true);
    this.serviceService.getServicesOfEvent(this.event.id).subscribe(result => {
      if (!result.success) {
        //TODO
      }
      this.eventServiceList = result.result;
      console.log(result.result);
      this.load.emit(false);
    }, error => {
      //TODO
      console.error(error);
    });
    
  }
  onServiceChanged(event){
    let serviceId = event.value;
    this.load.emit(true);
    this.eventScheduleService.getEventDateGroups(this.event.id, serviceId).subscribe(result => {
      if (!result.success) {
        //TODO
        this.eventDateGroup = null;
      }
      this.eventDateGroup = result.result;
      console.log(result.result);
      this.load.emit(false);
    }, error => {
      //TODO
      this.eventDateGroup = null;
      console.error(error);
    });
  }
}
