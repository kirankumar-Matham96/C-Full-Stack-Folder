const btnEl = document.querySelector(".btn");
btnEl.addEventListener("click", () => {
  const num = parseInt(document.querySelector("#num").value);

  if (num % 2 == 0) {
    alert(`The number ${num} is EVEN`);
  } else {
    alert(`The number ${num} is ODD`);
  }
});
