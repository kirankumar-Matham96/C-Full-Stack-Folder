const ageEl = document.getElementById("age");
const btnEl = document.getElementById("btn");

btnEl.addEventListener("click", () => {
  if (ageEl.value >= 18) {
    alert("You are eligible for voting");
  } else {
    alert("You are not aligible for voting");
  }
});
