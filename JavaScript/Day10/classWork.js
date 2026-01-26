// Type Coersion: implicit type conversion
console.log("\n+ operator: \n");
console.log(10 + 10);
console.log(10 + "10");
console.log("10" + 10);
console.log("10" + "10");

console.log("\n- operator: \n");
console.log(20 - 10);
console.log(20 - "10");
console.log("20" - 10);
console.log("20" - "10");

console.log("\n* operator: \n");
console.log(20 * 10);
console.log(20 * "10");
console.log("20" * 10);
console.log("20" * "10");

console.log("\n/ operator: \n");
console.log(20 / 10);
console.log(20 / "10");
console.log("20" / 10);
console.log("20" / "10");

console.log("\n% operator: \n");
console.log(20 % 10);
console.log(20 % "10");
console.log("20" % 10);
console.log("20" % "10");

console.log(10 == 10);
console.log(10 == "10");
console.log("10" == 10);
console.log("10" == "10");

console.log(10 === 10);
console.log(10 === "10");
console.log("10" === 10);
console.log("10" === "10");

const arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

arr
  .filter((num) => num % 2 == 0)
  .map((num) => num * 2)
  .forEach((num) => console.log(num));

// IIFE
(function () {
  console.log("Immediately Invoked Function Expression...");
})();

// function definition
function print() {
  console.log("Hello");
}

// function expression
const printNums = function () {
  arr.forEach((num) => console.log(num));
};

// arrow function
const printNums2 = () => {
  arr.forEach((num) => console.log(num));
};

print();
printNums();
printNums2();
