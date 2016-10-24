import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'fa-other',
  templateUrl: `<article><ng-content></ng-content></article>`,
  styleUrls: [`article { color : blue }`]
})
export class OtherComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
