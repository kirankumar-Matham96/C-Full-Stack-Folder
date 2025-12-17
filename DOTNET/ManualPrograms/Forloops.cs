using System.Diagnostics.CodeAnalysis;

namespace ManualProgramms
{
  class ForLoops
  {

    // 1. print numbers 2,4,6,8,10;
    public static void PrintNums1()
    {
      for (int i = 1; i <= 10; i++)
      {
        if (i % 2 == 0) Console.Write($"{i} ");
      }
    }

    // 2. Print numbers 15,12,9,6,3,0
    public static void PrintNums2()
    {
      for (int i = 15; i >= 0; i -= 3)
      {
        Console.Write($"{i} ");
      }
    }

    // 3. Print numbers 10,20,30,40,50
    public static void PrintNums3()
    {
      for (int i = 1; i <= 5; i++)
      {
        Console.Write($"{i * 10} ");
      }
    }

    // 4. print numbers 100,80,60,40,20
    public static void PrintNums4()
    {
      for (int i = 100; i >= 0; i -= 20)
      {
        Console.Write($"{i} ");
      }
    }

    // 5. print lower case alphabets from a to z
    public static void PrintLowercaseAlphabets()
    {
      for (char c = 'a'; c <= 'z'; c++)
      {
        Console.Write($"{c} ");
      }
    }

    // 6. Print upper case alphabets from Z to A
    public static void PrintUppercaseAlphabetsInReverseOrder()
    {
      for (char c = 'Z'; c >= 'A'; c--)
      {
        Console.Write($"{c} ");
      }
    }

    // 8. print 1 to N numbers
    public static void PrintNums5()
    {
      Console.Write("Enter a number: ");
      int n = Convert.ToInt32(Console.ReadLine());
      for (int i = 1; i <= n; i++)
      {
        Console.Write($"{i} ");
      }
    }

    // 9. Print N to 1 numbers
    public static void PrintNums6()
    {
      Console.Write("Enter a number: ");
      int n = Convert.ToInt32(Console.ReadLine());
      for (int i = n; i >= 1; i--)
      {
        Console.Write($"{i} ");
      }
    }

    // 10. print ASCII values from A to Z
    public static void PrintASCIIForAToZ()
    {
      for (char c = 'A'; c <= 'Z'; c++)
      {
        Console.WriteLine($"{c}: {(int)c}");
      }
    }

    // 11. print ASCII values for 0 to 9
    public static void PrintASCIIFor0To9()
    {
      for (char c = '0'; c <= '9'; c++)
      {
        Console.WriteLine($"{c}: {(int)c}");
      }
    }

    // 12. print all ASCII values for character set
    public static void PrintAllASCII()
    {
      for (int i = 1; i <= 127; i++)
      {
        Console.WriteLine($"{i}: {(char)i}");
      }
    }

    // 13. print squares of numbers from 1 to 5
    public static void PrintSquares()
    {
      for (int i = 1; i <= 5; i++)
      {
        Console.Write($"{i * i} ");
      }
    }

    // 14. print cubes of numbers from 1 to 5
    public static void PrintCubes()
    {
      for (int i = 1; i <= 5; i++)
      {
        Console.Write($"{i * i * i} ");
      }
    }

    // 15. print sum of first N numbers
    public static void PrintSumOfNNumbers()
    {
      Console.Write("Enter a number: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int sum = 0;
      for (int i = 1; i <= n; i++)
      {
        sum += i;
      }
      Console.WriteLine($"Sum of {n} numbers is: {sum}");
    }

    // 16. find factorial of a number
    public static void GetFactorial()
    {
      Console.Write("Enter a number: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int fact = 1;
      for (int i = 1; i <= n; i++)
      {
        fact *= i;
      }
      Console.WriteLine($"Factorial of {n} is: {fact}");
    }

    // 17. print numbers divisible by 7 b/t 20 and 60
    public static void PrintNumbersDivisibleBy7()
    {
      Console.Write("Numbers divisible by 7: ");
      for (int i = 20; i <= 60; i++)
      {
        if (i % 7 == 0) Console.Write($"{i} ");
      }
    }

    // 18. print numbers divisible by 3 but not by 5 b/t 10 and 50
    public static void PrintNumbersDivisibleBy3ButNot5()
    {
      Console.Write("Numbers divisible by 3 But not 5: ");
      for (int i = 20; i <= 60; i++)
      {
        if (i % 3 == 0 && i % 5 != 0) Console.Write($"{i} ");
      }
    }
    // 19. print numbers divisible by 4 but not by 100 b/t 100 and 300
    public static void PrintNumbersDivisibleBy4ButNot100()
    {
      Console.Write("Numbers divisible by 4 But not 100: ");
      for (int i = 100; i <= 300; i++)
      {
        if (i % 4 == 0 && i % 100 != 0) Console.Write($"{i} ");
      }
    }

    // 20. print numbers not divisible by 5 b/t 30 and 70
    public static void PrintNumbersNotDivisibleBy5()
    {
      Console.Write("Numbers not divisible by 5: ");
      for (int i = 30; i <= 70; i++)
      {
        if (i % 5 != 0) Console.Write($"{i} ");
      }
    }

    // 21. print even numbers b/t 1 and 30 which are not divisible by 5
    public static void PrintNumbersDivisibleBy5()
    {
      Console.Write("Even numbers not divisible by 5: ");
      for (int i = 1; i <= 30; i++)
      {
        if (i % 2 == 0 && i % 5 != 0) Console.Write($"{i} ");
      }
    }

    // 22. display multiplication table
    public static void PrintMultiplicationTable()
    {
      Console.Write("Enter a number: ");
      int n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"Multiplication table for {n}");
      for (int i = 1; i <= 10; i++)
      {
        Console.WriteLine($"{n} X {i} = {n * i}");
      }
      System.Console.WriteLine();
    }

    // 23. print even numbers from 1 to 10
    public static void PrintEvenNumbers()
    {
      for (int i = 1; i <= 10; i++)
      {
        Console.Write($"{i} ");
      }
    }

    // 24. print sum of even numbers from 1 to 25
    public static void PrintSumOfEvenNumbers()
    {
      int sum = 0;
      for (int i = 1; i <= 25; i++)
      {
        if (i % 2 == 0) sum += i;
      }
      Console.WriteLine($"Sum of even numbers between 1 and 25 is: {sum}");
    }

    // 25. print factors of number N
    public static void GetFactors()
    {
      Console.Write("Enter a number: ");
      int n = Convert.ToInt32(Console.ReadLine());
      for (int i = 1; i <= n; i++)
      {
        if (n % i == 0) Console.Write($"{i} ");
      }
    }

    // 26. count factors of number N
    public static void GetFactorsCount()
    {
      Console.Write("Enter a number: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int count = 0;
      for (int i = 1; i <= n; i++)
      {
        if (n % i == 0) count++;
      }
      Console.WriteLine($"Number of Factors of {n} is: {count}");
    }

    // 27. find sum of factors of number N
    public static void GetFactorsSum()
    {
      Console.Write("Enter a number: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int sum = 0;
      for (int i = 1; i <= n; i++)
      {
        if (n % i == 0) sum += i;
      }
      Console.WriteLine($"Sum of Factors of {n} is: {sum}");
    }

    // 28. check if N is prime or not
    public static void IsPrime()
    {
      Console.Write("Enter a number: ");
      int n = Convert.ToInt32(Console.ReadLine());

      if (n == 0 || n == 1) { Console.WriteLine($"{n} is not a prime number"); return; }

      for (int i = 2; i < n / 2; i++)
      {
        if (n % i == 0)
        {
          Console.WriteLine($"{n} is not a prime number");
          return;
        }
      }
      Console.WriteLine($"{n} is a prime number");
    }

    // 29. check if N is perfect number or not (sum of factors of a number excemp that number should be equal to the number itself: 6 = 1+2+3 )
    public static void IsPerfectNum()
    {
      Console.Write("Enter a number: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int sum = 0;
      for (int i = 1; i < n; i++)
      {
        if (n % i == 0) sum += i;
      }
      if (sum == n) Console.WriteLine($"{n} is a perfect number");
      else Console.WriteLine($"{n} is not a perfect number");
    }

    // 30. print fibonacci series up to N
    public static void PrintFibonacciSeries()
    {
      Console.Write("Enter a number: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int a = 0, b = 1, c = 0;
      Console.Write($"{a}\t{b}\t");
      for (int i = 1; i <= n; i++)
      {
        c = a + b;
        Console.Write($"{c}\t");
        a = b;
        b = c;
      }
    }

    public static void RunTests()
    {
      Console.WriteLine("\n\nExecuting Program 1\n");
      PrintNums1();
      Console.WriteLine("\n\nExecuting Program 2\n");
      PrintNums2();
      Console.WriteLine("\n\nExecuting Program 3\n");
      PrintNums3();
      Console.WriteLine("\n\nExecuting Program 4\n");
      PrintNums4();
      Console.WriteLine("\n\nExecuting Program 5\n");
      PrintLowercaseAlphabets();
      Console.WriteLine("\n\nExecuting Program 6\n");
      PrintUppercaseAlphabetsInReverseOrder();
      Console.WriteLine("\n\nExecuting Program 7\n");
      PrintNums5();
      Console.WriteLine("\n\nExecuting Program 8\n");
      PrintNums6();
      Console.WriteLine("\n\nExecuting Program 9\n");
      PrintASCIIForAToZ();
      Console.WriteLine("\n\nExecuting Program 10\n");
      PrintASCIIFor0To9();
      Console.WriteLine("\n\nExecuting Program 11\n");
      PrintAllASCII();
      Console.WriteLine("\n\nExecuting Program 12\n");
      PrintSquares();
      Console.WriteLine("\n\nExecuting Program 13\n");
      PrintCubes();
      Console.WriteLine("\n\nExecuting Program 14\n");
      PrintSumOfNNumbers();
      Console.WriteLine("\n\nExecuting Program 15\n");
      GetFactorial();
      Console.WriteLine("\n\nExecuting Program 16\n");
      PrintNumbersDivisibleBy7();
      Console.WriteLine("\n\nExecuting Program 17\n");
      PrintNumbersDivisibleBy3ButNot5();
      Console.WriteLine("\n\nExecuting Program 18\n");
      PrintNumbersDivisibleBy4ButNot100();
      Console.WriteLine("\n\nExecuting Program 19\n");
      PrintNumbersNotDivisibleBy5();
      Console.WriteLine("\n\nExecuting Program 20\n");
      PrintMultiplicationTable();
      Console.WriteLine("\n\nExecuting Program 21\n");
      PrintNumbersDivisibleBy5();
      Console.WriteLine("\n\nExecuting Program 22\n");
      PrintEvenNumbers();
      Console.WriteLine("\n\nExecuting Program 23\n");
      PrintSumOfEvenNumbers();
      Console.WriteLine("\n\nExecuting Program 24\n");
      GetFactors();
      Console.WriteLine("\n\nExecuting Program 25\n");
      GetFactorsCount();
      Console.WriteLine("\n\nExecuting Program 26\n");
      GetFactorsSum();
      Console.WriteLine("\n\nExecuting Program 27\n");
      IsPrime();
      Console.WriteLine("\n\nExecuting Program 28\n");
      IsPerfectNum();
      Console.WriteLine("\n\nExecuting Program 29\n");
      PrintFibonacciSeries();// something wron
    }
  }

}