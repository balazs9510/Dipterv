import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { EventScheduleComponent } from './event-schedule/event-schedule.component';
import { EventScheduleService } from './services/event-schedule.service';
import { MAT_DIALOG_DEFAULT_OPTIONS, MatDialog, MatDialogModule } from '@angular/material';
import { OverlayModule } from '@angular/cdk/overlay';
import { BaseComponent, DialogDataExampleDialog } from './base/base.component';
import { BookingService } from './services/booking.service';
import { ServiceService } from './services/service.service';
import { BookingComponent } from './booking/booking.component';
import { ServiceListComponent } from './service-list/service-list.component';
import { ServiceTypeListComponent } from './service-type-list/service-type-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    EventScheduleComponent,
    BaseComponent,
    DialogDataExampleDialog,
    BookingComponent,
    ServiceListComponent,
    ServiceTypeListComponent        
  ],
  entryComponents: [DialogDataExampleDialog],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    MatDialogModule,
    BrowserAnimationsModule,
    FormsModule,
    OverlayModule,
    RouterModule.forRoot([
      { path: '', component: ServiceTypeListComponent, pathMatch: 'full' },
      { path: 'event-schedule', component: EventScheduleComponent },
      { path: 'event-schedule/:id', component: EventScheduleComponent, pathMatch: 'full' },
      { path: 'booking/:id', component: BookingComponent}
    ])
  ],
  providers: [ 
    EventScheduleService,
    BookingService,
    ServiceService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
