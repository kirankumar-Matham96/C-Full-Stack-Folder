function showMessage() {
  let option = document.getElementById("day").value;
  let message;

  switch (option) {
    case "mon":
      message =
        "Kiran, Mondays are really good, cause nobody will be active...😉";
      break;
    case "tus":
      message = "Tuesdays are troublesome!";
      break;
    case "wed":
      message =
        "Wednessdays are awesome! We have lot more days to complete our work...";
      break;
    case "thu":
      message = "Thursdays are tight schedulers.. Be carefull";
      break;
    case "fri":
      message =
        "Fridays are dangerouse! You may get new work in the evening time. Leave early";
      break;
    case "sat":
      message = "Enjoy the Saturday";
      break;
    case "sun":
      message = "Sunday! Hmm... Relax for the day...😎";
      break;
    default:
      message = "Please select a value...";
  }

  document.getElementById("message").innerHTML = message;
}
