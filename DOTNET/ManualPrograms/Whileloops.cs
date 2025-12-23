using System.Runtime.InteropServices;

namespace ManualProgramms
{
  class WhileLoops
  {


    // 1. Program to Display the Last digit of given number:
    public static void GetLastDigit()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int lastDigit = n % 10;
      Console.WriteLine("Last digit: " + lastDigit);
    }

    // 2. Program to Remove the Last digit of given number:
    public static void RemoveLastDigit()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int removedLastDigit = n / 10;
      Console.WriteLine("Number after removing last digit: " + removedLastDigit);
    }

    // 3. Program to count the digits in given number:
    public static void GetDigitCount()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int count = 0;
      while (n != 0)
      {
        n = n / 10;
        count++;
      }
      Console.WriteLine("Number of digits: " + count);
    }

    // 4. Program to find the sum of digits in given number:
    public static void GetSumOfDigits()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int sum = 0;
      while (n != 0)
      {
        sum += n % 10;
        n /= 10;
      }
      Console.WriteLine("Sum of digits: " + sum);
    }

    // 5. Program to check last digit is even or not:
    public static void IsLastDigitEven()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int lastDigit = n % 10;
      if (lastDigit % 2 == 0)
      {
        Console.WriteLine("Last digit is even.");
      }
      else
      {
        Console.WriteLine("Last digit is odd.");
      }
    }

    // 6. Program to display only even digits in the given number:
    public static void GetEvenDigits()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      Console.Write("Even digits: ");
      while (n != 0)
      {
        int digit = n % 10;
        if (digit % 2 == 0)
        {
          Console.Write(digit + " ");
        }
        n /= 10;
      }
      Console.WriteLine();
    }

    // 7. Program to find the sum of even digits in the given number:
    public static void GetSumOfEvenDigits()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int sum = 0;
      while (n != 0)
      {
        int digit = n % 10;
        if (digit % 2 == 0)
        {
          sum += digit;
        }
        n /= 10;
      }
      Console.WriteLine("Sum of even digits: " + sum);
    }

    // 8. Program to count even digits in the given number:
    public static void GetCountOfEvenDigits()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int count = 0;
      while (n != 0)
      {
        int digit = n % 10;
        if (digit % 2 == 0)
        {
          count++;
        }
        n /= 10;
      }
      Console.WriteLine("Count of even digits: " + count);
    }

    // 9. Program to find the largest digit in the given number:
    public static void GetLargestDigit()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int largest = 0;
      while (n != 0)
      {
        int digit = n % 10;
        if (digit > largest)
        {
          largest = digit;
        }
        n /= 10;
      }
      Console.WriteLine("Largest digit: " + largest);
    }

    // 10. Program to find the smallest digit in the given number:
    public static void GetSmallestDigit()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int smallest = 9;
      while (n != 0)
      {
        int digit = n % 10;
        if (digit < smallest)
        {
          smallest = digit;
        }
        n /= 10;
      }
      Console.WriteLine("Smallest digit: " + smallest);
    }

    // 11. Program to check the number contains zero or not:
    public static void IsContainsZero()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      bool containsZero = false;
      while (n != 0)
      {
        int digit = n % 10;
        if (digit == 0)
        {
          containsZero = true;
          break;
        }
        n /= 10;
      }
      if (containsZero)
      {
        Console.WriteLine("The number contains zero.");
      }
      else
      {
        Console.WriteLine("The number does not contain zero.");
      }
    }

    // 12. Program to find the average of all digits in the given number:
    public static void GetAvgOfDigits()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int sum = 0;
      int count = 0;
      while (n != 0)
      {
        sum += n % 10;
        count++;
        n /= 10;
      }
      double average = (double)sum / count;
      Console.WriteLine("Average of digits: " + average);
    }

    // 13. Program to find the second largest digit in the given number:
    public static void GetSecondLargestDigit()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int largest = -1;
      int secondLargest = -1;
      while (n != 0)
      {
        int digit = n % 10;
        if (digit > largest)
        {
          secondLargest = largest;
          largest = digit;
        }
        else if (digit > secondLargest && digit != largest)
        {
          secondLargest = digit;
        }
        n /= 10;
      }
      Console.WriteLine("Second largest digit: " + secondLargest);
    }

    // 14. Program to find the second smallest digit in the given number:
    public static void GetSecondSmallestDigit()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int smallest = 10;
      int secondSmallest = 10;
      while (n != 0)
      {
        int digit = n % 10;
        if (digit < smallest)
        {
          secondSmallest = smallest;
          smallest = digit;
        }
        else if (digit < secondSmallest && digit != smallest)
        {
          secondSmallest = digit;
        }
        n /= 10;
      }
      Console.WriteLine("Second smallest digit: " + secondSmallest);
    }

    // 15. Program to find the first digit in the given number:
    public static void GetFirstDigit()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int firstDigit = n;
      while (firstDigit >= 10)
      {
        firstDigit /= 10;
      }
      Console.WriteLine("First digit: " + firstDigit);
    }

    // 16. Program to find the sum of first and last digits in the given number:
    public static void GetSumOfFirstAndLastDigits()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int lastDigit = n % 10;
      int firstDigit = n;
      while (firstDigit >= 10)
      {
        firstDigit /= 10;
      }
      Console.WriteLine("Sum of first and last digits: " + (firstDigit + lastDigit));
    }

    // 17. Program to display multiplication table for each digit in the given number:
    public static void GetMultiplicationTablesOfDigits()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      while (n != 0)
      {
        int digit = n % 10;
        Console.WriteLine("Multiplication table for " + digit + ":");
        for (int i = 1; i <= 10; i++)
        {
          Console.WriteLine($"{digit} X {i} = {digit * i}");
        }
        n /= 10;
      }
    }

    // 18. Program to find factorial value for each digit in the given number:
    public static void GetFactorialsOfDigits()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      while (n != 0)
      {
        int digit = n % 10;
        int factorial = 1;
        for (int i = 1; i <= digit; i++)
        {
          factorial *= i;
        }
        Console.WriteLine("Factorial of " + digit + " is " + factorial);
        n /= 10;
      }
    }

    // 19. Program to display square and cube values for each digit in the given number:
    public static void GetSquareAndCubesOfDigits()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      while (n != 0)
      {
        int digit = n % 10;
        int square = digit * digit;
        int cube = digit * digit * digit;
        Console.WriteLine("Digit: " + digit + ", Square: " + square + ", Cube: " + cube);
        n /= 10;
      }
    }

    // 20. Program to display only prime digits in the given number:
    public static void GetPrimeDigits()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      while (n != 0)
      {
        int digit = n % 10;
        if (digit == 2 || digit == 3 || digit == 5 || digit == 7)
        {
          Console.WriteLine(digit);
        }
        n /= 10;
      }
    }

    // 21. Program to reverse the given number
    public static int GetReverseNum(int n)
    {
      int reverse = 0;
      while (n != 0)
      {
        int digit = n % 10;
        reverse = reverse * 10 + digit;
        n /= 10;
      }
      return reverse;
    }

    /*
    22. Palindrome Number: The number becomes same when we reverse it.
        Examples: 121, 1001, 123321
    */
    public static void IsPalindrome()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int reverse = GetReverseNum(n);
      if (n == reverse)
        Console.WriteLine("Palindrome");
      else
        Console.WriteLine("Not a palindrome");
    }

    // 23. Program to find the power value of digits of given number by reading input values.
    public static void GetPowerOfDigitsOfANum()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter Power value: ");
      int power = Convert.ToInt32(Console.ReadLine());
      while (n != 0)
      {
        int digit = n % 10;
        int result = 1;
        for (int i = 1; i <= power; i++)
        {
          result *= digit;
        }
        Console.WriteLine("Digit: " + digit + ", " + digit + "^" + power + " = " + result);
        n /= 10;
      }
    }

    // 24. Program to find the square root value for the given number without library method:
    public static int GetSquareRoot(int n)
    {
      int sqrt = 0;
      int i = 1;
      while (i * i <= n)
      {
        sqrt = i;
        i++;
      }
      return sqrt;
    }

    /*
    25. Program to check the given number is Armstrong number or not:

        Armstrong Number: Sum of its own digits raised to power number of digits.

        Examples:
            ```
            153 = 1^3 + 5^3 + 3^3 = 153
            1634 = 1^4 + 6^4 + 3^4 + 4^4 = 1634
            ```
    */
    public static void IsArmstrong()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int originalNum = n;
      int count = 0;
      int sum = 0;

      // Count number of digits
      int temp = n;
      while (temp != 0)
      {
        count++;
        temp /= 10;
      }

      // Calculate sum of digits raised to the power of count
      temp = n;
      while (temp != 0)
      {
        int digit = temp % 10;
        int powerValue = 1;
        for (int i = 1; i <= count; i++)
        {
          powerValue *= digit;
        }
        sum += powerValue;
        temp /= 10;
      }

      if (sum == originalNum)
        Console.WriteLine("Armstrong Number");
      else
        Console.WriteLine("Not an Armstrong Number");
    }

    /*
    26. Program to find Sum of Digits till Single Digit:
        ```
        9657 → 9+6+5+7 = 27 → 2+7 = 9
        ```
    */
    public static void GetSumOfDigitsTillSingleDigit()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      while (n >= 10)
      {
        int sum = 0;
        while (n != 0)
        {
          sum += n % 10;
          n /= 10;
        }
        n = sum;
      }
      Console.WriteLine("Single digit sum: " + n);
    }

    /*
    27. Write the Program for ADAM number?

    ADAM Number:
    Take a number then square it then reverse it then find its square root then reverse.
    If the given number equals the final number then it is called ADAM.

    Example:

    * Take the number (12)
    * Square the number(144)
    * Reverse the number(441)
    * Square root of number(21)
    * Reverse the number(12)

    */
    public static void IsADAMsNum()
    {
      Console.WriteLine("Enter a digit: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int squared = n * n;
      int reversedSquared = GetReverseNum(squared);
      int sqrt = GetSquareRoot(reversedSquared);
      int reversedSqrt = GetReverseNum(sqrt);
      if (n == reversedSqrt)
        Console.WriteLine("ADAM Number");
      else
        Console.WriteLine("Not an ADAM Number");
    }

    public static void RunTests()
    {
      GetLastDigit();
      // RemoveLastDigit();
      // GetDigitCount();
      // GetSumOfDigits();
      // IsLastDigitEven();
      // GetEvenDigits();
      // GetSumOfEvenDigits();
      // GetCountOfEvenDigits();
      // GetLargestDigit();
      // GetSmallestDigit();
      // IsContainsZero();
      // GetAvgOfDigits();
      // GetSecondLargestDigit();
      // GetSecondSmallestDigit();
      // GetFirstDigit();
      // GetSumOfFirstAndLastDigits();
      // GetMultiplicationTablesOfDigits();
      // GetFactorialsOfDigits();
      // GetSquareAndCubesOfDigits();
      // GetPrimeDigits();
      // Console.Write("Enter a number: ");
      // int n1 = Convert.ToInt32(Console.ReadLine());
      // Console.WriteLine(GetReverseNum(n1));
      // IsPalindrome();
      // GetPowerOfDigitsOfANum();
      // Console.Write("Enter a number: ");
      // int n = Convert.ToInt32(Console.ReadLine());
      // Console.WriteLine(GetSquareRoot(n));
      // IsArmstrong();
      // GetSumOfDigitsTillSingleDigit();
      // IsADAMsNum();
    }
  }

}
