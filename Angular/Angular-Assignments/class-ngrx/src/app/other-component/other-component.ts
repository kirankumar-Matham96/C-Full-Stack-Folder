import { Component } from '@angular/core';
import { TestService } from '../test-service';

@Component({
  selector: 'app-other-component',
  imports: [],
  templateUrl: './other-component.html',
  styleUrl: './other-component.css',
})
export class OtherComponent {
  constructor(public testService: TestService) {}
}
