import { Component } from '@angular/core';

@Component({
  selector: 'app-counter',
  imports: [],
  templateUrl: './counter.html',
  styleUrl: './counter.css',
})
export class Counter {
  count: number = 0;

  increaseCount() {
    this.count++;
  }

  decreaseCount() {
    this.count--;
  }
}
