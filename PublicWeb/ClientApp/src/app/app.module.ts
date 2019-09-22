import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgbModule, NgbDatepickerModule } from '@ng-bootstrap/ng-bootstrap';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './components/home/home.component';
import { EventScheduleComponent } from './components/event-schedule/event-schedule.component';
import { EventScheduleService } from './services/event-schedule.service';
import { MAT_DIALOG_DEFAULT_OPTIONS, MatDialog, MatDialogModule, MatFormFieldModule, MatNativeDateModule } from '@angular/material';
import { OverlayModule } from '@angular/cdk/overlay';
import { BookingService } from './services/booking.service';
import { ServiceService } from './services/service.service';
import { BookingComponent } from './components/booking/booking.component';
import { ServiceListPageComponent } from './components/service-list-page/service-list-page.component';
import { NgxPaginationModule } from 'ngx-pagination';
import { EventListPageComponent } from './components/event-list-page/event-list-page.component';
import { EventService } from './services/event.service';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatInputModule } from '@angular/material';
import { MatButtonModule } from '@angular/material/button';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';


import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatSelectModule } from '@angular/material/select';
import { TestComponent } from './components/test/test.component';
import { HtmlHelperService } from './services/html-helper.service';
import { LoaderComponent } from './components/loader/loader.component';
import { LoaderService } from './services/loader.service';
import { LoaderInterceptor } from './interceptors/loader.interceptor';
import { EventPageComponent } from './components/event-page/event-page.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    EventScheduleComponent,
    BookingComponent,
    ServiceListPageComponent,
    EventListPageComponent,
    EventPageComponent,
    TestComponent,
    LoaderComponent
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
    NgbModule,
    NgbDatepickerModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    OverlayModule,
    MatSelectModule,
    NgxPaginationModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent },
      { path: 'test', component: TestComponent, pathMatch: 'full' },
      { path: 'event-schedule', component: EventScheduleComponent },
      { path: 'event-schedule/:id', component: EventScheduleComponent, pathMatch: 'full' },
      { path: 'event-list', component: EventListPageComponent },
      { path: 'event-list/:id', component: EventListPageComponent, pathMatch: 'full' },
      { path: 'service-list', component: ServiceListPageComponent },
      { path: 'service/:name/:id', component: ServiceListPageComponent, pathMatch: 'full' },
      { path: 'booking', component: BookingComponent },
      { path: 'event/:id/:serviceId', component: EventPageComponent },
      { path: 'event/:id', component: EventPageComponent }
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
    EventService,
    HtmlHelperService,
    LoaderService,
    { provide: HTTP_INTERCEPTORS, useClass: LoaderInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
