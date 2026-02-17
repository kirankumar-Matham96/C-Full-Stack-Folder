import { Component, signal } from '@angular/core';
import { Student } from './student/student';
import { JsonPipe } from '@angular/common';
// import { RouterOutlet } from '@angular/router';

// interface
interface IPerson {
  id: string;
  name: string;
  age: number;
  isStudent: boolean;
  phoneNumber: string;
}

let personTuple: [string, number, boolean]; // tuple declaration

// enum decalarations
enum rolesEnum {
  admin,
  user,
  staff,
}

@Component({
  selector: 'app-root',
  imports: [Student, JsonPipe],
  templateUrl: './app.html',
  styleUrl: './app.css',
})

// class datatype
export class App {
  protected readonly title = signal('test2');

  // using typescript variables with different datatypes
  name: string = 'Kirankumar'; // string datatype
  age: number = 26; // number datatype
  isStudent: boolean = true; // boolean datatype
  noValue: null = null; // null
  unknownValue: undefined = undefined; // undefined
  phoneNumber: bigint = 8975684213n; // bigint

  // object
  personObj: IPerson = {
    id: Symbol('id').toString(), // symbol
    name: this.name,
    age: this.age,
    isStudent: this.isStudent,
    phoneNumber: this.phoneNumber.toString(),
  };

  arr: number[] = [1, 2, 3, 4, 5]; // array

  personTuple = [this.name, this.age, this.isStudent]; // tuple assignment

  personRole = rolesEnum.admin; // enum

  // function
  getPersonDetails() {
    return this.personObj;
  }

  // function with string and number arguments
  getAgeEligibility(name: string, age: number): string {
    let isMajor: boolean = age > 18 ? true : false;
    return `${name} is ${isMajor ? 'major' : 'minor'}`;
  }

  // function with 3 integer arguments
  getSum(num1: number, num2: number, num3: number) {
    let sum = num1 + num2 + num3;
    return sum;
  }

  // funtcion with default and optional parameters and using call-back function
  setPersonDetails(
    cb: any = this.getConfirmationMessage,
    name: string = 'Kirankumar Matham',
    age: number = 25,
    phoneNumber?: bigint,
  ) {
    this.name = name;
    this.age = age;
    this.phoneNumber = phoneNumber || 7589641235n;
    cb();
  }

  getAge = (): number => this.age; // anonymouse function / arrow function

  getConfirmationMessage = (): string => 'The data is updated successfully!'; // anonymouse/arrow function used as call back function in another function
}
