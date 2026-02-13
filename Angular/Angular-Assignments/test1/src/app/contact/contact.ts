import { Component } from '@angular/core';
import { Test } from '../test';

@Component({
  selector: 'app-contact',
  imports: [],
  templateUrl: './contact.html',
  styleUrl: './contact.css',
})
export class Contact {
  constructor(public ts: Test) {}
}
