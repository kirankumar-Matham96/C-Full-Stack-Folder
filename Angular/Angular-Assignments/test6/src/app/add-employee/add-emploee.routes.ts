import { Routes } from '@angular/router';

export const ADD_EMPLOYEE_ROUTES: Routes = [
  {
    path: '',
    loadComponent: () => import('./add-employee').then((component) => component.AddEmployee),
  },
];
