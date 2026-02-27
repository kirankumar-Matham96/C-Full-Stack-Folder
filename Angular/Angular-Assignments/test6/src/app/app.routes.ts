import { Routes } from '@angular/router';
import { Employee } from './employee/employee';
import { AddEmployee } from './add-employee/add-employee';
import { UpdateEmployee } from './update-employee/update-employee';
import { DeleteEmployee } from './delete-employee/delete-employee';
import { Notfound } from './notfound/notfound';

export const routes: Routes = [
  { path: '', component: Employee },
  { path: 'add-employee', component: AddEmployee },
  { path: 'update-employee', component: UpdateEmployee },
  { path: 'delete-employee', component: DeleteEmployee },
  { path: '**', component: Notfound },
];
