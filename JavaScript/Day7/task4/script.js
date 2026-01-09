const btnEl = document.getElementById("btn");

let message;

btnEl.addEventListener("click", () => {
  const age = parseInt(document.getElementById("age").value);
  switch (true) {
    case age >= 0 && age <= 12:
      message = "You are a child";
      break;
    case age >= 13 && age <= 19:
      message = "You are a teenager";
      break;
    case age >= 20 && age <= 59:
      message = "You are an adult";
      break;
    case age >= 60:
      message = "You are a senior citizen";
  }
  alert(message);
});
