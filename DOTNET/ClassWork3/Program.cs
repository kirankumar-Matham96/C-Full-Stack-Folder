using System.Runtime.InteropServices;

namespace ClassWork3OnConditionalStatements
{
  class ConditionalStatements
  {

    // 1. w.a.p to take 2 numbers and print biggest number
    public static void PrintBiggest()
    {
      Console.Write("Enter first number: ");
      int num1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter second number: ");
      int num2 = Convert.ToInt32(Console.ReadLine());

      if (num1 > num2) Console.WriteLine($"{num1} is greater than {num2}");
      else if (num1 < num2) Console.WriteLine($"{num2} is greater than {num1}");
      else Console.WriteLine($"{num2} and {num1} are equal");
    }

    /* 2. w.a.p. to ead user name and password. Then check if user is valid:
          username = venkat and password = sathya
    */
    public static void IsValidUser()
    {
      Console.Write("Enter username: ");
      string uname = Console.ReadLine();
      Console.Write("Enter password: ");
      string pwd = Console.ReadLine();

      if (uname == "venkat" && pwd == "sathya") Console.WriteLine("Valid user");
      else Console.WriteLine("Invalid user");
    }


    /* 3. Customer has 6000 balance.
          --> Read the amt from user and update the balance
          --> If the user entered invalidinput, show message: "Sorry..! Insufficient balance."
    */
    public static void Withdraw()
    {
      Console.Write("Enter the amount to withdraw: ");
      double amt = Convert.ToDouble(Console.ReadLine());
      double bal = 6000;

      if (bal < amt) Console.WriteLine("Sorry..! Insufficient balance.");
      else bal -= amt;

      System.Console.WriteLine($"Your current balance is {bal}");
    }

    /* 4. w.a.p. to read temperature, then check normal day or hot day
          --> temp > 35 = hot day    
    */
    public static void IsHotDay()
    {
      Console.Write("Enter temperature: ");
      double temp = Convert.ToDouble(Console.ReadLine());

      if (temp > 35) Console.WriteLine("Hot Day");
      else Console.WriteLine("Normal Day");
    }

    // 5. w.a.p. to check if a person is adult by reading age
    public static void IsMajorOrMinor()
    {
      Console.Write("Enter your age: ");
      int age = Convert.ToInt32(Console.ReadLine());

      if (age >= 18) Console.WriteLine("Major");
      else Console.WriteLine("Minor");
    }

    // 6. w.a.p to find a number is divisible by both 3 and 5
    public static void IsDivisibleBy3And5()
    {
      Console.Write("Enter a number: ");
      int num = Convert.ToInt32(Console.ReadLine());

      if (num % 3 == 0 && num % 5 == 0) Console.WriteLine($"{num} is divisible by both 3 and 5");
      else Console.WriteLine($"{num} is not divisible by both 3 and 5");
    }

    /* 7. w.a.p to find travel cost based on distance
        Rs.10 --> <= 10km
        Rs.8  --> > 10km
    */
    public static void CalculateTravelCost()
    {
      Console.Write("Enter the distance travelled: ");
      double distance = Convert.ToDouble(Console.ReadLine());
      double cost = 0;

      if (distance > 10) cost += 8 * distance;
      else cost += 10 * distance;

      Console.WriteLine($"Total traveling cost id: {cost}");
    }

    /* 8. W.a.p to read subject marks from user, in-case user enter a value less than 0 or greater than 100
       then only display message as "Invalid Marks" otherwise don’t display any message.
    */
    public static void ValidateMarks()
    {
      Console.Write("Enter Marks: ");
      int marks = Convert.ToInt32(Console.ReadLine());

      if (marks < 0 || marks > 100)
      {
        Console.WriteLine("Invalid Marks");
      }
    }

    /* 9. W.a.p to Read Product cost, quantity then find bill Amount.
       In case bill amount crossed 5000 then provide 20% discount on bill amount,
       then display Bill Amount, Discount, Discount Amount and Final Bill
    */
    public static void CalculateFinalBill()
    {
      int disc = 0, qty;
      double discAmt = 0, cost, bill = 0, finalBill = 0;

      Console.Write("Enter the product cost: ");
      cost = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter the quantity: ");
      qty = Convert.ToInt32(Console.ReadLine());

      bill = cost * qty;

      if (bill > 5000)
      {
        disc = 20;
        discAmt = bill * disc / 100;
      }


      finalBill = bill - discAmt;

      Console.WriteLine($"Bill: {bill}");
      Console.WriteLine($"Discount: {disc}");
      Console.WriteLine($"Discount Amount: {discAmt}");
      Console.WriteLine($"Final bill: {finalBill}");
    }

    /* 3. W.a.p to read Employee annual salary, in-case employee monthly salary is more than or equal to 50000
       then they have to pay 12% tax. Otherwise no tax.
       So display Monthly salary of an employee
    */
    public static void CalculateMonthlySalary()
    {
      Console.Write("Enter annual salary: ");
      double annualSal = Convert.ToDouble(Console.ReadLine());
      int tax = 12;
      double monthlySal, taxAmt;

      monthlySal = annualSal / 12;

      if (monthlySal >= 50000)
      {
        taxAmt = annualSal * tax / 100;
        annualSal -= taxAmt;
        monthlySal = annualSal / 12;
      }

      Console.WriteLine($"Your monthly salary is: {monthlySal}");
    }

    /* 4. Write a Program to develop application as Amazon provide 15% discount for ICICI card holders,
       now read product cost, quantity then find bill amount
    */
    public static void CalculateFinalBillByCard()
    {
      string expectedCard = "icici";
      int disc = 15;
      double discAmt = 0, bill = 0, finalBill;

      Console.Write("Enter the cost: ");
      double cost = Convert.ToDouble(Console.ReadLine());

      Console.Write("Enter the quantity: ");
      int qty = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter your card/bank name: ");
      string card = (Console.ReadLine()).ToLower();

      bill = cost * qty;

      if (card == expectedCard) discAmt = bill * disc / 100;

      finalBill = bill - discAmt;
      Console.WriteLine($"Final Bill is: {finalBill}");
    }
    /* 5. In RedBus, read ticket cost, no. of tickets then find bill amount.
       Ask user for coupon code, in-case if they enter “SAVE20” then provide 20% discount on bill amount.
       Then Find Final Bill.
    */
    public static void CalculateFinalTravellingCharges()
    {
      double cost = 0, bill = 0, discAmt = 0, finalBill = 0;
      int qty = 0, disc = 20;
      string expectedCouponCode = "SAVE20", couponCode = "";

      Console.Write("Enter the cost of the ticket: ");
      cost = Convert.ToDouble(Console.ReadLine());

      Console.Write("Enter the quatity: ");
      qty = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the coupon code: ");
      couponCode = Console.ReadLine().ToUpper();

      bill = cost * qty;
      if (couponCode == expectedCouponCode) discAmt = cost * disc / 100;
      finalBill = bill - discAmt;

      Console.WriteLine($"Your Final Bill is: {finalBill}");
    }


    /* 6. W.a.p to read age in-case age is between 18 to 25 then display you are eligible to apply this job.
       Otherwise display message as "Sorry Invalid Age"
    */
    public static void IsEligibleForJob()
    {
      Console.Write("Enter your age: ");
      int age = Convert.ToInt32(Console.ReadLine());

      if (age >= 18 && age <= 25) Console.WriteLine("You are eligible to apply for this job");
      else Console.WriteLine("Sorry Invalid Age");
    }

    //  7. W.a.p to read 3 numbers then print biggest number
    public static void FindBiggestOf3()
    {
      int a, b, c;

      Console.Write("Enter num1: ");
      a = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter num2: ");
      b = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter num3: ");
      c = Convert.ToInt32(Console.ReadLine());

      if (a > b && a > c) Console.WriteLine($"{a} is the biggest");
      else if (b > a && b > c) Console.WriteLine($"{b} is the biggest");
      else if (c > b && c > a) Console.WriteLine($"{c} is the biggest");
      else Console.WriteLine($"invalid numbers");

    }


    public static void Main(string[] args)
    {
      Console.WriteLine("\n*******************\nThis is Conditional statement related assignment\n*******************\n");

      // PrintBiggest();
      // IsValidUser();
      // Withdraw();
      // IsHotDay();
      // IsMajorOrMinor();
      // IsDivisibleBy3And5();
      // CalculateTravelCost();
      // ValidateMarks();
      // CalculateFinalBill();
      // CalculateMonthlySalary();
      // CalculateFinalBillByCard();
      // CalculateFinalTravellingCharges();
      // IsEligibleForJob();
      FindBiggestOf3();
    }
  }
}