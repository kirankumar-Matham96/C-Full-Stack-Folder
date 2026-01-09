const btnEl = document.querySelector(".btn");
btnEl.addEventListener("click", () => {
  const num1El = document.querySelector("#num1");
  const num2El = document.querySelector("#num2");

  const num1 = parseInt(num1El.value);
  const num2 = parseInt(num2El.value);

  if (num1 > num2) {
    alert(`${num1} is the biggest number`);
  } else if (num1 == num2) {
    alert(`Both First and Second numbers are equal`);
  } else {
    alert(`${num2} is the biggest number`);
  }
});
