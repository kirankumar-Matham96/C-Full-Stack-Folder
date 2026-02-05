import { Component } from '@angular/core';
import { Image } from '../image/image';

@Component({
  selector: 'app-images',
  imports: [Image],
  templateUrl: './images.html',
  styleUrl: './images.css',
})
export class Images {
  // images = [
  //   {
  //     id: 'image_1',
  //     imageUrl:
  //       'https://imgs.search.brave.com/U5johOkAemm56D7ECZHwztdMspWYlQxBx8JndUUdyJA/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9zdGF0/aWMudmVjdGVlenku/Y29tL3N5c3RlbS9y/ZXNvdXJjZXMvdGh1/bWJuYWlscy8wNTcv/MjU2Lzc0Mi9zbWFs/bC9mcmVzaC1vcmdh/bmljLWJsYWNrLXRl/YS1sZWF2ZXMtcGls/ZS13aXRoLWdyZWVu/LWxlYXZlcy1vbi13/aGl0ZS1iYWNrZ3Jv/dW5kLXBob3RvLmpw/ZWc',
  //   },
  //   {
  //     id: 'image_1',
  //     imageUrl:
  //       'https://imgs.search.brave.com/l-dfOZWVbRxCkM_T9tjhz4Nju5g2mobSE4g07vvU5C0/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9zdGF0/aWMudmVjdGVlenku/Y29tL3N5c3RlbS9y/ZXNvdXJjZXMvdGh1/bWJuYWlscy8wNjUv/ODQxLzY2My9zbWFs/bC9mcmVzaC1ncmVl/bi10ZWEtbGVhdmVz/LXN0YW5kLW5lYXIt/aGVhcC1vZi1kcmll/ZC1sZWF2ZXMtb24t/d2hpdGUtYmFja2dy/b3VuZC1waG90by5q/cGc',
  //   },
  //   {
  //     id: 'image_1',
  //     imageUrl:
  //       'https://imgs.search.brave.com/AaDuXHVL-4XnXHjUgNPNVY2qP-rn62E7Yu6vb7ptePY/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9zdC5k/ZXBvc2l0cGhvdG9z/LmNvbS8xMDAwNTYx/LzEzNTYvaS80NTAv/ZGVwb3NpdHBob3Rv/c18xMzU2NzEyMC1z/dG9jay1waG90by10/ZWEtbGVhdmVzLmpw/Zw',
  //   },
  //   {
  //     id: 'image_1',
  //     imageUrl:
  //       'https://imgs.search.brave.com/tHVcis6hQVtojKNxf3UhtugU4K2w7xnAaWNmrYA0z7w/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9zdGF0/aWMudmVjdGVlenku/Y29tL3N5c3RlbS9y/ZXNvdXJjZXMvdGh1/bWJuYWlscy8wNjYv/MzA3LzYwOS9zbWFs/bC9ncmVlbi10ZWEt/bGVhdmVzLWFuZC1s/ZWF2ZXMtb24td2hp/dGUtYmFja2dyb3Vu/ZC1mcmVlLXBob3Rv/LmpwZWc',
  //   },
  //   {
  //     id: 'image_1',
  //     imageUrl:
  //       'https://imgs.search.brave.com/jhhiv0aOI6dwmhqR5Sy-sZTH6M08oP85sJ_9pi3HIno/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9zdGF0/aWMudmVjdGVlenku/Y29tL3N5c3RlbS9y/ZXNvdXJjZXMvdGh1/bWJuYWlscy8wNDgv/MTcyLzc1Mi9zbWFs/bC9ncmVlbi10ZWEt/bGVhdmVzLXdpdGgt/c3RlbXMtZnJlZS1w/aG90by5qcGc',
  //   },
  // ];

  images = [
    {imageUrl: "/assets/1.jpg", id: "image-1"},
    {imageUrl: "/assets/2.jpg", id: "image-2"},
    {imageUrl: "/assets/3.jpg", id: "image-3"},
    {imageUrl: "/assets/4.png", id: "image-4"},
    {imageUrl: "/assets/5.png", id: "image-5"},
    {imageUrl: "/assets/6.jpg", id: "image-6"},
    {imageUrl: "/assets/7.jpg", id: "image-7"},
    {imageUrl: "/assets/8.png", id: "image-8"},
    {imageUrl: "/assets/9.png", id: "image-9"},
    {imageUrl: "/assets/10.jpg", id: "image-10"},
    {imageUrl: "/assets/11.jpg", id: "image-11"},
    {imageUrl: "/assets/12.jpg", id: "image-12"},
    {imageUrl: "/assets/13.png", id: "image-13"},
    {imageUrl: "/assets/14.png", id: "image-14"},
    {imageUrl: "/assets/15.jpg", id: "image-15"},
    {imageUrl: "/assets/16.png", id: "image-16"},
  ];
}
