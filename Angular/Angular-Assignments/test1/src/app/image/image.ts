import { Component, input } from '@angular/core';

interface ImageData{
  imageUrl: string;
  id: string;
}

@Component({
  selector: 'app-image',
  imports: [],
  templateUrl: './image.html',
  styleUrl: './image.css',
})

export class Image {
  image = input<ImageData | undefined>(undefined);
}
