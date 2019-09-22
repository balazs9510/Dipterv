import { Component, OnInit, Inject, AfterContentInit, AfterViewInit, OnDestroy } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { EventSchedule } from '../../models/event-schedule';
import { EventScheduleService } from '../../services/event-schedule.service';
import { Location } from '@angular/common';
import { MatDialog } from '@angular/material';
import { ServicePlacePosition } from '../../models/service-place-position';
import { BookingService } from '../../services/booking.service';
import { PendingBooking } from '../../models/pending-booking';
import * as signalR from '@aspnet/signalr';
import { Booking } from '../../models/booking';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';
import { AbstractControl, ValidatorFn } from '@angular/forms';
import { HtmlHelperService } from '../../services/html-helper.service';
declare var $: any;
@Component({
  selector: 'app-event-schedule',
  templateUrl: './event-schedule.component.html',
  styleUrls: ['./event-schedule.component.css']
})
export class EventScheduleComponent implements AfterViewInit, OnInit, OnDestroy {

  schedule: EventSchedule;
  selectedPositions: ServicePlacePosition[];
  baseUrl: string;
  servicePlaceSvg: SafeHtml;
  positionName: string;
  errorMessage: string;
  intervalId: NodeJS.Timeout;
  constructor(
    private sanitizer: DomSanitizer,
    private bookingService: BookingService,
    private scheduleService: EventScheduleService,
    private htmlHelper: HtmlHelperService,
    @Inject('BASE_URL') baseUrl: string,
    private route: ActivatedRoute,
    private router: Router) {
    this.selectedPositions = [];
    this.baseUrl = baseUrl;
  }

  ngOnInit() {
    const connection = new signalR.HubConnectionBuilder()
      .withUrl(`${this.baseUrl}bookingHub`)
      .build();
    connection.start().catch(err => this.htmlHelper.showErrorMessage('Hiba a kapcsolat felépítése során.<br>Kérem próbálja újra!'));
    connection.on('RecieveNewPendingBooking', (pendingBooking: PendingBooking) => {
      this.schedule.pendingBookings.push(pendingBooking);
      const colored = this.colorSVGElements($(`#svg-holder`));
      $(`#svg-holder`).html($(colored)[0].innerHTML);
    });
    connection.on('RecieveNewBooking', (booking: Booking) => {
      this.schedule.bookings.push(booking);
      $(`#svg-holder`).html(this.colorSVGElements($(`#svg-holder`)));
    });
    let self = this;
    this.intervalId = setInterval(function () {
      self.refreshPendingBooking(self);
    }, 1000);
  }
  ngOnDestroy(): void {
    clearInterval(this.intervalId);
  }
  ngAfterViewInit() {
    const id = this.route.snapshot.paramMap.get('id');
    this.scheduleService.getSchedule(id).subscribe(result => {
      if (!result.success) {
        this.htmlHelper.showErrorMessage(result.message);
      }
      this.schedule = result.result;
      const coloredSVG = this.colorSVGElements(this.schedule.servicePlace.layoutImage);
      this.servicePlaceSvg = this.sanitizer.bypassSecurityTrustHtml(coloredSVG);
    }, error => {
      this.htmlHelper.showErrorMessage('Hiba a kapcsolat felépítése során.<br>Kérem próbálja újra!');
    });
  }
  onServicePlacePositionClick(e) {
    const element = $(e.target);
    if (!element.hasClass('bookable')) {
      return;
    } else {
      const positionId = element.data('position-id');
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
      $(`#svg-holder [data-position-id="${positionId}"]`).removeClass('active');
    } else {
      const position = this.schedule.servicePlace.layout.filter(x => x.id == positionId)[0];
      this.selectedPositions.push(position);
      $(`#svg-holder [data-position-id="${positionId}"]`).addClass('active');
    }
  }
  private createPendingBooking() {
    const pBooking = { eventScheduleId: this.schedule.id, positions: this.selectedPositions } as PendingBooking;
    this.bookingService.createPendingBooking(pBooking).subscribe(res => {
      if (res.success) {
        this.router.navigateByUrl('/booking', { state: res.result });
      } else {
        this.htmlHelper.showErrorMessage(res.message);
      }
    }, error => {
      this.htmlHelper.showErrorMessage('Hiba a foglalás rögzítése során.');
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
    if (parseInt(el.attr('height'))) {
      let oldWidth = el.attr('width');
      let oldHeight = parseInt(el.attr('height'));
      el.attr('width', '100%');
      el.removeAttr('height');
      el.attr('preserveAspectRatio', 'xMidYMid meet');
      el.attr('viewBox', `0 0 ${oldWidth} ${oldHeight + 20}`);
    }

    $(el).find('.bookable').removeClass('active');
    $(el).find('.booked').removeClass('booked');
    $(el).find('.pending').removeClass('pending');
    const currentTime = new Date();
    this.selectedPositions.forEach(element => {
      $(el).find(`[data-position-id="${element.id}"]`).addClass('active');
    });
    this.schedule.bookings.forEach(element => {
      element.positions.forEach(pos => {
        $(el).find(`[data-position-id="${pos.id}"]`).addClass('booked');
      });
    });
    this.schedule.pendingBookings.filter(x => new Date(x.expirationDate) > currentTime).forEach(element => {
      element.positions.forEach(pos => {
        $(el).find(`[data-position-id="${pos.id}"]`).addClass('pending');
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
  refreshPendingBooking(self) {
    const el = $(`#svg-holder`).clone();
    const now = new Date();
    if (self.schedule && self.schedule.pendingBookings) {
      self.schedule.pendingBookings.forEach(pb => {
        if (new Date(pb.expirationDate) <= now) {
          pb.positions.forEach(pos => {
            $(el).find(`[data-position-id="${pos.id}"]`).removeClass('pending');
          });
        }
      });
      $(`#svg-holder`).html($(el)[0].innerHTML);
    }
    self.schedule.pendingBookings = self.schedule.pendingBookings.filter(x => new Date(x.expirationDate) > now);
  }
}
