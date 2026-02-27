import { Component } from '@angular/core';
import { ReactiveFormsModule, FormGroup, FormControl, Validators } from '@angular/forms';
import { EmployeeService } from '../employee-service';

@Component({
  selector: 'app-update-employee',
  imports: [ReactiveFormsModule],
  templateUrl: './update-employee.html',
  styleUrl: './update-employee.css',
})
export class UpdateEmployee {
  constructor(private employeeService: EmployeeService) {}

  employeeUpdateForm = new FormGroup({
    id: new FormControl<number>(0, { nonNullable: true, validators: Validators.required }),
    name: new FormControl<string>('', {
      nonNullable: true,
      validators: [Validators.required, Validators.minLength(3)],
    }),
    email: new FormControl<string>('', {
      nonNullable: true,
      validators: [Validators.required, Validators.email],
    }),
    salary: new FormControl<number>(0, {
      nonNullable: true,
      validators: [Validators.required, Validators.min(20000.0)],
    }),
    department: new FormControl<string>('', { nonNullable: true, validators: Validators.required }),
  });

  updateEmployee() {
    if (this.employeeUpdateForm.invalid) return;

    const employeeData = this.employeeUpdateForm.getRawValue();
    this.employeeService
      .updateEmployee(employeeData)
      .subscribe(() => alert('Employee Data Updated...'));
    this.employeeUpdateForm.reset();
  }
}
