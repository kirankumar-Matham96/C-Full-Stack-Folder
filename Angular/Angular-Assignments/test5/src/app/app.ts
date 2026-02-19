import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Login } from './login/login';
import { Users } from './users';

@Component({
  selector: 'app-root',
  imports: [Login, RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
   protected readonly title = signal('test5');
}
