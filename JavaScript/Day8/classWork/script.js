function calculate(id) {
  let num1 = parseInt(document.getElementById("num1").value);
  let num2 = parseInt(document.getElementById("num2").value);
  let res;

  switch (id) {
    case "add":
      res = num1 + num2;
      break;
    case "sub":
      res = num1 - num2;
      break;
    case "mul":
      res = num1 * num2;
      break;
    case "div":
      res = num2 != 0 ? (num1 / num2).toFixed(2) : 0;
      break;
    case "mod":
      res = num1 % num2;
      break;
  }

  document.getElementById("res").value = res;
}
