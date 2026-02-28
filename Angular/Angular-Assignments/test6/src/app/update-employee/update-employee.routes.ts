import { Routes } from '@angular/router';

export const UPDATE_EMPLOYEE_ROUTES: Routes = [
  {
    path: '',
    loadComponent: () => import('./update-employee').then((component) => component.UpdateEmployee),
  },
];
