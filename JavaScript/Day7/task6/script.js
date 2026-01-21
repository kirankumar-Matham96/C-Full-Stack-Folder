function printData() {
  let name = document.querySelector("#name").value;
  let email = document.querySelector("#email").value;
  let mobile = document.querySelector("#mobile").value;

  document.querySelector(
    "#nameVal"
  ).innerHTML = `<span style="font-weight: bold">Name:</span> ${name}`;
  document.querySelector(
    "#emailVal"
  ).innerHTML = `<span style="font-weight: bold">Email:</span> ${email}`;
  document.querySelector(
    "#mobileNo"
  ).innerHTML = `<span style="font-weight: bold">Mobile:</span> ${mobile}`;
}
