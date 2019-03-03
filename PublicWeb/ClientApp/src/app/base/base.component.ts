import {Component, Inject, OnInit} from '@angular/core';
import {MatDialog, MAT_DIALOG_DATA} from '@angular/material';
@Component({
  selector: 'app-base',
  templateUrl: './base.component.html',
  styleUrls: ['./base.component.css']
})
export class BaseComponent implements OnInit {
  constructor(public dialog: MatDialog) {}

  ngOnInit() {
  }
  openDialog(msg: string) {
    this.dialog.open(DialogDataExampleDialog, { data : msg});
  }
}
@Component({
  // selector: 'dialog-data-example-dialog',
  templateUrl: 'error-dialog.html',
})
export class DialogDataExampleDialog {
  constructor(@Inject(MAT_DIALOG_DATA) public data: any) {}
}