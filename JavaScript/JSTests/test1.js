/**
 * 1. Display the complete person details
 * 2. Print the individual person details (name, age, student status)
 * 3. Display all hobbies of the person
 * 4. Print the address details (city, state, pincode)
 * 5. Update the city to "Hyderabad"
 * 6. Add a new hobby "Teaching" to the hobbies list.
 * 7. Display the updated city, hobbies, and personal details
 */

function solveProblem1() {
  const person = {
    isStudent: false,
    hobbies: ["Reading", "Traveling", "Eating"],
    address: {
      city: "Ameerpet",
      state: "TS",
      pincode: 500018,
    },
  };

  console.log(person);

  person.name = "Ratan";
  person.age = 30;
  person.studentStatus = "false";

  console.log(person.name);
  console.log(person.age);
  console.log(person.studentStatus);

  console.log(person.hobbies);

  console.log(person.address);

  person.address.city = "Hyderabad";
  person.hobbies.push("Teaching");

  console.log(person);
}

/**
 * Filtering the users data
 *
 * Consider you have an array of users details like name, age, and gender.
 * 1. Filter all users who are female
 * 2. Filter all users wh are male
 * 3. Filter all users who are over 18 years old
 */
function solveProblem2() {
  const users = [
    { name: "Eashwar", age: 36, gender: "male" },
    { name: "Raju", age: 17, gender: "male" },
    { name: "Rani", age: 16, gender: "female" },
    { name: "Jansi", age: 28, gender: "female" },
    { name: "Ganesh", age: 33, gender: "male" },
  ];

  // const femaleUsers = JSON.stringify(users.filter((user) => user.gender === "female"));
  // const maleUsers = JSON.stringify(users.filter((user) => user.gender === "male"));
  // const adults = JSON.stringify(users.filter((user) => user.age > 18));

  console.log(`Female Users: ${femaleUsers}`);
  console.log(`Male Users: ${maleUsers}`);
  console.log(`Adults: ${adults}`);
}

/**
 * Cart operations
 *
 * 1. Calculate cart total amount
 * 2. Calculate catr total weight
 * 3. Apply ₹50 delivery charge if total amount < 500
 * 4. Apply free delivery if totalamount >= 500
 * 5. Apply 10% festival discount only on Veg items
 * 6. Calculate final payable amount
 * 7. Calculate total savings (discount amount)
 */
function solveProblem3() {
  const products = [
    { name: "Paneer", price: 120, quantity: 2, weight: 250, category: "Veg" },
    { name: "Chicken", price: 200, quantity: 1, weight: 500, category: "Non-Veg" },
    { name: "Fish", price: 180, quantity: 2, weight: 400, category: "Non-Veg" },
    { name: "Mushroom", price: 90, quantity: 3, weight: 200, category: "Veg" },
    { name: "Egg", price: 60, quantity: 6, weight: 60, category: "Non-Veg" },
    { name: "Tofu", price: 100, quantity: 4, weight: 250, category: "Veg" },
  ];

  let totalAmt = products.reduce((total, item) => total + item.price * item.quantity, 0);

  let totalWeight = products.reduce((totalWeight, item) => totalWeight + item.weight * item.quantity, 0);

  let deliveryCharge = totalAmt < 500 ? 50 : 0;

  let discount = 10;
  let totalDiscountAmt = 0;

  products.forEach((item) => {
    if (item.category === "Veg") {
      item.price = item.price - (item.price * discount) / 100;
      totalDiscountAmt += item.price * discount;
    }
  });

  let totalAmtAfterFestivalDiscount = products.reduce((total, item) => total + item.price * item.quantity, 0);

  console.log(`Cart Total Amount: ${totalAmt}`);
  console.log(`Cart Total Weight: ${totalWeight}`);
  console.log(`Delivery Charges: ${deliveryCharge === 0 ? "Free Delivery" : deliveryCharge}`);
  console.log(`Discount on Veg(10%): ${totalDiscountAmt}`);
  console.log(`Final Payable Amount: ${totalAmtAfterFestivalDiscount}`);
  console.log(`Total Savings: ${totalDiscountAmt}`);
}

// solveProblem1();
// solveProblem2();
solveProblem3();
