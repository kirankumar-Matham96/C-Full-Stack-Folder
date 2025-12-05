// task - 1
let employeeName = "Ratan";
let basicSalary = 50000;
let allowances = 10000;

console.log("Task-1\n");
console.log(
  "Hello " +
    employeeName +
    ", your base salary is ₹" +
    basicSalary +
    ", allowances are ₹" +
    allowances +
    ", so your total salary is ₹" +
    (basicSalary + allowances)
);
console.log(
  `Hello ${employeeName}, your base salary is ₹${basicSalary}, allowances are ₹${allowances}, so your total salary is ₹${
    basicSalary + allowances
  }`
);

// task - 2
let customerName = "John";
let product = "Laptop";
let quantity = 2;
let pricePerItem = 40000;

console.log("\nTask-2\n");
console.log(
  `Thank you, ${customerName}! You ordered ${quantity} ${product}(s). Your total bill is ₹${
    quantity * pricePerItem
  }`
);

// Task - 3
let passengerName = "Ratan";
let flightNumber = "A1202";
let departure = "New York";
let destination = "Los Angeles";
let date = "25th Jan 2025";

console.log("\nTask-2\n");
console.log(
  `Dear ${passengerName}, your flight ${flightNumber} from ${departure} to ${destination} is confirmed for ${date}. Safe travels!`
);

// Task - 4
let memberName = "Sophia";
let membershipEndDate = "1st Feb 2025";

console.log("\nTask-2\n");
console.log(
  `Dear ${memberName}, your gym membership expires on ${membershipEndDate}. Please renew soon to continue your workouts.`
);
