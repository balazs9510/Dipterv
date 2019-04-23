import { Component, OnInit, Inject, AfterContentInit, AfterViewInit } from '@angular/core';
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
import * as signalR from '@aspnet/signalr';
import { Booking } from '../models/booking';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';
import { AbstractControl, ValidatorFn } from '@angular/forms';
declare var $: any;
@Component({
  selector: 'app-event-schedule',
  templateUrl: './event-schedule.component.html',
  styleUrls: ['./event-schedule.component.css']
})
export class EventScheduleComponent implements AfterViewInit, OnInit {
  schedule: EventSchedule;
  selectedPositions: ServicePlacePosition[];
  baseUrl: string;
  loading = false;
  servicePlaceSvg: SafeHtml;
  positionName: string;
  errorMessage: string;
  constructor(
    private sanitizer: DomSanitizer,
    public dialog: MatDialog,
    private bookingService: BookingService,
    private scheduleService: EventScheduleService,
    @Inject('BASE_URL') baseUrl: string,
    private route: ActivatedRoute,
    private router: Router,
    private location: Location) {
    this.selectedPositions = [];
    this.baseUrl = baseUrl;
  }

  ngOnInit() {
    const connection = new signalR.HubConnectionBuilder()
      .withUrl(`${this.baseUrl}bookingHub`)
      .build();
    connection.start().catch(err => /*document.write(err)*/ console.log(err));
    connection.on('RecieveNewPendingBooking', (pendingBooking: PendingBooking) => {
      this.schedule.pendingBookings.push(pendingBooking);
      $(`#svg-holder`).html(this.colorSVGElements($(`#svg-holder`)));
    });
    connection.on('RecieveNewBooking', (booking: Booking) => {
      this.schedule.bookings.push(booking);
      $(`#svg-holder`).html(this.colorSVGElements($(`#svg-holder`)));
    });
    this.loading = true;
  }
  ngAfterViewInit() {
    const id = this.route.snapshot.paramMap.get('id');
    this.scheduleService.getSchedule(id).subscribe(result => {
      if (!result.success) {
        //todo
      }
      this.loading = false;
      this.schedule = result.result;
      const coloredSVG = this.colorSVGElements(this.schedule.servicePlace.layoutImage);
      this.servicePlaceSvg = this.sanitizer.bypassSecurityTrustHtml(coloredSVG);
    }, error => {
      //todo
      console.error(error);
    });
  }
  onServicePlacePositionClick(e) {
    const element = $(e.target);
    if (!element.hasClass('bookable')) {
      return;
    } else {
      const positionId = element.data('position-id').toLowerCase();
      this.createSelection(positionId);
    }
  }
  private createSelection(positionId: string) {
    if (this.containsBooking(positionId)) {
      return;
    }
    if (this.containsPending(positionId)) {
      return;
    }
    const containedElement = this.selectedPositions.find(x => x.id == positionId);
    if (containedElement) {
      this.selectedPositions = this.selectedPositions.filter(x => x.id != positionId);
      $(`#svg-holder [data-position-id="${positionId.toUpperCase()}"]`).removeClass('active');
    } else {
      const position = this.schedule.servicePlace.layout.filter(x => x.id == positionId)[0];
      this.selectedPositions.push(position);
      $(`#svg-holder [data-position-id="${positionId.toUpperCase()}"]`).addClass('active');
    }
  }
  private createPendingBooking() {
    this.loading = true;
    const pBooking = { eventScheduleId: this.schedule.id, positions: this.selectedPositions } as PendingBooking;
    this.bookingService.createPendingBooking(pBooking).subscribe(res => {
      if (res.success) {
        this.router.navigate(['/booking', res.result]);
      } else {
        //todo
      }
    }, error => {
      //todo
      console.error(error);
    });
  }
  private containsPending(positionId): boolean {
    let result = false;
    const currentTime = new Date();
    this.schedule.pendingBookings.filter(x => new Date(x.expirationDate) > currentTime).forEach(element => {
      if (element.positions.find(x => x.id == positionId)) {
        result = true;
      }
    });
    return result;
  }
  private containsBooking(positionId): boolean {
    let result = false;
    this.schedule.bookings.forEach(element => {
      if (element.positions.find(x => x.id == positionId)) {
        result = true;
      }
    });
    return result;
  }
  private colorSVGElements(element) {
    const el = $(element).clone();
    $(el).find('.bookable').removeClass('active');
    $(el).find('.booked').removeClass('booked');
    $(el).find('.pending').removeClass('pending');
    const currentTime = new Date();
    this.selectedPositions.forEach(element => {
      $(el).find(`[data-position-id="${element.id.toUpperCase()}"]`).addClass('active');
    });
    this.schedule.bookings.forEach(element => {
      element.positions.forEach(pos => {
        $(el).find(`[data-position-id="${pos.id.toUpperCase()}"]`).addClass('booked');
      });
    });
    this.schedule.pendingBookings.filter(x => new Date(x.expirationDate) > currentTime).forEach(element => {
      element.positions.forEach(pos => {
        $(el).find(`[data-position-id="${pos.id.toUpperCase()}"]`).addClass('pending');
      });
    });
    return $(el)[0].outerHTML;
  }
  servicePlaceSelection() {
    if (this.positionName == "") {
      return;
    }
    const position = this.schedule.servicePlace.layout.filter(x => x.name.toLowerCase() == this.positionName.toLowerCase())[0];
    if (!position) {
      this.positionName = null;
      this.errorMessage = 'Ez a hely nem választható ki.';
      $('#errorModal').modal('show');
      return;
    }
    this.createSelection(position.id);
    this.positionName = null;
  }
}
