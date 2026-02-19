import { Injectable } from '@angular/core';

interface User {
  id: string;
  username: string;
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
  users: User[] = [{ id: 'user-1  ', username: 'aaa@gmail.com', password: 'aaaaaaaa' }];

  addUser(userData: User) {
    this.users.push(userData);
  }

  confirmCredentials(userLoginData: UserLoginData): boolean {
    let user = this.users.find(
      (user) =>
        user.username === userLoginData.username && user.password === userLoginData.password,
    );

    console.log({ user });

    return user ? true : false;
  }
}
