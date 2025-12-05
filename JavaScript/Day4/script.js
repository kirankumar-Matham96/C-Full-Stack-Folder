// q1
let mathMarks = 60;
let scienceMarks = 72;
let socialMarks = 40;

console.log(`1A)\n Total Marks: ${mathMarks + scienceMarks + socialMarks}\n`);

// q2
let productName = "Rice";
let productPrice = 5200.0;
let productQuantity = 10;
let discount = 2000.0;

console.log(
  `2A)\n Total Bill: ₹ ${
    productPrice * productQuantity
  }/-\n Discount: ₹ ${discount}/-\n Net amount to pay: ₹ ${
    productPrice * productQuantity - discount
  }/-`
);

// q3
let totalFruits = 100;
let people = 8;
console.log(
  `3A)\n ${totalFruits} fruits are distributed to ${people} people equally. So, each person got ${parseInt(
    100 / 8
  )} fruits and ${100 - parseInt(100 / 8) * people} fruits are left.`
);

// q4
let anualSalary = 450000.0;
const MONTHS = 12;

console.log(
  `4A)\n Anual Salary of Mr.Rathan is: ₹ ${anualSalary}/-.\n Monthly Salary is: ₹ ${
    anualSalary / MONTHS
  }/-`
);

// q5
let monthlySalary = 62450.0;
console.log(
  `5A)\n Monthly Salary of Mr.KB is: ₹ ${monthlySalary}/-\n Anual salary is: ₹ ${
    monthlySalary * MONTHS
  }/-`
);

// q6
const totalWorkingDays = 145;
let attendedDays = 140;

console.log(
  `6A)\n Attendance percentage: ${parseInt(
    (attendedDays * 100) / totalWorkingDays
  )}`
);

// q7
let mangoBasketPurchasePrice = 1150.0;
let mangoBasketSoldPrice = 1680.0;
let profit = mangoBasketSoldPrice - mangoBasketPurchasePrice;

console.log(
  `q7)\n ${
    profit > 0
      ? "The profit is ₹" + profit + "/-"
      : "The loss is ₹" + profit + "/-"
  }`
);

// q8
let totalMatches = 222;
let totalRuns = 8765;
// what is batting average?
let battingAverage = "some calculation here";
console.log(`8A)\n The batting average of MS.Dhoni is: ${battingAverage}`);

// q9
let basicSalary = 10000;
let hra = (basicSalary * 30) / 100;
let da = (basicSalary * 20) / 100;
let totalSalary = basicSalary + hra + da;
console.log(`9A)\n Total Salary: ${totalSalary}`);

// q10
let preReading = 11236;
let postReading = 11494;
console.log(
  `10A)\n The total distance travelled by Mr.Ratan: ${postReading - preReading}`
);

// q11 (BMI formula: mass/(height*height))
let massRatan = 80;
let heightRatan = 5.7;
let massAnu = 65;
let heightAnu = 5.2;

let BMIRatan = (massRatan / (heightRatan * heightRatan)).toFixed(2);
let BMIAnu = (massAnu / (heightAnu * heightAnu)).toFixed(2);

let ratanHigherBMI = BMIRatan > BMIAnu;

console.log(
  `11A)\n BMI of Ratan: ${BMIRatan}\n BMI of Anu: ${BMIAnu}\n ${
    ratanHigherBMI
      ? "Ratan BMI is higher than Anu"
      : "Anu BMI is higher than Ratan"
  }`
);
