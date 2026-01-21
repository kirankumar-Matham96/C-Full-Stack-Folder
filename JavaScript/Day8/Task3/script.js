function calculateMonthlyEmi() {
  let loanAmt = parseInt(dpcument.querySelector("#loan").value);
  let rateOfInterest = parseInt(dpcument.querySelector("#rate").value);
  let tenure = parseInt(dpcument.querySelector("#tenure").value);

  let interestAmt = loanAmt * rateOfInterest;
  let finalAmt = loanAmt + interestAmt * tenure;
  let monthlyEmi = finalAmt / 12;

  document.querySelector("#emi").value = monthlyEmi;
}
