function billCalculator() {
  let productName = document.querySelector("#name");
  let price = document.querySelector("#price").value;
  let quantity = document.querySelector("#qty").value;

  let totalBill = price * quantity;

  let discount;

  if (totalBill < 1000) discount = 10;
  else if (totalBill < 2000) discount = 20;
  else discount = 30;

  let discountAmt = (totalBill * discount) / 100;

  let netAmt = totalBill - discountAmt;

  alert(
    `Product: ${productName}\nPrice: ${price}\nQuantity: ${quantity}\nTotalBill: ${totalBill}\nDiscount: ${discount}\nNet Amount: ${netAmt}`
  );
}
