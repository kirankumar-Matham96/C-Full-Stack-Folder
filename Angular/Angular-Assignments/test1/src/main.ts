import { bootstrapApplication } from '@angular/platform-browser';
// import { appConfig } from './app/app.config';
// import { Home } from './app/home/home';
// import { Contact } from './app/contact/contact';
// import { About } from './app/about/about';
// import { Notfound } from './app/notfound/notfound';
import { routes } from './app/app.routes';
import { App } from './app/app';
import { provideRouter } from '@angular/router';
import { Test } from './app/test';

// bootstrapApplication(App, appConfig)
bootstrapApplication(App, {
  providers: [provideRouter(routes), Test],
}).catch((err) => console.error(err));
