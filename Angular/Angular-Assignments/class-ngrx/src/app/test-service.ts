import { Injectable, signal } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class TestService {
  private pname = signal({ name: 'Lenovo Laptop' });

  product = this.pname;

  updatePName(newName: string) {
    this.pname.set({ ...this.pname(), name: newName });
  }
}
