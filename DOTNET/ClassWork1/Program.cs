namespace ClassWork
{
    class ClassWork
    {
        // 1. Consider first name as "sathya" and last name as "Technology" now print fullname
        public static void StringConcatenation()
        {
            string firstname = "Sathya", lastname = "Technology";
            Console.WriteLine($"{firstname} {lastname}");
        }

        // 2. Consider a value as 5 and b value as 7 now add a,b store into c, then display c 
        public static void Sum1()
        {
            int a = 5, b = 7, c;
            c = a + b;
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        // 3. Write a program take a=5.6, b=10.5 and display sum.
        public static void Sum2()
        {
            double a = 5.6, b = 10.5;
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        // 4. Write a program to consider a=20, b=2.5 and perform subtraction.
        public static void Subtraction()
        {
            int a = 20;
            double b = 2.5;
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        // 5. Consider Mr.Vishnu Annual Salary is 650000, Now calculate his Monthly Salary 
        public static void CalculateMonthlySalary()
        {
            double annualSalary = 650000;
            double monthlySalary = annualSalary / 12;
            Console.WriteLine($"Monthly Salary of Mr.Vishnu is: {monthlySalary}");
        }

        // 6. Consider Mr.Avinash Monthly salary is 34500.0, Now calculate his annual Salary
        public static void CalculateAnnualSalary()
        {
            double monthlySalary = 34500.0;
            double annualSalary = monthlySalary * 12;
            Console.WriteLine($"Annual Salary of Mr.Avinash is: {annualSalary}");
        }

        /* 7. Ms Laxmi Opend swiggy observed that Pizza cost is 345.60, She Ordered 3 pizzas.
              W.a.p to calculate her bill amount. Swiggy added 20rs as service charge and 30rs as tip.
              So find total Bill Amount
        */
        public static void CalculatePizzaBill()
        {
            double pizzaCost = 345.60;
            double quantity = 3;
            double serviceCharge = 20.0;
            double tip = 30.0;
            double totalBill = (pizzaCost * quantity) + serviceCharge + tip;
            Console.WriteLine($"Customer Name: Ms. Laxmi\nItem: Pizza\nQuantity:{quantity}\nService Charge: {serviceCharge}\nTim: {tip}\nTotal Bill: {totalBill}");
        }

        // 8. Consider 3 subject marks as 92, 98, 99. now calculate total and avg marks 
        public static void CalculateTotalAndAvgMarks()
        {
            int sub1 = 92, sub2 = 98, sub3 = 99, total;
            total = sub1 + sub2 + sub3;
            Console.WriteLine($"Total Marks: {total}\nAverage Marks: {total / 3}");
        }

        // 9. Consider Celsius temperature is 32 degree now Convert to Fahrenheit. 
        public static void CelsiusToFahrenheit()
        {
            int tempInC = 32;
            int tempInF = (tempInC * 9 / 5) + 32;
            Console.WriteLine($"Temperature in Fahrenheit: {tempInF}℉");
        }

        // 10. Consider Fahrenheit temperature is 102 degree now convert to Celsius. 
        public static void FahrenheitToCelsius()
        {
            int tempInF = 102;
            int tempInC = (tempInF - 32) * 5 / 9;
            Console.WriteLine($"Temperature in Celsius: {tempInF}℃");
        }

        /*
            11. Mr.Venkat deposited 500000 amount in bank for 5 years with rate of interest as 7.8%.
                After 5 years how much amount he will receive
            Note: Calculate interest amount and final amount,use simple interest formula
        */
        public static void SimpleInterest1()
        {
            double depositAmt = 500000.0;
            int duration = 5;
            double ROI = 7.8;
            double interestAmt = depositAmt * duration * ROI / 100;
            double totalAmt = depositAmt + interestAmt;
            System.Console.WriteLine($"Mr.Venkat will receive total amount of ₹ {totalAmt} after 5 years.");
        }

        // 12. W.a.p to perform swapping of 2 numbers by using 3rd variable
        public static void SwapTwoNumbers1()
        {
            int a = 5, b = 7, temp;
            Console.WriteLine($"Before swap => a: {a}, b: {b}");
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After swap  => a: {a}, b: {b}");
        }

        // 13. W.a.p to perform swapping of 2 numbers without using 3rd variable
        public static void SwapTwoNumbers2()
        {
            int a = 5, b = 7;
            Console.WriteLine($"Before swap => a: {a}, b: {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"After swap  => a: {a}, b: {b}");
        }

        // 14. W.a.p to perform swapping of 2 numbers without using 3rd variable and without using +, operator
        public static void SwapTwoNumbers3()
        {
            int a = 5, b = 7;
            Console.WriteLine($"Before swap => a: {a}, b: {b}");
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine($"After swap  => a: {a}, b: {b}");
        }

        /* 15. Miss Pooja Mansi started her journey from hyderabad to Vijayawada by car.
               While starting her journey she noticed that car Reading as 11236,
               after Reached Vijayawada again she noticed that her car Reading shows as 11494.
               Now w.a.p to find number of kilometers she travelled
        */
        public static void CalculateDistance()
        {
            int initialReading = 11236;
            int finalReading = 11494;
            Console.WriteLine($"Total distance travelled by Miss Pooja: {finalReading - initialReading}");
        }

        /* 16. Mr Venkat Reddy and his Frineds(Vishnu,Avinash) went to Restaurant and placed order as 3 plates manchuriya and 2 plates Biryani.
               We gave tip as 20rs. Now they decided to share amount equally.
               W.a.p to display there sharing amount
            
            Note: Manchuriya cost is 220/plate, Biryani cost is 360/plate
        */
        public static void CalculateBillPerPerson()
        {
            double manchuriaCost = 220, biryaniCost = 360;
            int manchuriaQnty = 3, biryaniQuty = 2;
            double tip = 20.0;
            double totalBillAmt = manchuriaCost * manchuriaQnty + biryaniCost * biryaniQuty + tip;
            Console.WriteLine($"Mr Venkat, Vishnu, and Avinash each has to pay: ₹ {totalBillAmt / 3}");
        }

        // 17. Ms.Laxmi actual March Milk bill is 930.0, but on that month Milk boy kept 4 leaves, So W.a.p to calculate her march month milk bill
        public static void CalculateMilkBill()
        {
            double actualBill = 930.0;
            int leaves = 4;
            int daysInMarch = 31;
            double billPerDay = actualBill / daysInMarch;
            double finalBill = (daysInMarch - leaves) * billPerDay;
            Console.WriteLine($"Final Milk Bill for the March month is: {finalBill}");
        }

        // 18. Miss Pooja Mansi attended 94 days out of 126 days. Now w.a.p to find attendance percentage
        public static void CalculateAttendancePercentage()
        {
            int totalWorkingDays = 126;
            int attendedDays = 94;
            int attendancePercentage = (attendedDays / totalWorkingDays) * 100;
            Console.WriteLine($"Attendance pecentage of Miss Pooja is: {attendancePercentage}%");
        }

        // 19. In an Apartment they need 6 water tins per day. W.a.p to calculate August month bill. Each Water tin cost is Rs 20.
        public static void CalculateWaterTinsBill()
        {
            double waterTinCost = 20.0;
            int tinsPerDay = 6;
            int daysInAgust = 31;
            double totalBill = tinsPerDay * daysInAgust * waterTinCost;
            Console.WriteLine($"Total bill for water tins in August: {totalBill}");
        }

        // 20. One Liter Petrol cost is 108.96, Now how many liters of petrol comes for 300rs 
        public static void CalculatePetrolQuantity()
        {
            double pertolCostPerLtr = 108.96;
            Console.WriteLine($"For ₹300, we can get {300 / pertolCostPerLtr} LTRs of petrol");
        }

        // 21. Mr.Sharma bought mango basket for 1150, then he sold for 1680, calculate his profit.
        public static void CalculateProfit()
        {
            double boughtPrice = 1150;
            double soldPrice = 1680;
            Console.WriteLine($"Mr.Sharma got ₹{soldPrice - boughtPrice} profit");
        }

        // 22. Consider Product cost is 200, gst is 20%. now find gst amount and final cost of product
        public static void CalculateProductPrice()
        {
            double productCost = 200;
            int gst = 20;
            double gstAmt = productCost * 20 / 100;
            Console.WriteLine($"The product cost: {productCost}\nGST: {gst}\nFinal Price of the product: {productCost + gst}");
        }

        /* 23. Consider Pizza cost is 326.50, customer order for 3 pizzas, now calculate bill amount.
               Shop provides 20% discount on bill amount. So find discount amount and final Bill
        */
        public static void CalculatePizzaPriceAndDiscount()
        {
            double pizzaCost = 326.50;
            int quantity = 3;
            int discount = 20;
            double totalPrice = pizzaCost * quantity;
            double discountAmount = totalPrice * discount / 100;
            double finalBill = totalPrice - discountAmount;
            Console.WriteLine($"Pizza price: {pizzaCost}\nQuantity: {quantity}\nDiscount price: {discount}\nFinal price: {finalBill}");
        }

        // 24. Consider Employee Monthly Salary is 30000, Company reduced 12% as pf and 8% as tax. Then find final monthly salary
        public static void CalculateMonthlySalary2()
        {
            double monthlySal = 30000.0;
            int pf = 12;
            int tax = 8;
            double pfAmt = monthlySal * pf / 100;
            double taxAmt = monthlySal * tax / 100;
            double finalSal = monthlySal - pfAmt - taxAmt;
            Console.WriteLine($"Final Monthly Salary of the employee: {finalSal}");
        }

        // 25. Mr.Venkat Took 500000 loan from bank for 4 years with rate or interest as 11.4%, Now calculate interest amount, final amount and EMI
        public static void CalculateEMI()
        {
            double loanAmt = 500000;
            int duration = 4;
            double ROI = 11.4;
            double interest = loanAmt * duration * ROI / 100;
            double finalAmt = loanAmt + interest * 4;
            double emi = finalAmt / (4 * 12);
            Console.WriteLine($"Total Interest: {interest}\nFinalAmount: {finalAmt}\nEMI: {emi}");
        }

        /* 26. W.a.p to find Electricity Bill. Last month Reading is 2234, Current month Reading is 2456.
               Now find no of units consumed, then calculate bill amount.
               Per unit 3.46, tax as 0.06 Per unit, and Service Charge is Rs 30
        */
        public static void CalculateElectricityBill()
        {
            int lastMonthReading = 2234;
            int currentMonthReading = 2456;
            int noOfUnitsConsumed = currentMonthReading - lastMonthReading;
            double costPerUnit = 3.46;
            double taxPerUnit = 0.06;
            double serviceCharge = 30;
            double totalCost = noOfUnitsConsumed * costPerUnit;
            double totalTax = noOfUnitsConsumed * taxPerUnit;
            double FinalBill = totalCost + totalTax + serviceCharge;
            Console.WriteLine($"Number of units consumed: {noOfUnitsConsumed}\nFinal Electricity Bill: {FinalBill}");
        }

        /* 27. Miss Pooja Mansi Rent a car to go to vijayawada, then started her journey from hyderabad to Vijayawada by car.
               While starting her journey she noticed that car Reading as 11236.
               After Reached Vijayawada again she noticed that her car Reading shows as 11494.
               Now w.a.p to find number of kilometers she travelled, And find her Bill Amount.
        
            Note: per km they charged Rs : 15 and For Total tollgate charge as Rs 200 
        */
        public static void CalculateTravellingCharges()
        {
            int initialReading = 11236;
            int finalReading = 11494;
            int distanceTravelled = finalReading - initialReading;
            double chargePerKm = 15;
            double tollgateCharge = 200;
            double totalBill = distanceTravelled * chargePerKm + tollgateCharge;
            Console.WriteLine($"Total distance travelled: {distanceTravelled}\nTotal Bill for the travel: {totalBill}");
        }

        // 28. W.a.p to read Emp id, Emp Name, Gender and Salary then display all details with annual salary
        public static void TakeIPAndPrint()
        {
            Console.Write("Enter employee id: ");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter employee name: ");
            string empName = Console.ReadLine() ?? "";
            Console.Write("Enter Employee gender: ");
            string gender = Console.ReadLine() ?? "";
            System.Console.Write("Enter the emploee salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Employee ID: {empId}\nName: {empName}\nGender: {gender}\nSalary: {salary}");
        }

        // 29. Consider Biryani cost is 395.25, Read quantity from user then find Total Bill Amount
        public static void CalculateBiryaniBill()
        {
            double biryaniCost = 395.25;
            Console.Write($"Biryani price: {biryaniCost}\nEnter the quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total Bill amount: {biryaniCost * quantity}");
        }

        // 30. Read amount from user then display in dollars
        public static void INRToUSD()
        {
            Console.Write("Enter the amount in INR: ");
            double INR = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double USD = 90.19;
            Console.WriteLine($"USD: {INR / USD}");
        }

        // 31. Read dollars from user then display in rupees
        public static void USDToINR()
        {
            Console.Write("Enter the amountin USD: ");
            double USDAmt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double USD = 90.19;
            Console.WriteLine($"INR: {USDAmt * USD}");
        }

        /* 32. From Hyderabad to Vijayawada General ticket cost is rs 460, Due to Festival session the ticket cost increased as 50% (actualcost+50%hike),
            now read no.of tickets and find Total Bill Amount.
        */
        public static void CalculateNewTicketCost()
        {
            double generalTicktCost = 460.0;
            int increaseInCost = 50;
            double increasedCost = generalTicktCost * increaseInCost / 100;
            double newTicketCost = generalTicktCost + increasedCost;

            Console.Write("Enter the number of tickets: ");
            int numberOfTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            double totalCost = numberOfTickets * newTicketCost;
            Console.WriteLine($"For the {numberOfTickets} tickets, total cost is: {totalCost}");
        }

        // 33. Read Employee annual salary and hike percentage, then calculate annual salary after hike. And display new monthly salary
        public static void CalculateSalaryAfterHike()
        {
            Console.Write("Enter the annual salary: ");
            double annualSalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the hike percentage: ");
            int hikePercentage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            double hikeAmt = annualSalary * hikePercentage / 100;
            double newAnnualSalary = annualSalary + hikeAmt;
            double monthlySalary = newAnnualSalary / 12;

            Console.WriteLine($"New Hike                  : {hikePercentage}%");
            Console.WriteLine($"New annual salary will be : {newAnnualSalary}");
            Console.WriteLine($"Monthly salary will be    : {monthlySalary}");
        }
        /*
            34. Read Market value of a land, In general stamp duty is 5%, But due to new rules it changes as 7%.
            So how much Extra amount they have to pay according to new rules.
            Calculate old stamp duty amount and new stamp duty amount then display difference
        */
        public static void CalculateStampDutyCost()
        {
            Console.Write("Enter the market value of the land: ");
            double landCost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            int generalStampDutyPercentage = 5;
            int currentStampDutyPercentage = 7;

            double generalStampDutyAmt = landCost * generalStampDutyPercentage / 100;
            double currentStampDutyAmt = landCost * currentStampDutyPercentage / 100;
            double extraAmount = currentStampDutyAmt - generalStampDutyAmt;

            Console.WriteLine($"The general stamp duty amount                     : {generalStampDutyAmt}");
            Console.WriteLine($"The new stamp duty amount                         : {currentStampDutyAmt}");
            Console.WriteLine($"Theadditional amount to be paid for the stamp duty: {extraAmount}");
        }

        // 35. Read Temperature in celsius then convert to fahrenheit
        public static void TempConverter1()
        {
            Console.Write($"Enter the temperature in celsius: ");
            int tempInC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int tempInF = (tempInC * 9 / 5) + 32;
            Console.WriteLine($"Temperature in Celsius   : {tempInC}℃");
            Console.WriteLine($"Temperature in Fahrenheit: {tempInF}℉");
        }

        // 36. Read Temperature in fahrenheit then convert to celsius
        public static void TempConverter2()
        {
            Console.Write($"Enter the temperature in fahrenheit: ");
            int tempInF = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int tempInC = (tempInF - 32) * 5 / 9;
            Console.WriteLine($"Temperature in Fahrenheit: {tempInF}℉");
            Console.WriteLine($"Temperature in Celsius   : {tempInC}℃");
        }

        // 37. Read Mongo cost per kg, then read quantity. Big Basket gives offer as 22% discount on Bill Amount. So find Total Bill Amount
        public static void CalculateMangoBill()
        {
            Console.Write("Enter the mango cost per KG: ");
            double costPerKg = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter the quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            double totalPrice = costPerKg * qty;
            int discountPercentage = 22;
            double discountAmt = totalPrice * discountPercentage / 100;
            double finalPice = totalPrice - discountAmt;
            Console.WriteLine($"Mangos cost per kg: ₹{costPerKg}");
            Console.WriteLine($"Quantity          : ₹{qty}");
            Console.WriteLine($"Total Cost        : ₹{totalPrice}");
            Console.WriteLine($"Discount amount   : ₹{discountAmt}");
            Console.WriteLine($"Final Cost        : ₹{finalPice}");
        }

        /* 38. Mr Venkat Reddy Booked flight Ticket in Indian Airlines To Travel Hyderabad to Vijayawad.
               General ticket cost is 3450 and extra gst as 18%.
               But if he booked ticket in IndiGo ticket cost is 3200 and extra gst as 12%.
               So how much amount he saved if he booked ticket in IndiGo.
        */
        public static void CompareFlightTickets()
        {
            double indianAirwaysGeneralTicketCost = 3450;
            int indiaAirwaysGst = 18;
            double gstAmt = indianAirwaysGeneralTicketCost * indiaAirwaysGst / 100;
            double totalCostForIndianAirways = indianAirwaysGeneralTicketCost + gstAmt;

            double indigoGeneralTicketCost = 3200;
            int indigoGst = 12;
            double indigoGstAmt = indigoGeneralTicketCost * indigoGst / 100;
            double totalCostForIndigoAirways = indigoGeneralTicketCost + indigoGstAmt;

            Console.WriteLine($"Cost for Indian Airways: ₹{totalCostForIndianAirways}");
            Console.WriteLine($"Cost for Indigo Airways: ₹{totalCostForIndigoAirways}");
            Console.WriteLine($"you could have saved   : ₹{totalCostForIndianAirways - totalCostForIndigoAirways}");
        }

        // 39. Read killometers then convert into meters
        public static void ConvertKMToMeters()
        {
            Console.Write("Enter the distance in Km: ");
            int km = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nMeters: {km * 1000}");
        }

        // 40. Read hours then convert into days
        public static void ConvertHrsToDays()
        {
            Console.Write("Enter hours: ");
            int hrs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nDays: {hrs / 24}");
        }


        public static void Main(string[] args)
        {
            System.Console.WriteLine("\n\n===================== Q1 =====================");
            ClassWork.StringConcatenation();

            System.Console.WriteLine("\n\n===================== Q2 =====================");
            ClassWork.Sum1();

            System.Console.WriteLine("\n\n===================== Q3 =====================");
            ClassWork.Sum2();

            System.Console.WriteLine("\n\n===================== Q4 =====================");
            ClassWork.Subtraction();

            System.Console.WriteLine("\n\n===================== Q5 =====================");
            ClassWork.CalculateMonthlySalary();

            System.Console.WriteLine("\n\n===================== Q6 =====================");
            ClassWork.CalculateAnnualSalary();

            System.Console.WriteLine("\n\n===================== Q7 =====================");
            ClassWork.CalculatePizzaBill();

            System.Console.WriteLine("\n\n===================== Q8 =====================");
            ClassWork.CalculateTotalAndAvgMarks();

            System.Console.WriteLine("\n\n===================== Q9 =====================");
            ClassWork.CelsiusToFahrenheit();

            System.Console.WriteLine("\n\n===================== Q10 ====================");
            ClassWork.FahrenheitToCelsius();

            System.Console.WriteLine("\n\n===================== Q11 ====================");
            ClassWork.SimpleInterest1();

            System.Console.WriteLine("\n\n===================== Q12 ====================");
            ClassWork.SwapTwoNumbers1();

            System.Console.WriteLine("\n\n===================== Q13 ====================");
            ClassWork.SwapTwoNumbers2();

            System.Console.WriteLine("\n\n===================== Q14 ====================");
            ClassWork.SwapTwoNumbers3();

            System.Console.WriteLine("\n\n===================== Q15 ====================");
            ClassWork.CalculateDistance();

            System.Console.WriteLine("\n\n===================== Q16 ====================");
            ClassWork.CalculateBillPerPerson();

            System.Console.WriteLine("\n\n===================== Q17 ====================");
            ClassWork.CalculateMilkBill();

            System.Console.WriteLine("\n\n===================== Q18 ====================");
            ClassWork.CalculateAttendancePercentage();

            System.Console.WriteLine("\n\n===================== Q19 ====================");
            ClassWork.CalculateWaterTinsBill();

            System.Console.WriteLine("\n\n===================== Q20 ====================");
            ClassWork.CalculatePetrolQuantity();

            System.Console.WriteLine("\n\n===================== Q21 ====================");
            ClassWork.CalculateProfit();

            System.Console.WriteLine("\n\n===================== Q22 ====================");
            ClassWork.CalculateProductPrice();

            System.Console.WriteLine("\n\n===================== Q23 ====================");
            ClassWork.CalculatePizzaPriceAndDiscount();

            System.Console.WriteLine("\n\n===================== Q24 ====================");
            ClassWork.CalculateMonthlySalary2();

            System.Console.WriteLine("\n\n===================== Q25 ====================");
            ClassWork.CalculateEMI();

            System.Console.WriteLine("\n\n===================== Q26 ====================");
            ClassWork.CalculateElectricityBill();

            System.Console.WriteLine("\n\n===================== Q27 ====================");
            ClassWork.CalculateTravellingCharges();

            System.Console.WriteLine("\n\n===================== Q28 ====================");
            ClassWork.TakeIPAndPrint();

            System.Console.WriteLine("\n\n===================== Q29 ====================");
            ClassWork.CalculateBiryaniBill();

            System.Console.WriteLine("\n\n===================== Q30 ====================");
            ClassWork.INRToUSD();

            System.Console.WriteLine("\n\n===================== Q31 ====================");
            ClassWork.USDToINR();

            System.Console.WriteLine("\n\n===================== Q32 ====================");
            ClassWork.CalculateNewTicketCost();

            System.Console.WriteLine("\n\n===================== Q33 ====================");
            ClassWork.CalculateSalaryAfterHike();

            System.Console.WriteLine("\n\n===================== Q34 ====================");
            ClassWork.CalculateStampDutyCost();

            System.Console.WriteLine("\n\n===================== Q35 ====================");
            ClassWork.TempConverter1();

            System.Console.WriteLine("\n\n===================== Q36 ====================");
            ClassWork.TempConverter2();

            System.Console.WriteLine("\n\n===================== Q37 ====================");
            ClassWork.CalculateMangoBill();

            System.Console.WriteLine("\n\n===================== Q38 ====================");
            ClassWork.CompareFlightTickets();

            System.Console.WriteLine("\n\n===================== Q39 ====================");
            ClassWork.ConvertKMToMeters();

            System.Console.WriteLine("\n\n===================== Q40 ====================");
            ClassWork.ConvertHrsToDays();
        }
    }
}


