// Task-1
const printFizzBuzzAndNums = () => {
  console.log("\n******* Task-1 *******\n");
  for (let i = 1; i <= 10; i++) {
    if (i % 3 == 0) console.log("Fizz");
    else if (i % 5 == 0) console.log("Buzz");
    else console.log(i);
  }
};

// Task-2
const sumOfNums1 = () => {
  console.log("\n******* Task-2 *******\n");
  console.log("sum of numbers from 1 to 10");
  let sum1 = 0;
  let sum2 = 0;
  let sum3 = 0;

  for (let i = 1; i <= 10; i++) {
    sum1 += i;
  }
  console.log(`Sum of all numbers: ${sum1}`);

  for (let i = 1; i <= 10; i++) {
    sum2 += i % 2 == 0 ? i : 0;
  }
  console.log(`sum of even numbers from 1 to 10: ${sum2}`);

  for (let i = 1; i <= 10; i++) {
    sum3 += i % 2 != 0 ? i : 0;
  }
  console.log(`sum of odd numbers from 1 to 10: ${sum3}`);
};

const sumOfNums2 = () => {
  let sum1 = 0,
    sum2 = 0,
    sum3 = 0;

  for (let i = 1; i <= 10; i++) {
    sum1 += i;
    sum2 += i % 2 == 0 ? i : 0;
    sum3 += i % 2 != 0 ? i : 0;
  }
  console.log(`sum of all numbers from 1 to 10: ${sum1}`);
  console.log(`sum of even numbers from 1 to 10: ${sum2}`);
  console.log(`sum of odd numbers from 1 to 10: ${sum3}`);
};

// Task-3
const sumOfDigits = () => {
  console.log("\n******* Task-3 *******\n");
  let num = parseInt(prompt("Enter any number: "));
  let sum = 0,
    temp = num;

  while (num > 0) {
    sum += num % 10;
    num /= 10;
  }
  alert(`Sum of digits of ${temp} is: ${sum}`);
  console.log(`Sum of digits of ${temp} is: ${sum}`);
};
// sumOfDigits();

const reverseNum = () => {
  let num = parseInt(prompt("Enter any number: "));
  let rev = 0,
    rem,
    temp = num;

  while (num > 0) {
    rem = num % 10;
    num = parseInt(num / 10);
    rev = rev * 10 + rem;
  }
  alert(`Reverese number of ${temp} is ${rev}`);
  console.log(`Reverese number of ${temp} is ${rev}`);
};

// reverseNum();

// Task-4
const takeNamesAndPrint = () => {
  console.log("\n******* Task-4 *******\n");
  let length = parseInt(prompt("Enter the size of the array of names: "));
  const names = [];

  for (let i = 0; i < length; i++) {
    let name = prompt(`Enter name ${i + 1}: `);
    names.push(name);
  }
  names.forEach((name) => console.log(name));
};
// takeNamesAndPrint();

// Task-5
const takePositiveNumber = () => {
  console.log("\n******* Task-5 *******\n");

  let num;
  do {
    num = parseInt(prompt("Enter a number: "));
  } while (num <= 0);

  console.log("You are a positive minded person!");
};
// takePositiveNumber();

// Task-6
const guessTheNumber = () => {
  console.log("\n******* Task-6 *******\n");
  let num = Math.floor(Math.random() * 100);
  do {
    let input = parseInt(prompt("Guess the number: "));
    if (input == num) {
      alert("Congratulations! You have guessed the correct number.");
      return;
    } else if (input < num)
      alert("Your number is less than the number! Guess again...");
    else if (input > num)
      alert("Your number is higher than the number! Guess again...");
  } while (true);
};

// guessTheNumber();
