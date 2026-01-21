function convertUSDToINR() {
  const EXCHANGE_RATE = 83;

  let usd = parseFloat(document.querySelector("#usd").value);
  let inr = (usd * EXCHANGE_RATE).toFixed(2);

  document.querySelector("#inr").value = inr;
}
