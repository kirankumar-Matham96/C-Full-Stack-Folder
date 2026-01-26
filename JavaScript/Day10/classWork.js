const arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

// arr
//   .filter((num) => num % 2 == 0)
//   .map((num) => num * 2)
//   .forEach((num) => console.log(num));

const evenArray = arr.filter((a) => getEvenNums(a));

console.log(evenArray);

// const mulBy2 = evenArray.map((num) => num * 2);

// console.log({ mulBy2 });

function getEvenNums(num) {
  return num % 2 == 0 ? true : false;
}

// reading form data and store in array
function setData() {
  event.preventDefault();
  console.log("function called...");
  let userName = document.querySelector("#name").value;
  let email = document.querySelector("#email").value;
  let pwd = document.querySelector("#pwd").value;
  let mobile = document.querySelector("#mobile").value;

  // const data = [userName, email, pwd, mobile];

  // const data = [];
  // data.push(userName);
  // data.push(email);
  // data.push(pwd);
  // data.push(mobile);

  const data = {};
  data.userName = userName;
  data.email = email;
  data.pwd = pwd;
  data.mobile = mobile;

  // data.forEach((content) => console.log(content));

  const keys = Object.keys(data);

  console.log({ keys });

  keys.forEach((key) => console.log(data[key]));

  let result = document.getElementById("result");
  console.log(result);
  result.innerHTML = `<span>User Name: ${data.userName}</span>`;
}

// IIFE
// (function () {
//   console.log("Immediately Invoked Function Expression...");
// })();

// function declaration
function print() {
  console.log("Hello");
}

// function expression
// const printNums = function () {
//   arr.forEach((num) => console.log(num));
// };

// arrow function
const printNums2 = () => {
  arr.forEach((num) => console.log(num));
};

// print();
// printNums();
// printNums2();
