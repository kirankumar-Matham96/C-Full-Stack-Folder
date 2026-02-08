import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CurrencyPipe } from '@angular/common';
@Component({
  selector: 'app-usd-to-inr',
  imports: [FormsModule, CurrencyPipe],
  templateUrl: './usd-to-inr.html',
  styleUrl: './usd-to-inr.css',
})
export class UsdToInr {
  inrValue: number = 90.58;
  usdValue: number = 1;
  USD_VALUE: number = 90.58;

  onUsdChange() {
    this.inrValue = parseFloat((this.USD_VALUE * this.usdValue).toFixed(2));
  }
}
