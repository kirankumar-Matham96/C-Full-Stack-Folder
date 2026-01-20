// Task1: Login Form and show the result in the alert
function loginCheck(e) {
  let username = document.getElementById("username").value;
  let password = document.getElementById("password").value;

  if (username == "Kirankumar" && password == "Kiran123@") {
    alert(`Login Successful! welcome ${username}`);
  } else {
    alert(`Login Failed! Please check the credentials`);
  }
}

// Task2: Product Bill Caculation and show the results in the web page
function billCalculator(e) {
  let price = parseFloat(document.querySelector("#price").value);
  let quantity = parseFloat(document.querySelector("#qty").value);

  let totalBill = (price * quantity).toFixed(2);
  let discountPercent;

  if (totalBill < 1000) discountPercent = 10;
  else if (totalBill < 2000) discountPercent = 20;
  else discountPercent = 30;

  let discAmt = ((totalBill * discountPercent) / 100).toFixed(2);
  let netAmt = (totalBill - discAmt).toFixed(2);

  document.querySelector(
    "#total"
  ).innerHTML = `Your Total Bill Amount is: <span style='font-weight: bold; color: blue'>${totalBill}</span>`;
  document.querySelector("#discAmt").innerHTML =
    "Discount Amount is: " + discAmt;
  document.querySelector("#netAmt").innerHTML =
    "Toatl Net Amount is: " + netAmt;
}

// Task3: Add two numbers and show the result in text box
function calculateSum() {
  let num1 = parseInt(document.querySelector("#num1").value);
  let num2 = parseInt(document.querySelector("#num2").value);

  let sum = num1 + num2;

  document.querySelector("#result").value = sum;
}

// Task4: wish function with onclick and double click events
function wishMe() {
  document.getElementById("wishMessage").innerHTML =
    "Hello Kiran! Good Morning! Have a nice day...";
}
