import {Component, Inject, OnInit, Input} from '@angular/core';
import {MatDialog, MAT_DIALOG_DATA} from '@angular/material';
@Component({
  selector: 'app-base',
  templateUrl: './base.component.html',
  styleUrls: ['./base.component.css']
})
export class BaseComponent implements OnInit {
  loading: boolean = false;
  constructor() {}

  ngOnInit() {
  }
}