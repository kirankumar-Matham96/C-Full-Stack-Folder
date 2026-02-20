import { Component } from '@angular/core';
import { ReactiveFormsModule, FormControl, FormGroup, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-home',
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {
  comments: string[] = [];

  commentsBox = new FormGroup({
    comment: new FormControl('', [Validators.required, Validators.minLength(2)]),
  });

  addComment() {
    if (!this.commentsBox.valid) return;
    this.comments.push(this.commentsBox.value.comment!);
    this.commentsBox.reset();
  }
}
