import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { CreateBooking } from '../../models/create-booking';
import { BookingService } from '../../services/booking.service';
import { MatDialog } from '@angular/material';

@Component({
  selector: 'app-booking',
  templateUrl: './booking.component.html',
  styleUrls: ['./booking.component.css']
})
export class BookingComponent {
  model: CreateBooking;
  submitted = false;
  constructor(private route: ActivatedRoute,
    public dialog: MatDialog,
    private router: Router,
    private bookingService: BookingService,) {
     }

  ngOnInit() {
    const id = this.route.snapshot.paramMap.get('id');
    this.model = new CreateBooking(id,"", "","");
  }
  onSubmit(){
    this.bookingService.createBooking(this.model).subscribe(res => {
      if(res.success){
        this.submitted = true;
      }
    }, err => {
     //todo
      console.log(err)
    })
  }
}
