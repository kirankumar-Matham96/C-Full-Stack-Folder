namespace ManualPrograms
{
  public class RangeBasedQuestions
  {
    // 1Q: Print all even numbers in a given range
    public static void PrintEvenNumbers()
    {
      Console.Write("Enter starting number: ");
      int start = int.Parse(Console.ReadLine());
      Console.Write("Enter ending number: ");
      int end = int.Parse(Console.ReadLine());
      for (int i = start; i <= end; i++)
      {
        if (i % 2 == 0)
        {
          Console.WriteLine(i);
        }
      }
    }

    // print factorial for numbers from 2 to 7
    public static void PrintFactorialsFrom2To7()
    {
      for (int i = 2; i <= 7; i++)
      {
        int fact = 1;
        for (int j = 1; j <= i; j++)
        {
          fact *= i;
        }
        Console.WriteLine($"{i} factorial is: {fact}");
      }
      Console.WriteLine();
    }

    // display multiplication tables in a given range
    public static void PrintMultiplicationTables()
    {
      Console.Write("Enter starting number: ");
      int start = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter ending number: ");
      int end = Convert.ToInt32(Console.ReadLine());

      for (int i = start; i <= end; i++)
      {
        for (int j = 1; j <= 10; j++)
        {
          Console.WriteLine($"{i} X {j} = {i * j}");
        }
        Console.WriteLine();
      }

    }

    // Display prime numbers in a given range 
    public static void PrintPrimeNumers()
    {
      Console.Write("Enter starting number: ");
      int start = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter ending number: ");
      int end = Convert.ToInt32(Console.ReadLine());

      for (int i = start; i < end; i++)
      {
        bool isPrime = true;
        for (int j = 2; j <= i / 2; j++)
        {
          if (i % j == 0)
          {
            isPrime = false;
            break;
          }
        }
        if (isPrime) Console.Write($"{i} ");
      }
    }

    /* Display perfect numbers in a given range
        Perfect Number: Sum of factors of a number except the number itself should be eaqual to the number itself.
    */
    public static void PrintPerfectNumbers()
    {
      Console.Write("Enter starting number: ");
      int start = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter ending number: ");
      int end = Convert.ToInt32(Console.ReadLine());

      for (int i = start; i <= end; i++)
      {
        int sum = 0;
        for (int j = 1; j < i; j++)
        {
          if (i % j == 0) sum += j;
        }
        if (sum == i) Console.Write($"{i} ");
      }
    }

    public static void RunTests()
    {
      PrintEvenNumbers();
      PrintFactorialsFrom2To7();
      PrintMultiplicationTables();
      PrintPrimeNumers();
      PrintPerfectNumbers();
    }
  }
}