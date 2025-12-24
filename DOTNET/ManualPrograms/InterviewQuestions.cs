namespace ManualProgramms
{
  static class InterviewQuestions
  {

    // w.a.p. to count number of 2's present in b/w 1 to n
    public static void Display2sCount()
    {
      Console.Write("Enter a number: ");
      int n = Convert.ToInt32(Console.ReadLine());
      int count = 0;

      for (int i = 1; i <= n; i++)
      {
        int temp = i, rem;

        while (temp > 0)
        {
          rem = temp % 10;
          temp /= 10;

          if (rem == 2) count++;
        }
      }
      Console.WriteLine($"The 2's in between 1 and {n} are: {count}");
    }

    /* w.a.p. to print next found highest number which is less than given number
       without the digit given by user.

       Ex: n = 2345
       d = 4
       o/p: 2339
    */
    public static void DisplayNextHighestNumberWithoutGivenDigit()
    {
      Console.Write("Enter a number: ");
      int n = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter a digit in the given number: ");
      int digit = Convert.ToInt32(Console.ReadLine());
      // int result;

      while (n > 0)
      {
        bool isDigitFound = false;
        int temp = n, rem = 0;
        while (temp > 0)
        {
          rem = temp % 10;
          temp /= 10;

          if (rem == digit)
          {
            isDigitFound = true;
            break;
          }
        }
        if (!isDigitFound)
        {
          Console.WriteLine($"the second highest digit without the digit {digit} is {n}");
          break;
        }
        n--;
      }
    }

    // w.a.p. to print first consecutive composit numbers in given series
    public static void DisplayFistNConsecutiveCompositNumbers()
    {
      Console.Write("Enter a number: ");
      int n = Convert.ToInt32(Console.ReadLine());

      Console.Write($"{1} ");
      for (int i = 1; i <= n; i++)
      {
        for (int j = 2; j <= i / 2; j++)
        {
          if (i % j == 0)
          {
            Console.Write($"{i} ");
            break;
          }
        }
      }

    }

    public static void RunTests()
    {
      // Display2sCount();
      // DisplayNextHighestNumberWithoutGivenDigit();
      DisplayFistNConsecutiveCompositNumbers();
    }

  }
}