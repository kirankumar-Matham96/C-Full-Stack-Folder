using System.Globalization;

namespace ManualProgramms
{
        class LogicalOperators
        {
                /* 1. Check if 10% discount is applicable:
                        Total bill >= 1500 and hasMembership
                */
                public static void IsDiscountApplicable1()
                {
                        Console.Write("Enter your total bill amount: ");
                        double amt = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Do you have membership (y/n): ");
                        char hasMembership = char.ToLower(Convert.ToChar(Console.ReadLine()));
                        if (amt >= 1500 && hasMembership == 'y') Console.WriteLine($"You are eligible for the 10% discount\nDiscount: {amt * 10 / 100}\nFinal Bill: {amt - amt * 10 / 100}");
                        else Console.WriteLine("Sorry! You are not eligible for the 10% discount");
                }


                /* 2. Check if 5% discount is applicable:
                        Total bill >= 500 and firstTimer 
                */
                public static void IsDiscountApplicable2()
                {
                        Console.Write("Enter your total bill amount: ");
                        double amt = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Are you new here (y/n): ");
                        char isFirstTimer = char.ToLower(Convert.ToChar(Console.ReadLine()));
                        if (amt >= 500 && isFirstTimer == 'y') Console.WriteLine($"You are eligible for the 5% discount\nDiscount: {amt * 5 / 100}\nFinal Bill: {amt - amt * 5 / 100}");
                        else Console.WriteLine("Sorry! You are not eligible for the 5% discount");
                }
                /* 3. Check if a person can donate blood:
                        weight should be between 55 to 90
                */
                public static void CanDonateBllod()
                {
                        Console.Write("Enter your weight: ");
                        double weight = Convert.ToDouble(Console.ReadLine());

                        if (weight > 55 && weight < 90) Console.WriteLine("You are eligible to donate blood");
                        else Console.WriteLine("You are not eligible to donate blood");
                }

                /* 4. Check if the character is vowel or not */
                public static void IsVowel()
                {
                        Console.Write("Enter a character: ");
                        char ch = Convert.ToChar(Console.ReadLine());

                        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U') Console.WriteLine($"{ch} is a vowel");
                        else Console.WriteLine($"{ch} is not a vowel");
                }

                /* 5. Check if the character is a symbol or not */
                public static void IsSymbol()
                {
                        Console.Write("Enter a character: ");
                        char ch = Convert.ToChar(Console.ReadLine());

                        if (!char.IsLetterOrDigit(ch)) Console.WriteLine($"{ch} is a symbol");
                        else Console.WriteLine($"{ch} is not a symbol");
                }

                /* 6. Check if the number is:
                        single digit / 2 digit / 3 digit / other digit 
                */
                public static void CheckDigitsOfNumber()
                {
                        Console.Write("Enter a number: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        int digits = 0, temp = num;

                        while (temp != 0)
                        {
                                temp = temp / 10;
                                digits++;
                        }

                        Console.WriteLine($"{num} is a {digits} digit number");
                }
                /* 7. Find the biggest of 2 numbers given */
                public static void BiggestOfTwoNumbers()
                {
                        Console.Write("Enter first number: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        if (num1 > num2) Console.WriteLine($"{num1} is greater than {num2}");
                        else if (num1 < num2) Console.WriteLine($"{num2} is greater than {num1}");
                        else Console.WriteLine($"{num1} and {num2} are equal");
                }
                /* 8. Display student grade, if only student passed in all subjects */
                public static void DisplayGrade()
                {

                }
                /* 9. Display number of days for the given valid month */
                public static void DaysInMonth()
                {

                }
                /* 10. University scholarship eligibility:
                        Marks >= 95%             --->   Full Scholarship
                        Marks >= 85% and < 95%   --->   Half Scholarship
                        Marks >= 75% and < 85%   --->   Quarter Scholarship
                        Marks < 75%              --->   Quarter Scholarship
                    Check if a student is eligible for any scholarship
                    Note: Total subjects: 3
                */
                public static void IsEligibleForScholarship()
                {

                }

                /* 11. A student is allowed to sit in an exam only if:
                        Attendance >= 85%         --->  Allowed for exams
                        Attendance b/w 75% - 84%  --->  Allowed for exams with warnings
                        Attendance < 75%          --->  Not Allowed for exams
                    Check if the student is allowed or not based on the inputs
                */
                public static void IsAllowedToExams()
                {

                }
                /* 12. A storage gives discount based on the purchased amount:
                        bill >= 5000          --->  25%
                        bill b/w 3000 - 4999  --->  15%
                        bill b/w 1000 - 2999  --->  10%
                        bill >= 5000          --->  No discount
                    Calculate final price
                */
                public static void FinalPriceAfterDiscount()
                {

                }
                /* 13. Check if the product is available:
                        stock >= 50        --->  In Stock
                        stock b/w 20 - 49  --->  Limited Stock
                        stock b/w 1 - 19   --->  Hurry! Almost out of Stock
                        stock = 0          --->  Out of Stock
                    Take input and display status
                */
                public static void IsProductAvailable()
                {

                }
                /* 14. Check if an employee is eligible for retirement:
                        Age >= 60        --->   Eligible for Retirement
                        Age b/w 55 - 60  --->   Eligible for Early Retirement
                        Age < 55         --->   Not eligible for Retirement
                */
                public static void CanRetire()
                {

                }
                /* 15. Calculate the power bill of the consumed units:
                        0-100 units      --->   1.3 per unit
                        101-200 units    --->   1.8 per unit
                        201-300 units    --->   2.3 per unit
                        Above 300 units  --->   3.4 per unit
                */
                public static void CalculatePowerBill()
                {

                }
                /* 16. Calculate interest rates:
                        Rs: 0.00 - 50,000.00           --->   2% annual rate of interest
                        Rs: 50,001.00 - 1,00,000.00    --->   3% annual rate of interest
                        Rs: 1,00,001.00 - 2,00,000.00  --->   4% annual rate of interest
                        Rs: above 2,00,000.00          --->   5% annual rate of interest
                    Calculate total anual rate of interest based on the account balance
                */
                public static void CalculateTotalAnnualRateOfInterest()
                {

                }
                /* 17. Calculate the consultation fee:
                        Age 0 - 10    --->  Rs. 200
                        Age 11 - 25   --->  Rs. 300
                        Age 26 - 40   --->  Rs. 400
                        Age 41 - 60   --->  Rs. 500
                        Age above 60  --->  Rs. 600
                    Based on the age calculate consultation fee
                */
                public static void CalculateConsultatonFee()
                {

                }
                public static void RunTests()
                {
                        IsDiscountApplicable1();
                        // IsDiscountApplicable2();
                        // CanDonateBllod();
                        // IsVowel();
                        // IsSymbol();
                        // CheckDigitsOfNumber();
                        // BiggestOfTwoNumbers();
                        // DisplayGrade();
                        // DaysInMonth();
                        // IsEligibleForScholarship();
                        // IsAllowedToExams();
                        // FinalPriceAfterDiscount();
                        // IsProductAvailable();
                        // CanRetire();
                        // CalculatePowerBill();
                        // CalculateTotalAnnualRateOfInterest();
                        // CalculateConsultatonFee();
                }
        }
}