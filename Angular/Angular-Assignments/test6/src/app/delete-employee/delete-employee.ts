import { Component } from '@angular/core';
import { FormControl, ReactiveFormsModule, FormGroup, Validators } from '@angular/forms';
import { EmployeeService } from '../employee-service';

@Component({
  selector: 'app-delete-employee',
  imports: [ReactiveFormsModule],
  standalone: true,
  templateUrl: './delete-employee.html',
  styleUrl: './delete-employee.css',
})
export class DeleteEmployee {
  constructor(private emploeeService: EmployeeService) {}

  deleteFormGroup = new FormGroup({
    id: new FormControl<number>(0, { nonNullable: true, validators: Validators.required }),
  });

  removeEmplyee() {
    if (this.deleteFormGroup.invalid) {
      alert('Please Enter the employee ID');
      return;
    }

    if (
      this.deleteFormGroup.value &&
      this.deleteFormGroup.get('id')?.value !== null &&
      this.deleteFormGroup.get('id')?.value !== undefined
    ) {
      this.emploeeService.DeleteEmployee(this.deleteFormGroup.get('id')!.value).subscribe({
        next: () => {
          alert('Employee Removed successfully...');
          this.deleteFormGroup.reset();
        },
        error: (err: any) => console.error(err),
      });
    }
  }
}
