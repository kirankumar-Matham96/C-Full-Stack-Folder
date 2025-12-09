using Microsoft.VisualBasic;

namespace ManualProgramms
{
        class RelationalOperators
        {
                /* 6. Is the character is vowel? */
                public static void IsVowel()
                {
                        while (true)
                        {
                                Console.WriteLine("Enter a character");
                                char ch = Convert.ToChar(Console.ReadLine());
                                if (char.IsLetter(ch))
                                {
                                        ch = char.ToLower(ch);
                                        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                                        {
                                                Console.WriteLine($"{ch} is a vowel");
                                        }
                                        else
                                        {
                                                Console.WriteLine($"{ch} is not a vowel");
                                        }
                                        return;
                                }
                                else
                                {
                                        Console.WriteLine($"{ch} is not a letter/alphabet. Please enter valid alphabet");
                                        continue;
                                }
                        }
                }

                /* 7. Is the character uppercase letter? */
                public static void IsUppercaseLetter()
                {
                        Console.Write("Enter a character: ");
                        char ch = Convert.ToChar(Console.ReadLine());
                        if (char.IsLetter(ch) && char.IsUpper(ch))
                        {
                                Console.WriteLine($"{ch} is an upper case letter");
                        }
                        else
                        {
                                Console.WriteLine($"{ch} is not an upper case letter");

                        }
                }

                /* 8. Is the character a digit? */
                public static void IsDigit()
                {
                        char ch = Convert.ToChar(Console.ReadLine());
                        if (char.IsDigit(ch)) Console.WriteLine($"{ch} is a digit");
                        else Console.WriteLine($"{ch} is not a digit");
                }

                /* 9. Check if the entered number is 4 digits long */
                public static void IsNumberHave4Digits()
                {
                        Console.Write("Enter an integer: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int digits = 0, temp = n;

                        while (temp != 0)
                        {
                                temp = temp / 10;
                                digits++;
                        }
                        if (digits == 4) Console.WriteLine($"{n} have 4 digits");
                        else Console.WriteLine($"{n} does not have 4 digits");
                }

                /* 10. Check if a given character is an alphabet */
                public static void IsAlphabet()
                {
                        Console.Write("Enter a character: ");
                        char ch = Convert.ToChar(Console.ReadLine());
                        if (char.IsLetter(ch)) Console.WriteLine($"{ch} is an alphabet");
                        else Console.WriteLine($"{ch} is not an alphabet");
                }

                /* 11. Check if a given character is a symbol (non-alphabet) */
                public static void IsSymbol()
                {
                        Console.Write("Enter a character: ");
                        char ch = Convert.ToChar(Console.ReadLine());
                        if (!char.IsLetterOrDigit(ch)) Console.WriteLine($"{ch} is a symbol");
                        else Console.WriteLine($"{ch} is not a symbol");
                }

                /* 12. Check if given 3 numbers are equal */
                public static void AreEqual()
                {
                        Console.Write("Enter num 1: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter num 2: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter num 3: ");
                        int num3 = Convert.ToInt32(Console.ReadLine());

                        if (num1 == num2 && num1 == num3) Console.WriteLine($"{num1}, {num2}, {num3} are equal");
                        else Console.WriteLine($"{num1}, {num2}, {num3} are not equal");
                }

                /* 13. Check if any 2 numbers in a given 3 numbers are equal */
                public static void AreAny2Equal()
                {
                        Console.Write("Enter num 1: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter num 2: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter num 3: ");
                        int num3 = Convert.ToInt32(Console.ReadLine());

                        if (num1 == num2 || num1 == num3 || num2 == num3) Console.WriteLine($"two of {num1}, {num2}, {num3} are equal");
                        else Console.WriteLine($"There are no equal numbers in the given set");
                }

                /* 14. Check if a given 3 numbers are not equal */
                public static void AreNotEqual()
                {
                        Console.Write("Enter num 1: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter num 2: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter num 3: ");
                        int num3 = Convert.ToInt32(Console.ReadLine());

                        if (num1 != num2 && num1 != num3 && num2 != num3) Console.WriteLine($"None of {num1}, {num2}, {num3} are equal");
                        else Console.WriteLine($"There are equal numbers found in the given set");
                }

                /* 15. Check if the student passed in all the subjects
                        Pass marks = 40/100.
                        Subjects = Java, SQL, and HTML
                */
                public static void IsPassed()
                {
                        int passMarks = 40;
                        Console.Write("Enter the Java marks: ");
                        int JavaMarks = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the SQL marks: ");
                        int SQLMarks = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the HTML marks: ");
                        int HTMLMarks = Convert.ToInt32(Console.ReadLine());

                        if (JavaMarks >= passMarks && SQLMarks >= passMarks && HTMLMarks >= passMarks) Console.WriteLine("Student Passed!");
                        else Console.WriteLine("Student Failed!");
                }

                /* 16. Chack if a candidate is eligible for loan:
                        Income should be more than 25000.
                        Age should be more than 21.
                        Credit score should be more than 700
                */
                public static void IsEligibleForLoan()
                {
                        Console.Write("Enter your income: ");
                        double income = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter your age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter your Credit Score: ");
                        int creditScore = Convert.ToInt32(Console.ReadLine());

                        if (income > 25000 && age > 21 && creditScore > 700) Console.WriteLine("Congrats! You are eligible for the loan.");
                        else Console.WriteLine("We are sorry! You are not eligible for the loan.");
                }


                /* 17. Check if the bill amount is eligible for the discount:
                        Cart value must be more than 3000.
                        Buyyer must be the first time customer. 
                */
                public static void IsEligibleForDiscount()
                {
                        double minCartWorth = 3000.00;

                        Console.Write("Enter the total cart amount: ");
                        double cartCost = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Are you purchasing for the first time? (y/n): ");
                        char isFirstPurchase = char.ToLower(Convert.ToChar(Console.ReadLine()));

                        if (cartCost > minCartWorth && isFirstPurchase == 'y') Console.WriteLine("Congrats! You are eligible for the discount.");
                        else Console.WriteLine("Sorry! You are not eligible for the discount.");
                }

                /* 18. Check for the return eligibility:
                        Damage = no damage
                        days since purchase < 30
                */
                public static void CanReturnTheItem()
                {
                        Console.Write("Enter the days since purchase: ");
                        int daysSincePurchase = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Is the item damaged (y/n): ");
                        char isDamaged = Convert.ToChar(Console.ReadLine());

                        if (daysSincePurchase < 30 && isDamaged == 'y') Console.WriteLine("The item is eligible for the return");
                        else Console.WriteLine("The item is not eligible for the return");
                }

                /* 19. Check if a person is eligible to purchase alcohol:
                        age > 18
                        should have id proof
                */
                public static void IsEligibleToBuyAlcohol()
                {
                        Console.Write("Enter your age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Do you have an ID (y/n): ");
                        char haveId = char.ToLower(Convert.ToChar(Console.ReadLine()));

                        if (age > 18 && haveId == 'y') Console.WriteLine("You are eligible");
                        else Console.WriteLine("You are not eligible");
                }

                public static void RunTests()
                {
                        // IsVowel();
                        // IsUppercaseLetter();
                        // IsDigit();
                        // IsNumberHave4Digits();
                        // IsAlphabet();
                        // IsSymbol();
                        // AreEqual();
                        // AreAny2Equal();
                        // AreNotEqual();
                        // IsPassed();
                        // IsEligibleForLoan();
                        // IsEligibleForDiscount();
                        // CanReturnTheItem();
                        IsEligibleToBuyAlcohol();
                }

        }
}