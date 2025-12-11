using System.Net.Quic;

namespace ClassworkOperators
{
  class Operators
  {
    /*
      1. W.a.p to read subject marks from user, in-case user enters a value less than 0 or greater than 100 then only
         display message as 'Invalid Marks' otherwise don’t display any message.
    */
    public static void ValidateMarks()
    {
      Console.Write("Enter the subject marks: ");
      int marks = Convert.ToInt32(Console.ReadLine());

      if (marks < 0 || marks > 100) Console.WriteLine("Invalid Marks");
    }

    /*
      2. W.a.p to Read Product cost, quantity then find bill Amount. In case bill amount crosses 5000 then provide 20% discount on bill amount,
          then display Bill Amount, Discount, Discount Amount and Final Bill.
    */
    public static void CalculateBill()
    {
      System.Console.Write("Enter the product cost: ");
      double cost = Convert.ToDouble(Console.ReadLine());

      System.Console.Write("Enter the quantity: ");
      int qty = Convert.ToInt32(Console.ReadLine());

      double billAmt = cost * qty;

      int disc = 20;
      double dicsAmt = 0;

      double finalBill = billAmt;

      if (billAmt > 5000)
      {
        dicsAmt = billAmt * disc / 100;
        finalBill -= dicsAmt;
      }

      Console.WriteLine($"\nBill Amount: {billAmt}\nDiscount: {disc}%\nDiscount Amount: {dicsAmt}\nFinal Bill: {finalBill}");
    }

    /*
      3. W.a.p to read Employee annual salary, in-case employee monthly salary is more than or equal to 50000 then they have to pay 12% tax. Otherwise no tax.
          So display Monthly salary of an employee.
    */
    public static void CalcuateMonthlySalary()
    {
      Console.Write("Enter your annual salary: ");
      double annualSal = Convert.ToDouble(Console.ReadLine());

      int tax = 12;
      double taxAmt = annualSal * tax / 100;
      System.Console.WriteLine($"taxAmt ====> {taxAmt}");
      double monthlySal = annualSal / 12;
      System.Console.WriteLine($"monthlySal without tax ====> {monthlySal}");

      if (monthlySal >= 50000)
      {
        monthlySal = (annualSal - taxAmt) / 12.0;
        System.Console.WriteLine($"monthlySal with tax ====> {monthlySal}");
      }

      Console.WriteLine($"Monthly salary: {monthlySal}");
    }

    /*
      4. Write a Program to develop application as Amazon provide 15% discount for ICICI card holders. Now read product cost, quantity then find bill amount.
    */
    public static void CalcuateFinalBill()
    {
      Console.Write("Enter your card/bank name: ");
      string card = (Console.ReadLine()).ToUpper();
      Console.Write("Enter total amount: ");
      double cost = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter quantity: ");
      int qty = Convert.ToInt32(Console.ReadLine());

      int disc = 15;
      double totalBill = cost * qty;

      if (card == "ICICI")
      {
        double discAmt = totalBill * disc / 100;
        totalBill -= discAmt;
        Console.WriteLine($"You are eligible for the {disc}% discount with {card} card.\nYour final bill: {totalBill}");
      }
      else
      {
        Console.WriteLine($"You are not eligible for the {disc}% discount with {card} card.\nYour final bill: {totalBill}");
      }
    }

    /*
      5. In RedBus, read ticket cost, no. of tickets then find bill amount.
          Ask user for coupon code, in-case if they enter "SAVE20" then provide 20% discount on bill amount then Find Final Bill.
    */
    public static void CalcuateTheBusFare()
    {
      Console.Write("Enter ticket cost: ");
      double ticketPrice = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter number of tickets: ");
      int qty = Convert.ToInt32(Console.ReadLine());

      double totalCost = ticketPrice * qty;

      Console.Write("Enter coupon code: ");
      string couponCode = Console.ReadLine();
      string validCoupon = "SAVE20";
      int disc = 20;

      if (couponCode == validCoupon)
      {
        double discAmt = totalCost * disc / 100;
        totalCost -= discAmt;
      }

      Console.WriteLine($"Final Bill: {totalCost}");
    }

    // 6. W.a.p to read age, in-case age is between 18 to 25 then display you are eligible to apply this job otherwise display message as Sorry Invalid Age.
    public static void IsEligibleForJob()
    {
      Console.Write("Enter your age: ");
      int age = Convert.ToInt32(Console.ReadLine());

      if (age >= 18 && age <= 25) Console.WriteLine("You are eligible for this job!");
      else Console.WriteLine("Sorry! Invalid age");
    }

    // 7. W.a.p to read 3 numbers then print biggest number    
    public static void BiggestOfThreeNumbers()
    {
      Console.Write("Enter first number: ");
      int num1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter second number: ");
      int num2 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter third number: ");
      int num3 = Convert.ToInt32(Console.ReadLine());

      if (num1 > num2 && num1 > num3) Console.WriteLine($"{num1} is the biggest number");
      else if (num2 > num1 && num2 > num3) Console.WriteLine($"{num2} is the biggest number");
      else if (num3 > num1 && num3 > num2) Console.WriteLine($"{num3} is the biggest number");
      else Console.WriteLine($"Duplicate numbers found");
    }

    // 8. W.a.p to read 2 numbers then print biggest number
    public static void BiggestOfTwoNumbers()
    {
      Console.Write("Enter first number: ");
      int num1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter second number: ");
      int num2 = Convert.ToInt32(Console.ReadLine());

      if (num1 > num2) Console.WriteLine($"{num1} is the biggest number");
      else if (num2 > num1) Console.WriteLine($"{num2} is the biggest number");
      else Console.WriteLine($"both are equal");
    }
    /*
      9. W.a.p to read username, password from user then check if user is valid or invalid.
          Note: username is venkat, password is sathya → then valid user, else invalid user.
    */
    public static void ValidateUser()
    {
      Console.Write("Enter user name: ");
      string uname = Console.ReadLine();
      Console.Write("Enter password: ");
      string pwd = Console.ReadLine();

      if (uname == "venkat" && pwd == "sathya") Console.WriteLine("User is valid");
      else Console.WriteLine("User is invalid");
    }

    /*
      10. Consider customer has 6000 amount in his account, now read withdraw amount then update his balance
        → If user enters valid amount then only update balance
        → otherwise display error message as “Sorry..! You have low funds”
    */
    public static void Withdraw()
    {
      double balance = 6000.00;
      Console.Write("Enter the amount to withdraw: ");
      double amt = Convert.ToDouble(Console.ReadLine());

      if (amt <= balance) balance -= amt;
      else Console.WriteLine("Sorry..! You have low funds");

      Console.WriteLine($"Your balance is: {balance}");
    }

    /*
      11. W.a.p to read Temperature then check normal day or hot day
        → Above 35 degrees = hot day
    */
    public static void IsHotDay()
    {
      int thresholdTemp = 35;
      Console.Write("Enter the temperature: ");
      double temp = Convert.ToDouble(Console.ReadLine());

      if (temp > thresholdTemp) Console.WriteLine("It's a hot day!");
      else Console.WriteLine("It's a normal day!");
    }

    // 12. W.a.p to Check if a given year of birth makes a person a minor or adult
    public static void IsAdult()
    {
      Console.Write("Enter your birth year: ");
      int yearOfBirth = Convert.ToInt32(Console.ReadLine());

      if (DateTime.Today.Year - yearOfBirth >= 18) Console.WriteLine("Major");
      else Console.WriteLine("Minor");
    }


    // 13. W.a.p to Find whether a given number is divisible by both 3 and 5
    public static void IsDivisibleBy3And5()
    {
      Console.Write("Enter a number: ");
      int num = Convert.ToInt32(Console.ReadLine());

      if (num % 3 == 0 && num % 5 == 0) Console.WriteLine($"{num} is divisible by 3 and 5");
      else Console.WriteLine($"{num} is not divisible by both 3 and 5");
    }


    /*
      14. W.a.p to find travel cost based on distance
        (e.g., ₹10 per km if ≤ 10 km, else ₹8 per km)
    */
    public static void CalculateTravelCost()
    {
      Console.Write("Enter distance travelled: ");
      double distance = Convert.ToDouble(Console.ReadLine());
      double cost = 0;

      if (distance <= 10)
      {
        cost = distance * 10;
      }
      else
      {
        cost = distance * 8;
      }

      Console.WriteLine($"The traveling cost would be: {cost}");
    }

    // 15. W.a.p to find given year is leap year or not
    public static void IsLeapYear()
    {
      Console.Write("Enter the year: ");
      int year = Convert.ToInt32(Console.ReadLine());

      if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) Console.WriteLine($"{year} is a leap year");
      else Console.WriteLine($"{year} is not a leap year");
    }


    public static void Main(string[] args)
    {
      Console.WriteLine("\n\nThis is class work on operators\n\n");

      // ValidateMarks();
      // CalculateBill();
      // CalcuateMonthlySalary();
      // CalcuateFinalBill();
      // CalcuateTheBusFare();
      // IsEligibleForJob();
      // BiggestOfThreeNumbers();
      // BiggestOfTwoNumbers();
      // ValidateUser();
      // Withdraw();
      // IsHotDay();
      // IsAdult();
      // IsDivisibleBy3And5();
      // CalculateTravelCost();
      IsLeapYear();
    }
  }
}