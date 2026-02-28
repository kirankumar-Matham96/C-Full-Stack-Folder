import { Routes } from '@angular/router';

export const NOTFOUND_ROUTES: Routes = [
  { path: '', loadComponent: () => import('./notfound').then((component) => component.Notfound) },
];
