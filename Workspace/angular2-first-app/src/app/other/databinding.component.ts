import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'fa-databinding',
  templateUrl: `<button (click): onClicked>click me</button>`
})
export class DataBindingComponent {
    onClicked = new EventEmitter();

}
