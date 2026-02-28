import { Routes } from '@angular/router';

export const DELETE_EMPLOEE_ROUTES: Routes = [
  {
    path: '',
    loadComponent: () => import('./delete-employee').then((component) => component.DeleteEmployee),
  },
];
