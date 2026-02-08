import { Component, OnInit, OnDestroy } from '@angular/core';
import { DatePipe } from '@angular/common';

/**
 * The timer is not updating every second as expected.
 * Only updating when page loads or reloads.
 * Need to find the issue and fix it....
 */

@Component({
  selector: 'app-date-and-time',
  standalone: true,
  imports: [DatePipe],
  templateUrl: './date-and-time.html',
  styleUrl: './date-and-time.css',
})
export class DateAndTime implements OnInit, OnDestroy {
  now = new Date();

  private timerId!: any;

  ngOnInit() {
    this.timerId = setInterval(() => {
      this.now = new Date();
    }, 1000);
  }

  ngOnDestroy() {
    clearInterval(this.timerId);
  }
}
