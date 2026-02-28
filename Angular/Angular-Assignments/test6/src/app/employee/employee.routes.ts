import { Routes } from '@angular/router';

export const EMPLOEE_ROUTES: Routes = [
  { path: '', loadComponent: () => import('./employee').then((component) => component.Employee) },
];
