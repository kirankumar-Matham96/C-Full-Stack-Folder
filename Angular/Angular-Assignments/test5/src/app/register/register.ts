import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Users } from '../users';
import { v4 as uuidv4 } from 'uuid';

@Component({
  selector: 'app-register',
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './register.html',
  styleUrl: './register.css',
})
export class Register {
  isSubmitted: boolean = false;

  constructor(private users: Users) {}

  registerForm = new FormGroup({
    fname: new FormControl('', [
      Validators.required,
      Validators.minLength(3),
      Validators.maxLength(20),
    ]),
    lname: new FormControl('', [
      Validators.required,
      Validators.minLength(3),
      Validators.maxLength(20),
    ]),
    email: new FormControl('', [Validators.required, Validators.email]),
    password: new FormControl('', [
      Validators.required,
      Validators.minLength(8),
      Validators.maxLength(16),
    ]),
  });

  addUser() {
    this.isSubmitted = true;

    if (!this.registerForm.valid) return;

    const userData = {
      id: uuidv4(),
      username: this.registerForm.value.fname! + this.registerForm.value.lname!,
      email: this.registerForm.value.email!,
      password: this.registerForm.value.password!,
    };

    this.users.addUser(userData);
  }
}
