import { Component, OnInit } from '@angular/core';
declare var $: any;
@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
  onSvgClick(e) {
    console.log(e);
    let element = $(e.path[0]);
    console.log(element);
    $(e.target).addClass("red");
  }
}
