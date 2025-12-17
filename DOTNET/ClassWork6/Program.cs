class WhileLoop
{

  public static void IsPalindrome()
  {
    Console.Write("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int temp = n, rev = 0, r;

    while (n > 0)
    {
      r = n % 10;
      n /= 10;
      rev = rev * 10 + r;
    }

    if (rev == temp) Console.WriteLine($"{temp} is a palindrome");
    else Console.WriteLine($"{temp} is not a palindrome");
  }

  public static void GetSumOfEvenDigitsInANumber()
  {
    Console.Write("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int r, eSum = 0, temp = n;

    while (n > 0)
    {
      r = n % 10;
      n /= 10;
      if (r % 2 == 0) eSum += r;
    }
    Console.WriteLine($"Sum of even digits in {temp} is: {eSum}");
  }

  public static void GetSumOfEvenAndOddDigits()
  {
    Console.Write("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int r, eSum = 0, oSum = 0;

    while (n > 0)
    {
      r = n % 10;
      n /= 10;
      if (r % 2 == 0) eSum += r;
      else oSum += r;
    }

    System.Console.WriteLine($"Even Sum: {eSum}\nOdd Sum: {oSum}");
  }

  public static void GetNumberOfDigitsInANumber()
  {
    Console.Write("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int digitsCount = 0;

    while (n > 0)
    {
      n /= 10;
      digitsCount++;
    }
    Console.WriteLine($"{digitsCount}");
  }

  public static void GetNumberOfEvenOddDigits()
  {
    Console.Write("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int r, eDigitsCount = 0, oDigitsCount = 0;

    while (n > 0)
    {
      r = n % 10;
      n /= 10;
      if (r % 2 == 0) eDigitsCount++;
      else oDigitsCount++;
    }
    Console.WriteLine($"Even Digits Count: {eDigitsCount}\nOdd Digit Count: {oDigitsCount}");
  }

  public static void SumOfDigitsExceptFirstAndLastDigitsInANumber1()
  {
    Console.Write("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int r, sum = 0, rev = 0, firstLastSum = 0, temp = n;

    while (n > 0)
    {
      r = n % 10;
      n /= 10;
      rev = rev * 10 + r;
      sum += r;
    }

    firstLastSum += temp % 10;
    firstLastSum += rev % 10;

    sum -= firstLastSum;

    Console.WriteLine($"Sum of digits except first and last: {sum}");
  }

  public static void SumOfDigitsExceptFirstAndLastDigitsInANumber2()
  {
    Console.Write("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = 0, firstSum = 0, lastSum = 0, temp = n;

    while (n > 0)
    {
      sum += n % 10;
      n /= 10;
    }

    firstSum += Convert.ToInt32(temp.ToString()[0].ToString());
    lastSum += temp % 10;

    sum -= (firstSum + lastSum);

    Console.WriteLine($"Sum of digits except first and last: {sum}");
  }

  public static void SumOfDigitsExceptFirstAndLastDigitsInANumber3()
  {
    Console.Write("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = 0, firstSum = 0, lastSum = 0, temp = n;

    while (n > 0)
    {
      sum += n % 10;
      n /= 10;
    }

    firstSum += temp;
    while (firstSum > 9) firstSum /= 10;

    lastSum += temp % 10;

    sum -= (firstSum + lastSum);

    Console.WriteLine($"Sum of digits except first and last: {sum}");
  }

  public static void Main(string[] args)
  {
    Console.WriteLine("\n******************** This is Class 6 ********************\n");

    // IsPalindrome();
    // GetSumOfEvenDigitsInANumber();
    // GetSumOfEvenAndOddDigits();
    // GetNumberOfDigitsInANumber();
    // GetNumberOfEvenOddDigits();
    // SumOfDigitsExceptFirstAndLastDigitsInANumber1();
    // SumOfDigitsExceptFirstAndLastDigitsInANumber2();
    SumOfDigitsExceptFirstAndLastDigitsInANumber3();
  }
}