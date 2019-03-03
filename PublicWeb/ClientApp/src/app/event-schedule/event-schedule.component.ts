import { Component, OnInit, Inject } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { EventSchedule } from '../models/event-schedule';
import { EventScheduleService } from '../services/event-schedule.service';
import { Location } from '@angular/common';
import { BaseComponent } from '../base/base.component';
import { MatDialog } from '@angular/material';
import { ServicePlacePosition } from '../models/service-place-position';
import { BookingService } from '../services/booking.service';
import { PendingBooking } from '../models/pending-booking';
import * as signalR from "@aspnet/signalr";
@Component({
  selector: 'app-event-schedule',
  templateUrl: './event-schedule.component.html',
  styleUrls: ['./event-schedule.component.css']
})
export class EventScheduleComponent extends BaseComponent {
  schedule: EventSchedule;
  selectedPositions: ServicePlacePosition[];
  baseUrl: string;
  constructor(
    public dialog: MatDialog,
    private bookingService: BookingService,
    private scheduleService: EventScheduleService,
    @Inject('BASE_URL') baseUrl: string,
    private route: ActivatedRoute,
    private router: Router,
    private location: Location) {
    super(dialog);
    this.selectedPositions = [];
    this.baseUrl = baseUrl;
  }

  ngOnInit() {
    const connection = new signalR.HubConnectionBuilder()
      .withUrl(`${this.baseUrl}bookingHub`)
      .build();
    connection.start().catch(err => document.write(err));
    connection.on("RecieveNewPendingBooking", (pendingBooking: PendingBooking) => {
      this.schedule.pendingBookings.push(pendingBooking);
    });
    const id = this.route.snapshot.paramMap.get('id');
    this.scheduleService.getSchedule(id).subscribe(result => {
      if (!result.success) {
        this.openDialog(result.message);
      }
      this.schedule = result.result;
    }, error => {
      this.openDialog("Hiba a kérés során.");
      console.error(error);
    });
  }
  createPendingBooking() {
    let pBooking = { eventScheduleId: this.schedule.id, positions: this.selectedPositions } as PendingBooking;
    this.bookingService.createPendingBooking(pBooking).subscribe(res => {
      if (res.success) {
       this.router.navigate(['/booking', res.result]);
      } else {
        this.openDialog("A foglalás indítása sikertelen.");
      }
    }, error => {
      this.openDialog("Hiba a kérés során.");
      console.error(error);
    })
  }
  positionSelected(position: ServicePlacePosition) {
    if (this.containsBooking(position))
    return;
    if (this.containsPending(position))
      return;
    let containedElement = this.selectedPositions.find(x => x.id == position.id);
    if (containedElement) {
      this.selectedPositions = this.selectedPositions.filter(x => x.id != position.id);
    } else {
      this.selectedPositions.push(position);
    }
  }
  isSelected(position: ServicePlacePosition) {
    return this.selectedPositions.find(x => x.id == position.id);
  }
  containsPending(position: ServicePlacePosition): boolean {
    let result = false;
    let currentTime = new Date();
    this.schedule.pendingBookings.filter(x => new Date(x.expirationDate) > currentTime).forEach(element => {
      if (element.positions.find(x => x.id == position.id))
        result = true;
    });
    return result;
  }
  containsBooking(position: ServicePlacePosition): boolean {
    let result = false;
    let currentTime = new Date();
    this.schedule.bookings.forEach(element => {
      if (element.positions.find(x => x.id == position.id))
        result = true;
    });
    return result;
  }
}
