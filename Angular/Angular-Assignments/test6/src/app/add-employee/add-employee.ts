import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { EmployeeService } from '../employee-service';
import { Employee } from '../employee';

@Component({
  selector: 'app-add-employee',
  imports: [ReactiveFormsModule],
  templateUrl: './add-employee.html',
  styleUrl: './add-employee.css',
})
export class AddEmployee {
  constructor(private employeeService: EmployeeService) {}

  employeeRegistrationForm = new FormGroup({
    id: new FormControl<number>(0, { nonNullable: true, validators: Validators.required }),
    name: new FormControl<string>('', {
      nonNullable: true,
      validators: [Validators.required, Validators.minLength(3)],
    }),
    email: new FormControl<string>('', {
      nonNullable: true,
      validators: [Validators.required, Validators.email],
    }),
    salary: new FormControl<number>(0.0, {
      nonNullable: true,
      validators: [Validators.required, Validators.min(20000)],
    }),
    department: new FormControl<string>('', { nonNullable: true, validators: Validators.required }),
  });

  addNewEmployee(): void {
    console.log(`employeeRegistrationForm.value: ${this.employeeRegistrationForm.getRawValue()}`);
    console.log(`Is the form invalid: ${this.employeeRegistrationForm.invalid}`);
    if (this.employeeRegistrationForm.invalid) return;
    console.log('Form is valid');
    const employeeData: Employee = this.employeeRegistrationForm.getRawValue();

    this.employeeService
      .addEmployee(employeeData)
      .subscribe(() => console.log('Form Submitted...'));
    this.employeeRegistrationForm.reset();
  }
}
