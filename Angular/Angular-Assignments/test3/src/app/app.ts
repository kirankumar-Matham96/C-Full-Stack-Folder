import { Component, signal } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-root',
  imports: [FormsModule, CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected readonly title = signal('test3');
  fileName = 'Lab Exercises - 3';
  isClicked = true;
  imageUrl = 'https://angular.io/assets/images/logos/angular/angular.svg';
  someText = '';

  reactUtilities = [
    'React Developer Tools',
    'Create React App',
    'React Router',
    'React Testing Library',
  ];
  angularUtilities = ['Angular CLI', 'Angular Material', 'NgRx', 'Angular Universal'];

  getImgClass() {
    return 'custom-img';
  }

  get bgColor(): string {
    if (this.someText.toLowerCase().includes('angular')) {
      return 'bg-danger';
    }
    if (this.someText.toLowerCase().includes('react')) {
      return 'bg-primary';
    }
    return '';
  }

  get showReact(): boolean {
    return this.someText.toLowerCase().includes('react');
  }

  get showAngular(): boolean {
    return this.someText.toLowerCase().includes('angular');
  }

  btnClick() {
    this.isClicked = !this.isClicked;
    this.isClicked
      ? (this.imageUrl = 'https://angular.io/assets/images/logos/angular/angular.svg')
      : (this.imageUrl =
          'https://imgs.search.brave.com/U8ZIEPq1VdbaZY3HGY1pZATN7Q9j7NPFrYjueuxUjh0/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly93cC5h/bmd1bGFyLmxvdmUv/d3AtY29udGVudC91/cGxvYWRzLzIwMjYv/MDEvT2tsYWRraS1i/bG9nLTE5MjAteC0x/MDgwLXB4LTQucG5n');
  }

  reactImage: string = '/atom.png';
  angularImage: string = 'https://angular.io/assets/images/logos/angular/angular.svg';
}
