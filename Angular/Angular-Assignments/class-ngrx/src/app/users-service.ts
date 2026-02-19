import { Injectable } from '@angular/core';
import axios from 'axios';
@Injectable({
  providedIn: 'root',
})
export class UsersService {
  userData: any;

  async getUsers() {
    this.userData = await axios.get('https://randomuser.me/api/');
    // console.log({ data: this.userData });
    return this.userData;
    /**
     * data.data.results[] => dob,email, gender, id, location, name, phone, pictures:{large, medium, thumbnail}, registered:{age, date}
     */
  }
}
