import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { CreateBooking } from '../../models/create-booking';
import { BookingService } from '../../services/booking.service';
import { MatDialog } from '@angular/material';
import { HtmlHelperService } from '../../services/html-helper.service';
import { Location } from '@angular/common';
import { PendingBooking } from '../../models/pending-booking';


@Component({
  selector: 'app-booking',
  templateUrl: './booking.component.html',
  styleUrls: ['./booking.component.css']
})
export class BookingComponent implements OnInit, OnDestroy{

  model: CreateBooking;
  submitted = false;
  bookingId: string;
  pendingBooking: PendingBooking;
  min: string;
  sec: string;
  intervalId: NodeJS.Timeout;
  constructor(private route: ActivatedRoute,
    public dialog: MatDialog,
    private router: Router,
    private htmlHelper: HtmlHelperService,
    private bookingService: BookingService,
    public location: Location) {
  }

  ngOnInit() {
    this.pendingBooking = this.location.getState() as PendingBooking;
    this.model = new CreateBooking(this.pendingBooking.id, "", "", "");
    const self = this;
    this.intervalId =  setInterval(() => {
      let expDate = new Date(self.pendingBooking.expirationDate);
      let now = new Date();
      let diff = expDate.getTime() - now.getTime();
      if (diff <= 0) {
        self.location.back();
      } else {
        let minInt = Math.floor((diff / 1000) / 60);
        self.min = `${minInt}`.padStart(2, '0');
        diff = diff - (minInt * 60 * 1000);
        self.sec = `${Math.floor(diff / 1000)}`.padStart(2, '0');
      }
    }, 1000);
  }
  ngOnDestroy(): void {
    clearInterval(this.intervalId);
  }
  onSubmit() {
    this.bookingService.createBooking(this.model).subscribe(res => {
      if (res.success) {
        this.submitted = true;
        this.bookingId = res.result;
      } else {
        this.htmlHelper.showErrorMessage(res.message);
      }
    }, err => {
      this.htmlHelper.showErrorMessage('Hiba a foglalás rögzítése során.');
    })
  }
}
