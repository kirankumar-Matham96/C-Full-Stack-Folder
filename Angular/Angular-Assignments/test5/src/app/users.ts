import { Injectable } from '@angular/core';

interface User {
  id: string;
  username: string;
  email: string;
  password: string;
}

interface UserLoginData {
  username: string;
  password: string;
}

@Injectable({
  providedIn: 'root',
})
export class Users {
  users: User[] = [
    { id: 'user-1  ', username: 'aaa', email: 'aaa@gmail.com', password: 'aaaaaaaa' },
  ];

  addUser(userData: User) {
    this.users.push(userData);
  }

  confirmCredentials(userLoginData: UserLoginData): boolean {
    let user = this.users.find(
      (user) =>
        (user.username === userLoginData.username || user.email === userLoginData.username) &&
        user.password === userLoginData.password,
    );
    return user ? true : false;
  }
}
