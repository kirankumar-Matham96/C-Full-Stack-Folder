import { Component } from '@angular/core';
import {
  DatePipe,
  CurrencyPipe,
  JsonPipe,
  DecimalPipe,
  LowerCasePipe,
  UpperCasePipe,
  TitleCasePipe,
  PercentPipe,
  SlicePipe,
  // AsyncPipe,
} from '@angular/common';

interface IPerson {
  name: string;
  enrolledIn: string;
  institute: string;
}

@Component({
  selector: 'app-home',
  imports: [
    DatePipe,
    CurrencyPipe,
    JsonPipe,
    DecimalPipe,
    LowerCasePipe,
    UpperCasePipe,
    TitleCasePipe,
    PercentPipe,
    SlicePipe,
  ],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {
  date: any = undefined;
  price: number = 29.9947859;
  person: IPerson = {
    name: 'kirankumar',
    enrolledIn: 'dotnet fullstack',
    institute: 'SATHYA TECHNOLOGIES',
  };
  averageMarks: number = 85.6956;
  percentage: number = 85.5;
  arr: number[] = [4, 5, 8, 7, 1, 2, 5, 3, 6, 9, 8];
  isClicked: boolean = false;
  // async pipe - used to wait for a promise to complete

  getDate() {
    this.date = new Date();
    this.isClicked = true;
  }
}
