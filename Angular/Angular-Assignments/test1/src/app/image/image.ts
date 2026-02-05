import { Component, input } from '@angular/core';
import { NgOptimizedImage } from '@angular/common';

// This interface should be a shared file. Neet to place is somewhere else.
export interface ImageData {
  imageUrl: string;
  id: string;
}

@Component({
  selector: 'app-image',
  imports: [NgOptimizedImage],
  templateUrl: './image.html',
  styleUrl: './image.css',
})
export class Image {
  image = input<ImageData | undefined>(undefined);
}
