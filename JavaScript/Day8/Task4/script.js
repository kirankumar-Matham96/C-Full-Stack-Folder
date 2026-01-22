function checkLocation() {
  let msg = document.querySelector("#message");
  let loc = document.querySelector("#loc").value;

  console.log("loc: ", loc.toLowerCase());

  switch (loc.toLowerCase()) {
    case "hyderabad":
    case "secunderabad":
      msg.innerHTML = `Welcome to ${loc.toUpperCase()}! Visit Charminar...`;
      break;
    case "vizag":
    case "vishakhapatnam":
      msg.innerHTML = `Welcome to ${loc.toUpperCase()}! Visit RK Beach...`;
      break;
    case "vijayawada":
    case "bezawada":
      msg.innerHTML = `Welcome to ${loc.toUpperCase()}! Visit Temple...`;
      break;
    default:
      msg.innerHTML = "No details on this location!";
  }
}
