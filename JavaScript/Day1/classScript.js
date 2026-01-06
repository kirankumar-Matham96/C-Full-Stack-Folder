console.log("Hello world!");

id = 3313;
name = "Kirankumar";
gender = "M";
salary = 69000.25;
mobile = 784589623564n;
isWorking = true;

console.log("\n");

console.log(id);
console.log(name);
console.log(gender);
console.log(salary);
console.log(mobile);
console.log(isWorking);

console.log("\n");

console.log("id: ", id);
console.log("name: ", name);
console.log("gender: ", gender);
console.log("salary: ", salary);
console.log("mobile: ", mobile);
console.log("isWorking: ", isWorking);

console.log("\n");

console.log("id type is: ", typeof id);
console.log("name type is: ", typeof name);
console.log("gender type is: ", typeof gender);
console.log("salary type is: ", typeof salary);
console.log("mobile type is: ", typeof mobile);
console.log("isWorking type is: ", typeof isWorking);

console.log("\nPrinting all the data with String interpolation: \n");
console.log(
  `Id: ${id}\nName: ${name}\nGender: ${gender}\nSalary: ${salary}\nMobile: ${mobile}Is Working: ${isWorking}`
);

console.log("\n");

// Product data

productId = 1001;
productName = "Mobile";
productPrice = 3999.99;
productStock = 50;
isTopProduct = true;
warrantyInYears = 3;

console.log(
  `\nProduct Details: \n\nProduct Id: ${productId}\nName: ${productName}\nPrice: ${productPrice}\nStock: ${productStock}\nIs this top product: ${isTopProduct}\nWaranty: ${warrantyInYears} years`
);

// Hospital Data

hospitalName = "Prime Hospital";
address =
  "Flat No: 5-86/C/A-96, Road No: 6, SR Nagar, Hyderabad, 500082, Telangana, India.";
contact = 785496586n;
CheafSurgeon = "Dr. Ramanand";

console.log(
  `\nHospital Details: \n\nHospital Name: ${hospitalName}\nAddress: ${address}\nContact No: ${contact}\nCheaf Surger: ${CheafSurgeon}`
);
