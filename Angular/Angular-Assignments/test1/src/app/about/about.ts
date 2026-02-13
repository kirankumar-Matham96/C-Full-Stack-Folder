import { Component } from '@angular/core';
import { Test } from '../test';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-about',
  imports: [CommonModule],
  templateUrl: './about.html',
  styleUrl: './about.css',
})
export class About {
  constructor(public ts: Test) {}
}
