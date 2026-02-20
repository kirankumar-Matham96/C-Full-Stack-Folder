import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormGroup, FormControl, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-change-password',
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './change-password.html',
  styleUrl: './change-password.css',
})
export class ChangePassword {
  changePassForm = new FormGroup(
    {
      password: new FormControl(),
      cpassword: new FormControl(),
    },
    this.customValidations.bind(this),
  );

  customValidations(ref: any) {
    let password = ref.controls['password'].value;
    let cpassword = ref.controls['cpassword'].value;

    return password === cpassword ? null : { mismatch: true };
  }

  clearForm() {
    this.changePassForm.reset();
  }
}
