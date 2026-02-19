import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Users } from '../users';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-login',
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './login.html',
  styleUrl: './login.css',
})
export class Login {
  constructor(private users: Users) {}

  loginForm = new FormGroup({
    username: new FormControl('', [
      Validators.required,
      Validators.email,
      Validators.nullValidator,
    ]),
    password: new FormControl('', [
      Validators.required,
      Validators.minLength(8),
      Validators.maxLength(16),
    ]),
  });

  isLoginSuccess: boolean | null = null;

  login() {
    // validate
    if (!this.loginForm.valid) return;
    // const { username, password } = this.loginForm.value;
    const { username, password } = this.loginForm.getRawValue();
    this.isLoginSuccess = this.users.confirmCredentials({
      username: username ?? '',
      password: password ?? '',
    });
  }
}
