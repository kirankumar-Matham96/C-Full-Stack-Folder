import { Component } from '@angular/core';
import { ReactiveFormsModule, FormGroup, FormControl, Validators } from '@angular/forms';
import { JsonPipe } from '@angular/common';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-register-2',
  imports: [ReactiveFormsModule, CommonModule, JsonPipe],
  templateUrl: './register-2.html',
  styleUrl: './register-2.css',
})
export class Register2 {
  register1 = new FormGroup({
    uname: new FormControl(''),
    password: new FormControl(''),
    city: new FormControl(''),
    gender: new FormControl(''),
    chat: new FormControl(''),
    movies: new FormControl(''),
    sports: new FormControl(''),
  });

  register2 = new FormGroup({
    uname: new FormControl('', [Validators.required, Validators.minLength(8)]),
    email: new FormControl('', [Validators.required, Validators.email]),
  });
}
