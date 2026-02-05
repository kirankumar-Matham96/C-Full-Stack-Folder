import { Component, input, effect } from '@angular/core';
import { Image, ImageData } from '../image/image';

@Component({
  selector: 'app-images',
  imports: [Image],
  templateUrl: './images.html',
  styleUrl: './images.css',
})
export class Images {
  images = input<ImageData[]>();

  constructor() {
    effect(() => console.log(`Image updated: `, this.images()));
  }
}
