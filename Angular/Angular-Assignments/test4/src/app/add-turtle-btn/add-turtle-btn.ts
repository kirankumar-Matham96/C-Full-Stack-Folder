import { Component, input, output } from '@angular/core';

@Component({
  selector: 'app-add-turtle-btn',
  imports: [],
  templateUrl: './add-turtle-btn.html',
  styleUrl: './add-turtle-btn.css',
})
export class AddTurtleBtn {
  btnText = input<string>();
  addTurtleEvent = output<string>();

  addNewTurtleSoldier() {
    this.addTurtleEvent.emit('🐢');
  }
}
