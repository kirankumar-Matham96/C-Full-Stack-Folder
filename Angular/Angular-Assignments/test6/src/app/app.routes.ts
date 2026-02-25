import { Routes } from '@angular/router';
import { Employee } from './employee/employee';
import { AddEmployee } from './add-employee/add-employee';

export const routes: Routes = [
  { path: '', component: Employee },
  { path: 'add-employee', component: AddEmployee },
  // {path: "/update-employee", component: UpdateEmployee},
];
