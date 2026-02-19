import { Injectable, signal } from '@angular/core';
import { sign } from 'node:crypto';

@Injectable({
  providedIn: 'root',
})
export class Signal2 {
  private pname = signal({ name: 'apple' });
  private price = signal({ price: 150 });
  private quantity = signal({ quantity: 263 });

  productName = this.pname;
  productPrice = this.price;
  productQuantity = this.quantity;

  updateName(newName: string) {
    this.pname.set({ ...this.pname, name: newName });
  }

  updatePrice(newPrice: number) {
    this.price.set({ ...this.price, price: newPrice });
  }

  updateQuantity(newQuantity: number) {
    this.quantity.set({ ...this.quantity, quantity: newQuantity });
  }
}
