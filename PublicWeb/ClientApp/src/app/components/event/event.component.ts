import { Component, OnInit, Input, Output, EventEmitter, OnChanges } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EventService } from '../../services/event.service';
import { EventScheduleDateGroup } from '../../models/eventschedule-dategroup';
import { EventScheduleService } from '../../services/event-schedule.service';
import { Event } from '../../models/event';
import { Service } from '../../models/service';
import { ServiceService } from '../../services/service.service';

@Component({
  selector: 'app-event',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.css']
})
export class EventComponent implements OnChanges {
  @Input() public event: Event;
  @Input() public serviceId: string;
  eventDateGroup: EventScheduleDateGroup[];
  eventServiceList: Service[];
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private eventScheduleService: EventScheduleService,
    private serviceService: ServiceService
  ) { }

  ngOnChanges() {
    if (this.serviceId != null) {
      this.eventScheduleService.getEventDateGroups(this.event.id, this.serviceId).subscribe(result => {
        if (!result.success) {
          //TODO
          this.eventDateGroup = null;
        }
        this.eventDateGroup = result.result;
      }, error => {
        //TODO
        this.eventDateGroup = null;
        console.error(error);
      });
    }
    this.serviceService.getServicesOfEvent(this.event.id).subscribe(result => {
      if (!result.success) {
        //TODO
      }
      this.eventServiceList = result.result;
    }, error => {
      //TODO
      console.error(error);
    });
    
  }
  onServiceChanged(event){
    let serviceId = event.value;
    this.eventScheduleService.getEventDateGroups(this.event.id, serviceId).subscribe(result => {
      if (!result.success) {
        //TODO
        this.eventDateGroup = null;
      }
      this.eventDateGroup = result.result;
    }, error => {
      //TODO
      this.eventDateGroup = null;
      console.error(error);
    });
  }
}
