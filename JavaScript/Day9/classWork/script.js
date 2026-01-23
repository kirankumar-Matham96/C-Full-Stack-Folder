function validateForm() {
  /* READ INPUT VALUES */
  let id = document.getElementById("pid").value.trim();
  let name = document.getElementById("name").value.trim();
  let brand = document.getElementById("brand").value.trim();
  let qty = document.getElementById("qty").value.trim();
  let price = document.getElementById("price").value.trim();
  let mDate = document.getElementById("mDate").value;
  let eDate = document.getElementById("eDate").value;

  /* TYPE CONVERSIONS */
  let qtyNum = parseInt(qty, 10);
  let priceNum = parseFloat(price);
  let mDateObj = new Date(mDate);
  let eDateObj = new Date(eDate);

  /* ERROR SPAN TAGS */
  let idErr = document.getElementById("idErr");
  let nameErr = document.getElementById("nameErr");
  let brandErr = document.getElementById("bErr");
  let qtyErr = document.getElementById("qtyErr");
  let priceErr = document.getElementById("pErr");
  let mErr = document.getElementById("mErr");
  let eErr = document.getElementById("eErr");

  /* VALIDATION FLAG */
  let isValid = true;

  /* ID VALIDATION */
  if (id === "") {
    idErr.textContent = "ID must not be empty";
    isValid = false;
  } else if (isNaN(id)) {
    idErr.textContent = "ID must be a number";
    isValid = false;
  } else if (Number(id) <= 0) {
    idErr.textContent = "ID must be a positive number";
    isValid = false;
  } else {
    idErr.textContent = "";
  }

  /* NAME VALIDATION */
  if (name === "") {
    nameErr.textContent = "Product name must not be empty";
    isValid = false;
  } else if (name.length < 3 || name.length > 20) {
    nameErr.textContent = "Product name must be between 3 and 20 characters";
    isValid = false;
  } else {
    nameErr.textContent = "";
  }

  /* BRAND VALIDATION */
  if (brand === "") {
    brandErr.textContent = "Product brand must not be empty";
    isValid = false;
  } else if (brand.length < 5 || brand.length > 20) {
    brandErr.textContent = "Product brand must be between 5 and 20 characters";
    isValid = false;
  } else {
    brandErr.textContent = "";
  }

  /* QUANTITY VALIDATION */
  if (qty === "") {
    qtyErr.textContent = "Quantity must not be empty";
    isValid = false;
  } else if (isNaN(qtyNum)) {
    qtyErr.textContent = "Quantity must be a number";
    isValid = false;
  } else if (qtyNum <= 0) {
    qtyErr.textContent = "Quantity must be a positive number";
    isValid = false;
  } else {
    qtyErr.textContent = "";
  }

  /* PRICE VALIDATION */
  if (price === "") {
    priceErr.textContent = "Price must not be empty";
    isValid = false;
  } else if (isNaN(priceNum)) {
    priceErr.textContent = "Price must be a number";
    isValid = false;
  } else if (priceNum <= 0) {
    priceErr.textContent = "Price must be a positive value";
    isValid = false;
  } else {
    priceErr.textContent = "";
  }

  /* DATE VALIDATION */
  if (!mDate) {
    mErr.textContent = "Manufacturing date is required";
    isValid = false;
  } else if (!eDate) {
    mErr.textContent = "";
    eErr.textContent = "Expiry date is required";
    isValid = false;
  } else if (isNaN(mDateObj.getTime())) {
    mErr.textContent = "Invalid manufacturing date";
    isValid = false;
  } else if (isNaN(eDateObj.getTime())) {
    eErr.textContent = "Invalid expiry date";
    isValid = false;
  } else if (mDateObj > new Date()) {
    mErr.textContent = "Manufacturing date must be less than the current date";
    isValid = false;
  } else if (mDateObj >= eDateObj) {
    mErr.textContent = "Manufacturing date must be before expiry date";
    isValid = false;
  } else {
    mErr.textContent = "";
    eErr.textContent = "";
  }

  return isValid;
}
