import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../employee-service';
import { Employee as IEmployee } from '../employee';
@Component({
  selector: 'app-employee',
  imports: [],
  templateUrl: './employee.html',
  styleUrl: './employee.css',
})
export class Employee implements OnInit {
  public empData: IEmployee[] = [];

  constructor(private empService: EmployeeService) {}

  ngOnInit(): void {
    this.empService.getEmployees().subscribe({
      next: (data) => {
        this.empData = data;
      },
      error: (error) => console.error(error),
    });
  }
}
