import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `<h1> {{title}} </h1>
              <fa-other><p>AAAAAAA</p></fa-other>
              <fa-databinding></fa-databinding>`,
  styles: [`h1 { color : red ;}`]
})
export class AppComponent {
  title = 'app sucks!';
}
