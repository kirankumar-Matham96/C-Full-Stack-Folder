import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Header } from './header/header';
import { Register2 } from './register-2/register-2';
import { ChangePassword } from './change-password/change-password';

@Component({
  selector: 'app-root',
  imports: [Header, Register2, ChangePassword, RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected readonly title = signal('test5');
}
