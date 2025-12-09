namespace ManualProgramms
{
    class ArithmaticPrograms
    {
        /*
            16. W.A.P to calculate the total salary of an employee:
                    Basic Salary = 100000.0
                    hra = 30%
                    da = 20%
                    total salary = basic salary + hra + da
        */
        public static void CalculateTotalSal()
        {
            double basicSalary = 100000.00;
            int hra = 30;
            int da = 20;
            double hraAmt = basicSalary * hra / 100;
            double daAmt = basicSalary * da / 100;
            double totalSal = basicSalary + hraAmt + daAmt;
            Console.WriteLine($"Total salary is: {totalSal}");
        }

        /*
            17. The government imposes 18% of tax on all profits. Consider the profit amount as 255000.56. 
            W.A.P to calculate the tax amount and profit after tax.
        */
        public static void CalculateTaxAndProfit()
        {
            int taxOnProfit = 18;
            double profit = 255000.56;
            double taxAmt = profit * taxOnProfit / 100;
            double ProfitAfterTax = profit - taxAmt;
            Console.WriteLine($"The Tax amount is: {taxAmt} and Net profit after tax is: {ProfitAfterTax}");
        }
        /*
            18. Consider Rs. 650000.00 as Indian currency and (1 dollar = 85.75 Rs).
            W.A.P to convert Indian curency to USD
        */
        public static void ConvertINRToUSD()
        {
            double INR = 650000.00;
            double USD = 85.75;
            double INRInUSD = INR / USD;
            Console.WriteLine($"INR Rs. {INR} = USD $ {INRInUSD}");
        }
        /*
            19. Consider Rs. 1507500.00 is split amongst 6 winners.
            W.A.P to find the amount of each person will get in dinars? (1 dinar = 178 Rs)
        */
        public static void CalculateAmountPerPerson()
        {
            double totalBillAmt = 1507500.00;
            int persons = 6;
            double amtPerPerson = totalBillAmt / persons;
            Console.WriteLine($"Each person should pay: {amtPerPerson}");
        }
        /*
            20. A patient stays in the hospital for 5 days.
                The daily room charge = Rs.2000/-,
                doctor fees = Rs.5000,
                medicin cost = Rs.3000
            W.A.P to calculate the total bill amount.
        */
        public static void CalculateTotalHospitalBil()
        {
            int daysStayed = 5;
            double dailyRoomCharge = 2000.0;
            double doctorFee = 5000.0;
            double medicinCost = 3000.0;
            double totalBillAmt = (daysStayed * dailyRoomCharge) + doctorFee + medicinCost;
            Console.WriteLine($"Total bill amount: {totalBillAmt}");
        }
        /*
            21. A person buys an insurance policy with an annual premium of Rs.24000.
            W.A.P to calculate monthly premium
        */
        public static void CalculateMonthlyPremium()
        {
            double annualPremium = 24000.0;
            double monthlyPremium = annualPremium / 12;
            Console.WriteLine($"Monthly premium: {monthlyPremium}");
        }
        /*
            22. A person have Rs.500000.00 Life insurance policy with 5% annual interest.
            W.A.P to calculate payout after 10 years. 
        */
        public static void CalculatePayoutAfter10Years()
        {
            double policyAmt = 500000.0;
            int annualInterestRate = 5;
            double annualInterestAmt = policyAmt * annualInterestRate / 100;
            double totalAmtAfter10Years = policyAmt + annualInterestAmt * 10;
            Console.WriteLine($"Total amount to be paid after 10 years: {totalAmtAfter10Years}");
        }
        /*
            23. W.A.P to swap 2 variables with the help of 3rd variable
        */
        public static void Swap2NumsWith3rdVariable()
        {
            Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"{num1},{num2}");
        }
        /*
            24. W.A.P to swap 2 variables without the help of 3rd variable
        */
        public static void Swap2NumsWithOut3rdVariable1()
        {
            Console.WriteLine("swaping 2 variables without the help of 3rd variable using arithmatic operators");
            Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine($"{num1},{num2}");
        }

        /* Swapping 2 numbers without 3rd variable using XOR operation */
        public static void Swap2NumsWithOut3rdVariable2()
        {
            Console.WriteLine("swaping 2 variables without the help of 3rd variable using XOR operations");
            Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            num1 = num1 ^ num2;
            num2 = num1 ^ num2;
            num1 = num1 ^ num2;
            Console.WriteLine($"{num1},{num2}");
        }

        /* Swapping 2 numbers without 3rd variable using tuples */
        public static void Swap2NumsWithOut3rdVariable3()
        {
            Console.WriteLine("swaping 2 variables without the help of 3rd variable using tuples");
            Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            (num1, num2) = (num2, num1);
            Console.WriteLine($"{num1},{num2}");
        }


        /* Method to run all the tests */
        public static void RunTests()
        {
            ArithmaticPrograms.CalculateTotalSal();
            ArithmaticPrograms.CalculateTaxAndProfit();
            ArithmaticPrograms.ConvertINRToUSD();
            ArithmaticPrograms.CalculateAmountPerPerson();
            ArithmaticPrograms.CalculateTotalHospitalBil();
            ArithmaticPrograms.CalculateMonthlyPremium();
            ArithmaticPrograms.CalculatePayoutAfter10Years();
            ArithmaticPrograms.Swap2NumsWith3rdVariable();
            ArithmaticPrograms.Swap2NumsWithOut3rdVariable1();
            ArithmaticPrograms.Swap2NumsWithOut3rdVariable2();
            ArithmaticPrograms.Swap2NumsWithOut3rdVariable3();
        }
    }
}