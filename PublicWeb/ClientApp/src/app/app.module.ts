import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { EventScheduleComponent } from './event-schedule/event-schedule.component';
import { EventScheduleService } from './services/event-schedule.service';
import { MAT_DIALOG_DEFAULT_OPTIONS, MatDialog, MatDialogModule } from '@angular/material';
import { OverlayModule } from '@angular/cdk/overlay';
import { BaseComponent, DialogDataExampleDialog } from './base/base.component';
import { BookingService } from './services/booking.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    EventScheduleComponent,
    BaseComponent,
    DialogDataExampleDialog        
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
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'event-schedule/:id', component: EventScheduleComponent },
    ])
  ],
  providers: [ 
    EventScheduleService,
    BookingService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
