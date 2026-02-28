import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '',
    loadChildren: () =>
      import('./employee/employee.routes').then((component) => component.EMPLOEE_ROUTES),
  },
  {
    path: 'add-employee',
    loadChildren: () =>
      import('./add-employee/add-emploee.routes').then(
        (component) => component.ADD_EMPLOYEE_ROUTES,
      ),
  },
  {
    path: 'update-employee',
    loadChildren: () =>
      import('./update-employee/update-employee.routes').then(
        (component) => component.UPDATE_EMPLOYEE_ROUTES,
      ),
  },
  {
    path: 'delete-employee',
    loadChildren: () =>
      import('./delete-employee/delete-emploee.routes').then(
        (component) => component.DELETE_EMPLOEE_ROUTES,
      ),
  },
  {
    path: '**',
    loadChildren: () =>
      import('./notfound/notfound.routes').then((component) => component.NOTFOUND_ROUTES),
  },
];
