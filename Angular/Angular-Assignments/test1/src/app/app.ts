import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Images } from './images/images';
import { FormsModule } from '@angular/forms';
import { Counter } from './counter/counter';
import { UsdToInr } from './usd-to-inr/usd-to-inr';
import { DateAndTime } from './date-and-time/date-and-time';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Images, FormsModule, Counter, UsdToInr, DateAndTime],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected readonly title = signal('test1');

  newImage: string = '';
  // https://hellokiran.co.in.com

  addImageToList() {
    console.log(`Button click event secured...`);
    console.log({ newImage: this.newImage });
    if (this.newImage === '' || this.newImage === null || this.newImage === undefined) {
      alert('Image url must be valid...');
      return;
    }

    this.images.unshift({ imageUrl: this.newImage, id: `image-${Date.now()}` });
  }

  images = [
    { imageUrl: '/assets/1.jpg', id: 'image-1' },
    // { imageUrl: '/assets/2.jpg', id: 'image-2' },
    // { imageUrl: '/assets/3.jpg', id: 'image-3' },
    // { imageUrl: '/assets/4.png', id: 'image-4' },
    // { imageUrl: '/assets/5.png', id: 'image-5' },
    // { imageUrl: '/assets/6.jpg', id: 'image-6' },
    // { imageUrl: '/assets/7.jpg', id: 'image-7' },
    // { imageUrl: '/assets/8.png', id: 'image-8' },
    // { imageUrl: '/assets/9.png', id: 'image-9' },
    // { imageUrl: '/assets/10.jpg', id: 'image-10' },
    // { imageUrl: '/assets/11.jpg', id: 'image-11' },
    // { imageUrl: '/assets/12.jpg', id: 'image-12' },
    // { imageUrl: '/assets/13.png', id: 'image-13' },
    // { imageUrl: '/assets/14.png', id: 'image-14' },
    // { imageUrl: '/assets/15.jpg', id: 'image-15' },
    // { imageUrl: '/assets/16.png', id: 'image-16' },
  ];
}
