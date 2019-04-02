import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { EventScheduleComponent } from './event-schedule/event-schedule.component';
import { EventScheduleService } from './services/event-schedule.service';
import { MAT_DIALOG_DEFAULT_OPTIONS, MatDialog, MatDialogModule, MatFormFieldModule, MatNativeDateModule } from '@angular/material';
import { OverlayModule } from '@angular/cdk/overlay';
import { BaseComponent } from './base/base.component';
import { BookingService } from './services/booking.service';
import { ServiceService } from './services/service.service';
import { BookingComponent } from './booking/booking.component';
import { ServiceListComponent } from './service-list/service-list.component';
import { ServiceTypeListComponent } from './service-type-list/service-type-list.component';
import { NgxPaginationModule } from 'ngx-pagination';
import { EventListComponent } from './event-list/event-list.component';
import { EventService } from './services/event.service';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatInputModule } from '@angular/material';
import { MatButtonModule } from '@angular/material/button';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';


import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { LoadComponent } from './load/load.component';
import { EventComponent } from './event/event.component';
import { MatSelectModule } from '@angular/material/select';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    EventScheduleComponent,
    BaseComponent,
    BookingComponent,
    ServiceListComponent,
    ServiceTypeListComponent,
    EventListComponent,
    LoadComponent,
    EventComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    MatFormFieldModule,
    MatInputModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatProgressSpinnerModule,
    MatDialogModule,
    MatButtonModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    OverlayModule,
    MatSelectModule,
    NgxPaginationModule,
    RouterModule.forRoot([
      { path: '', component: ServiceTypeListComponent, pathMatch: 'full' },
      { path: 'event-schedule', component: EventScheduleComponent },
      { path: 'event-schedule/:id', component: EventScheduleComponent, pathMatch: 'full' },
      { path: 'event-list', component: EventListComponent },
      { path: 'event-list/:id', component: EventListComponent, pathMatch: 'full' },
      { path: 'service', component: ServiceListComponent },
      { path: 'service/:name/:id', component: ServiceListComponent, pathMatch: 'full' },
      { path: 'booking/:id', component: BookingComponent }
    ])
  ],
  exports: [
    MatDatepickerModule,
    MatFormFieldModule,
    MatProgressSpinnerModule],
  providers: [
    EventScheduleService,
    BookingService,
    ServiceService,
    EventService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
