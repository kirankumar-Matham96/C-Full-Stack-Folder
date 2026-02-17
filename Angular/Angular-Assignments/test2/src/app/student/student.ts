import { Component } from '@angular/core';

@Component({
  selector: 'app-student',
  imports: [],
  templateUrl: './student.html',
  styleUrl: './student.css',
})
export class Student {
  id:string = "angular-123";
  name:string = "Kirankumar M";
  marks:number[] = [90, 50, 60, 70];
}
