import { Routes } from '@angular/router';
import { Home } from './home/home';
import { About } from './about/about';
import { Contact } from './contact/contact';
import { Details } from './details/details';
import { TurtleArmy } from './turtle-army/turtle-army';
import { NotFound } from './not-found/not-found';

export const routes: Routes = [
  { path: '', component: Home },
  { path: 'about', component: About },
  { path: 'contact', component: Contact },
  { path: 'details', component: Details },
  { path: 'turtle-army', component: TurtleArmy },
  { path: '**', component: NotFound },
];
