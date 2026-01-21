function calculateResults() {
  event.preventDefault();
  let maths = parseInt(document.querySelector("#maths").value);
  let science = parseInt(document.querySelector("#science").value);
  let social = parseInt(document.querySelector("#social").value);

  let totalMarks = maths + science + social;
  let averageMarks = totalMarks / 3;
  let percentage = (totalMarks / 300) * 100;
  let rank;

  if (maths >= 35 && science >= 35 && social >= 35 && percentage > 80)
    rank = "A";
  else if (maths >= 35 && science >= 35 && social >= 35 && percentage > 70)
    rank = "B";
  else if (maths >= 35 && science >= 35 && social >= 35 && percentage > 60)
    rank = "C";
  else if (maths >= 35 && science >= 35 && social >= 35 && percentage > 40)
    rank = "D";
  else rank = "F";

  document.querySelector("#total").value = totalMarks;
  document.querySelector("#avg").value = averageMarks;
  document.querySelector("#rank").value = rank;
}
