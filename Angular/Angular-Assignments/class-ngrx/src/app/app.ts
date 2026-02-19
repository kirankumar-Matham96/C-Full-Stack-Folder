import { Component, signal } from '@angular/core';
import { TestService } from './test-service';
import { OtherComponent } from './other-component/other-component';
import { Signal2 } from './signal-2';
import { UsersService } from './users-service';
import { Users } from './users/users';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [OtherComponent, Users, RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected readonly title = signal('class-ngrx');

  constructor(
    public testService: TestService,
    public signal2: Signal2,
    private usersService: UsersService,
  ) {}

  userData: any;

  updateProductName(input: HTMLInputElement) {
    this.testService.updatePName(input.value);
    input.value = '';
  }

  updateProductName2(input: HTMLInputElement) {
    this.signal2.updateName(input.value);
    input.value = '';
  }

  updateProductPrice(input: HTMLInputElement) {
    this.signal2.updatePrice(Number(input.value));
    input.value = '';
  }

  updateProductQuantity(input: HTMLInputElement) {
    this.signal2.updateQuantity(Number(input.value));
    input.value = '';
  }

  async getUserDataFromService() {
    const data = await this.usersService.getUsers();
    console.log({ data: data.data.results });
    const { email, gender, id, name, phone, picture, dob } = data.data.results[0];
    this.userData = { email, gender, id, name, phone, picture, age: dob.age };
  }
}
