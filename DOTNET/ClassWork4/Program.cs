namespace ClassWork4
{
  class ClassWork4Tasks
  {

    /* 1. Student Result Program
       --> W.A.P to read 3 subject marks, then check student is PASS/FAIL.
       --> If PASS then only find Total, Avg, Grade.
       --> Otherwise display message as 'Better Luck Next Time'.
    */
    public static void IsPass()
    {
      Console.Write("Enter s1 marks: ");
      int s1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter s2 marks: ");
      int s2 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter s3 marks: ");
      int s3 = Convert.ToInt32(Console.ReadLine());

      int total = 0;
      double avg;
      char grade = 'D';

      if (s1 >= 35 && s2 >= 35 && s3 >= 35)
      {
        total = s1 + s2 + s3;
        avg = total / 3;

        if (avg > 90) grade = 'A';
        else if (avg > 70 && avg < 89) grade = 'B';
        else if (avg > 50 && avg < 69) grade = 'C';
        else if (avg >= 35 && avg < 49) grade = 'D';

        Console.WriteLine($"Total Marks: {total}\n Average: {avg}\nGrade: {grade}");
      }
      else
      {
        Console.WriteLine("Better Luck Next Time");
      }
    }

    /* 2. ATM Pin Validation
       --> Consider user pin number is 1122, customer has 5000 amount in his Account.
       --> Read pin number from user.
       --> If pin is correct → read Withdraw amount and update balance.
    */
    public static void WithdrawFromATM()
    {
      int pin = 1122;
      double bal = 5000, amt;

      Console.Write("Enter Pin: ");
      int userPin = Convert.ToInt32(Console.ReadLine());

      if (pin == userPin)
      {
        Console.Write("Enter the Amount to withdraw: ");
        amt = Convert.ToDouble(Console.ReadLine());

        if (amt > bal) Console.WriteLine("Insufficient balance");
        else bal -= amt;
      }
    }

    /* 3. Number to Word (1 to 3 only)
       --> If user enters 1 → Output: One
       --> If user enters 2 → Output: Two
       --> If user enters 3 → Output: Three
       --> Otherwise → Output: Invalid Number
    */
    public static void NumberToWord()
    {
      Console.Write("Enter a number: ");
      int num = Convert.ToInt32(Console.ReadLine());

      if (num != 1 && num != 2 && num != 3) Console.WriteLine("Invalid Number");
      if (num == 1) Console.WriteLine("ONE");
      if (num == 2) Console.WriteLine("TWO");
      if (num == 3) Console.WriteLine("THREE");
    }

    /* 4. Electricity Bill Calculator
       --> If units ≤ 100 → ₹1.5/unit
       --> If units ≤ 200 → ₹2.5/unit
       --> If units ≤ 300 → ₹4/unit
       --> Else → ₹6/unit
       --> Write a program to accept units and print the total bill.
    */
    public static void CalculateElectricityBill()
    {
      Console.Write("Enter units: ");
      int units = Convert.ToInt32(Console.ReadLine());
      double bill = 0;

      if (units <= 100) bill = units * 1.5;
      else if (units <= 200) bill = units * 2.5;
      else if (units <= 300) bill = units * 4;
      else bill = units * 6;

      Console.WriteLine($"Your electricity bill is: {bill}");
    }

    /* 5. Weather Suggestion Application
       --> If temperature > 35 → "It's too hot, stay indoors."
       --> If temperature > 25 → "Nice weather, go out!"
       --> If temperature > 15 → "Cool weather, wear a jacket."
       --> Else → "Too cold, stay warm."
    */
    public static void WeatherSuggestion()
    {
      int temp;
      string msg;

      Console.Write("Enter the temperaure: ");
      temp = Convert.ToInt32(Console.ReadLine());

      if (temp > 35) msg = "It's too hot, stay indoors.";
      else if (temp > 25) msg = "Nice weather, go out!";
      else if (temp > 15) msg = "Cool weather, wear a jacket.";
      else msg = "Too cold, stay warm.";

      Console.WriteLine(msg);
    }

    /* 6. Health Check Application
       --> If temperature > 99 → "You have fever."
       --> If cough == "yes" → "You might have a cold."
       --> If tiredness == "yes" → "Take some rest."
       --> Write a program to read temperature, cough, tiredness and show all messages.
    */
    public static void CheckHealth()
    {
      string msg = "";

      Console.Write("Enter your temperature: ");
      int temp = Convert.ToInt32(Console.ReadLine());

      Console.Write("Do you have cough (yes/no): ");
      string coughing = (Console.ReadLine()).ToLower();

      Console.Write("Are you feeling tired (yes/no): ");
      string tired = (Console.ReadLine()).ToLower();

      if (temp > 99) msg += "You have fever.";
      if (coughing == "yes") msg += "\nYou migh have a cold.";
      if (tired == "yes") msg += "\nTake some rest.";

      Console.WriteLine(msg);
    }

    /* 7. Job Eligibility Application
       --> If age ≥ 18 → eligible.
       --> If qualification == "graduate" → eligible.
       --> If experience ≥ 2 → preferred.
       --> Write a program to read age, qualification, experience then display message.
    */
    public static void IsEligibleForJob()
    {
      Console.Write("Enter your age: ");
      int age = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter your qualification: ");
      string qualification = Console.ReadLine();

      Console.Write("Enter your experience: ");
      double experience = Convert.ToDouble(Console.ReadLine());

      if (age >= 18 && qualification == "graduate" && experience >= 2) Console.WriteLine("You are eligible for this job");
    }

    /* 8. Loan Eligibility System
      If income ≥ ₹25,000:
        If credit score > 700 → Eligible
        Else → "Improve your credit score."
      Else:
        "Income too low for loan."
    */
    public static void IsEligibleForLoan()
    {
      Console.Write("Enter your income: ");
      double income = Convert.ToDouble(Console.ReadLine());

      Console.Write("Enter your credit score: ");
      int creditScore = Convert.ToInt32(Console.ReadLine());

      if (income >= 25000)
      {
        if (creditScore > 700)
        {
          Console.WriteLine("You are eligible for this load!");
        }
        else { Console.WriteLine("Improve your credit score."); }
      }
      else
      {
        Console.WriteLine("Income too low for loan.");
      }
    }

    /* 9. Driving License Assistant
        If age < 18 → "Not eligible"
        Elif 18–60:
            If vision == "good" AND test == "passed" → "License Approved"
            Else → "Fail in test or vision check"
        Else:
            "Senior citizen — medical check required"
    */
    public static void IsEligibleForDrivingLicence()
    {
      Console.Write("Enter your age: ");
      int age = Convert.ToInt32(Console.ReadLine());

      Console.Write("Disi you have good eye site(yes/no): ");
      string vision = Console.ReadLine().ToLower() == "yes" ? "good" : "bad";

      Console.Write("Disi you pass the test (yes/no): ");
      string test = Console.ReadLine().ToLower() == "yes" ? "passed" : "failed";

      if (age < 18) { }
      else if (age >= 18 && age <= 60)
      {
        if (vision == "good" && test == "passed")
        {
          Console.WriteLine("License Approved");
        }
      }
      else
      {
        Console.WriteLine("Senior citizen — medical check required");
      }
    }

    /* 10. MANA Hotel Program output 
          NOTE: discount is applied as 20% if Total Bill is more than Rs.500/-.

          Welcome To MANA Hotel
          1. Idly  -- 60.0
          2. Dosa  -- 100.0
          3. Vada  -- 150.0
          4. Puri  -- 120.0

          case1:
            Enter your choice : 2
            Item Name is : Dosa
            Cost is : 100.0
            Enter Quantity : 6
            Bill Amount is : 600.0
            Discount is : 20%
            Discount Amt : 120.0
            Final Bill is : 480.0
            Paid Amount : 500.0
            Balance is : 20.0

          case2:
            Enter your choice : 6
            Sorry..! Invalid Choice
          
          case3:
            Enter your choice : 1
            Itemname : Idly
            Cost is : 60.0
            Enter Quantity : 2
            Bill Amount is : 120.0
            Discount is : 0%
            Discount Amt : 0.0
            Final Bill is : 120.0
            Paid Amount : 200.0
            Balance is : 80.0
    */
    public static void ManaHotel()
    {
      Console.WriteLine("\nWelcome to MANA Hotel\n");

      double iddliCost = 60.00;
      double dosaCost = 100.00;
      double vadaCost = 150.00;
      double puriCost = 120.00;
      double cost = 0;

      string item = "";

      Console.WriteLine($"1.Iddli --- {iddliCost}\n2.Dosa --- {dosaCost}\n3.Vada --- {vadaCost}\n4.Puri --- {puriCost}");
      
      Console.Write("\nEnter your choice: ");
      int choice = Convert.ToInt32(Console.ReadLine());
      
      if (choice == 1) { item = "Iddli"; cost = iddliCost; }
      else if (choice == 2) { item = "Dosa"; cost = dosaCost; }
      else if (choice == 3) { item = "Vada"; cost = vadaCost; }
      else if (choice == 4) { item = "Puri"; cost = puriCost; }
      else { Console.WriteLine("Invalid choice"); return; }
      Console.WriteLine($"Item Name: {item}");

      Console.Write("Enter quantity: ");
      int qty = Convert.ToInt32(Console.ReadLine());

      double billAmt = cost * qty;
      Console.WriteLine($"Bill Amount is: {billAmt}");

      int disc = 0;

      if (billAmt >= 500)
      {
        disc = 20;
      }

      double discAmt = billAmt * disc / 100;
      Console.WriteLine($"Discount Amount: {discAmt}");

      double finalBill = billAmt - discAmt;
      Console.WriteLine($"Final Bill Amount: {finalBill}");

      Console.Write("Enter your amount: ");
      double paidAmt = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine($"Paid amount: {paidAmt}");
      Console.WriteLine($"Balance is: {paidAmt - finalBill}");
    }

    /* 11. Home loan application processor */
    public static void HomeLoanProcessor()
    {
      Console.Write("Enter your annual salary: ");
      double annualSal = Convert.ToDouble(Console.ReadLine());
      double monthlySal = annualSal / 12;
      if (monthlySal >= 25000.0)
      {
        Console.Write("Enter your CBIL score: ");
        int cbil = Convert.ToInt32(Console.ReadLine());
        if (cbil >= 750)
        {
          Console.WriteLine("1.Home Loan -- 15.6%\n2.Car Loan -- 12.8%\n3.Personal Loan -- 18.9%");
          Console.Write("Enter your choice: ");
          int choice = Convert.ToInt32(Console.ReadLine());
          double roi = 0;

          switch (choice)
          {
            case 1:
              roi = 15.6;
              break;
            case 2:
              roi = 12.8;
              break;
            case 3:
              roi = 18.9;
              break;
            default:
              roi = 0;
              System.Console.WriteLine("Invalid choice!");
              return;
          }
          Console.WriteLine($"Rate of Interest is: {roi}%");
          Console.Write("Enter Amount: ");
          double amt = Convert.ToDouble(Console.ReadLine());

          Console.Write("Enter Duration in Years: ");
          int duration = Convert.ToInt32(Console.ReadLine());

          double interestAmt = (amt * duration * roi) / 100;
          Console.WriteLine($"Interest Amount: {interestAmt}");
          double finalAmt = amt + interestAmt;

          Console.WriteLine($"Final Amount: {finalAmt}");
          double emiAmt = finalAmt / (duration * 12);
          Console.WriteLine($"EMI Amount: {emiAmt}");
        }
        else
        {
          Console.WriteLine("Sorry! Your CBIL score is very low. Your application is rejected!");
        }
      }
      else
      {
        Console.WriteLine("Sorry! You are not eligible for this loan.");
      }

    }

    public static void Main(string[] args)
    {
      Console.WriteLine("\n********************\nClass Work 12-12-2025\n********************\n");

      // IsPass();
      // WithdrawFromATM();
      // NumberToWord();
      // CalculateElectricityBill();
      // WeatherSuggestion();
      // CheckHealth();
      // IsEligibleForJob();
      // IsEligibleForLoan();
      // IsEligibleForDrivingLicence();
      ManaHotel();
      // HomeLoanProcessor();
    }
  }
}