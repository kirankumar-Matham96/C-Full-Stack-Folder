import { Component, input, OnInit } from '@angular/core';

interface User {
  id: {
    name: string;
    value: string;
  };
  email: string;
  name: {
    title: string;
    first: string;
    last: string;
  };
  age: string;
  gender: string;
  phone: string;
  picture: {
    large: string;
    medium: string;
    thumbnail: string;
  };
}

@Component({
  selector: 'app-users',
  imports: [],
  templateUrl: './users.html',
  styleUrl: './users.css',
})
export class Users implements OnInit {
  userData = input<User>();

  ngOnInit() {
    console.log({ userDataInUsres: this.userData() });
  }
}
