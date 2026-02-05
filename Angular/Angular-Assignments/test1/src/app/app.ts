import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Images } from './images/images';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Images],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('test1');
}
