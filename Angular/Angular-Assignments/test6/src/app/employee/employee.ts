import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../employee-service';

@Component({
  selector: 'app-employee',
  imports: [],
  templateUrl: './employee.html',
  styleUrl: './employee.css',
})
export class Employee implements OnInit {
  public id: any[] = [];
  public name: any[] = [];
  public salary: any[] = [];
  public email: any[] = [];
  public department: any[] = [];

  public empData: any = []; // not type safe

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
