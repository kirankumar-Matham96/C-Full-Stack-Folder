import { Component, OnInit, signal } from '@angular/core';
import { Employee } from './employee/employee';
import { RouterOutlet } from '@angular/router';
// import { EmployeeService } from './employee-service';

@Component({
  selector: 'app-root',
  imports: [Employee, RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected readonly title = signal('test6');

  // employees: Employee[] = [];

  // constructor(private empService: EmployeeService) {}

  // angular hook that execute lifecycle method
  // ngOnInit(): void {
  //   this.empService.getEmployees().subscribe({
  //     next: (data) => {
  //       console.log(`API data: ${JSON.stringify(data)}`);
  //       this.employees = data;
  //     },
  //     error: (error) => console.error(`Error in UI Component from API: ${error}`),
  //   });
  // }
}
