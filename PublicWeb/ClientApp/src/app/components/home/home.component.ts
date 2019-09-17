import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EventService } from '../../services/event.service';
import { Event as MyEvent } from '../../models/event';
import { Service } from '../../models/service';
import { ServiceService } from '../../services/service.service';
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
    private eventService: EventService, 
    private serviceService: ServiceService) {
  }
  ngOnInit() {
    this.eventService.getTopFive().subscribe(result => {
      if (!result.success) {
        //TODO
      }
      this.events = result.result;
    }, error => {
      //TODO
      console.error(error);
    });
    this.serviceService.getTopFive().subscribe(result => {
      if (!result.success) {
        //TODO
      }
      this.services = result.result;
    }, error => {
      //TODO
      console.error(error);
    });
  }
}
