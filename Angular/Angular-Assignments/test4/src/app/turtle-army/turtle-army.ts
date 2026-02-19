import { Component } from '@angular/core';
import { AddTurtleBtn } from '../add-turtle-btn/add-turtle-btn';

@Component({
  selector: 'app-turtle-army',
  imports: [AddTurtleBtn],
  templateUrl: './turtle-army.html',
  styleUrl: './turtle-army.css',
})
export class TurtleArmy {
  turtles: string[] = [];

  addTurtle(turtle: string) {
    this.turtles.push(turtle);
  }
}
