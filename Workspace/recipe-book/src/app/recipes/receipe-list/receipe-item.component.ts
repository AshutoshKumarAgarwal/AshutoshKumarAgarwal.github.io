import { Component, OnInit } from '@angular/core';
import {Receipe} from './receipe.ts'


@Component({
  selector: 'rb-receipe-item',
  templateUrl: './receipe-item.component.html'
})
export class ReceipeItemComponent implements OnInit {

	receipe : Receipe;
  constructor() { }

  ngOnInit() {
  }

}
