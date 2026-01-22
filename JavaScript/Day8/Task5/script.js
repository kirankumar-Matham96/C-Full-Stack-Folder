function greet(id) {
  let message;
  switch (id) {
    case "morning":
      message = "Good Morning Everyone!";
      break;
    case "noon":
      message = "Good Afternoon Everyone!";
      break;
    case "night":
      message = "Good Night Everyone!";
      break;
    default:
      message = "Hello Everyone!";
  }
  document.querySelector("#message").innerHTML =
    `<span style='color: cyan'>${message}</span>`;
}
