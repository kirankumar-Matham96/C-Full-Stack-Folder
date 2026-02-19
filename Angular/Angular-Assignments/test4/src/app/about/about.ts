import { Component } from '@angular/core';

@Component({
  selector: 'app-about',
  imports: [],
  templateUrl: './about.html',
  styleUrl: './about.css',
})
export class About {
  teamMembers = [
    { name: 'Jane Doe', role: 'CEO & Founder', photo: 'https://randomuser.me/api/portraits/men/31.jpg' },
    { name: 'Sara Lee', role: 'Head of Operations', photo: 'https://randomuser.me/api/portraits/women/20.jpg' },
    { name: 'John Smith', role: 'Lead Designer', photo: 'https://randomuser.me/api/portraits/men/20.jpg' }
  ];
}
