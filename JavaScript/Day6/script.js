// Task - 1
function getFullName(firstName, lastName) {
  return `${firstName} ${lastName}`;
}

const billCalculations = function (name, price, quantity) {
  return `\n Item: ${name}\n Quantity: ${quantity}\n Price: ₹ ${price}/-\n Bill: ₹ ${
    price * quantity
  }/-`;
};

const fullName = getFullName("Kiran", "Kumar");
const bill = billCalculations("Mobile", 20000.0, 5);

console.log(`Full Name: ${fullName}\n\nBill: ${bill}`);

// task - 2
const sayHello = (name, mobile) => {
  console.log(
    `\nHey ${name}! Welcome to SathyaTech! You will get updates to your mobile (+91 ${mobile}) shortly...\n`
  );
};

sayHello("Kiran", "1235648975");

// Task - 3
const totalAndAverage = (maths, sciense, social) => {
  return `\n Total Marks: ${maths + sciense + social}\n Average Marks: ${(
    (maths + sciense + social) /
    3
  ).toFixed(2)}`;
};

console.log(totalAndAverage(65, 89, 49));
console.log(totalAndAverage(90, 75, 60));
console.log(totalAndAverage(55, 50, 59));
console.log(totalAndAverage(80, 68, 95));

// Task - 4
const calculateOrderBill = (
  name,
  price,
  quantity,
  taxRate = 10,
  shippingFees = 50,
  platformFee = 5
) => {
  let subTotal = price * quantity;
  let taxAmount = (subTotal * 10) / 100;
  let totalCost = subTotal + taxAmount + shippingFees + platformFee;
  return totalCost;
};

console.log(`Total Bill: ₹ ${calculateOrderBill("Kirankumar", 5000, 3)}/-`);

// Task - 5
const calculateGroceryBill = (
  itemName,
  pricePerUnit,
  quantity,
  discount = 100,
  taxRate = 7,
  deliveryCharge = 30
) => {
  let subTotal = pricePerUnit * quantity;
  let taxAmount = (subTotal * 7) / 100;
  let costBeforeDiscount = subTotal + taxAmount + deliveryCharge;
  let costAfterDiscount = subTotal + taxAmount + deliveryCharge - discount;
  return { costBeforeDiscount, costAfterDiscount };
};

console.log(calculateGroceryBill("Mobile", 2000, 3));
