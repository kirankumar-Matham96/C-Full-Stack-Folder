class ClassWork5
{

  /* menu with switch */
  public static void ManaHoteWithlSwitchCase()
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

    switch (choice)
    {
      case 1:
        item = "Iddli"; cost = iddliCost;
        break;
      case 2:
        item = "Dosa"; cost = dosaCost;
        break;
      case 3:

        item = "Vada"; cost = vadaCost;
        break;
      case 4:
        item = "Puri"; cost = puriCost;
        break;
      default:
        Console.WriteLine("Invalid Option!");
        return;
    }

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

  /* Sub menu with nested switch */
  public static void ManaHoteWithlSubMenu()
  {
    Console.WriteLine("Welcome to My Hotel!");

    double iddliCost = 35.00;
    double vadaCost = 40.00;
    double dosaCost = 40.00;
    double puriCost = 45.00;
    double vegBiryaniCost = 250.00;
    double chapathiWithVegCurryCost = 150.00;
    double eggMasalaCost = 100.00;
    double chickenThanduriCost = 200.00;
    double wholeRoastChickenCost = 350.00;
    double chickenBiryaniCost = 300.00;
    double rabbitBiryaniCost = 500.00;
    double chapathiWithChickenCurryCost = 200.00;
    double crispyCornCost = 120.00;
    double chicken65Cost = 150.00;
    double panneer65Cost = 100.00;
    double panneerTickaCost = 100.00;
    double cricpyMushroomCost = 130.00;
    double gulabJamunCost = 120.00;
    double appricotDelightCost = 250.00;
    double seviyaanKheerCost = 200.00;
    double rasmalaiCost = 150.00;
    double gajarKaHalwaCost = 150.00;
    double kulfiCost = 80.00;
    double totalCost = 0;
    string orders = "";
    int discount = 20;
    double discountAmt = 0;
    char isOrdering;
    double finalBill;

    do
    {
      Console.WriteLine($"\nOur Menu: \n\t1. Vegitarian\n\t2. Non-Vegitarian\n\t3. Starters\n\t4. Desserts");
      Console.Write("\nPlease select your option: ");
      int mainOption = Convert.ToInt32(Console.ReadLine());

      switch (mainOption)
      {
        case 1:
          Console.WriteLine($"\nVeg Menu:\n\t1. Iddli\t\t   ---\t{iddliCost}\n\t2. Vada\t\t\t   ---\t{vadaCost}\n\t3. Dosa\t\t\t   ---\t{dosaCost}\n\t4. Puri\t\t\t   ---\t{puriCost}\n\t5. Veg Biryani\t\t   ---\t{vegBiryaniCost}\n\t6. Chapathi with veg curry ---\t{chapathiWithVegCurryCost}");
          Console.Write("\nPlease select your order: ");
          int vegOrder = Convert.ToInt32(Console.ReadLine());
          switch (vegOrder)
          {
            case 1:
              Console.WriteLine("Your Order is: Iddli");
              Console.WriteLine($"Order Cost: {iddliCost}");
              orders += $"Iddli\t\t\t--- {iddliCost}\n";
              totalCost += iddliCost;
              break;
            case 2:
              Console.WriteLine("Your Order is: Vada");
              Console.WriteLine($"Order Cost: {vadaCost}");
              orders += $"Vada\t\t\t--- {vadaCost}\n";
              totalCost += vadaCost;
              break;
            case 3:
              Console.WriteLine("Your Order is: Dosa");
              Console.WriteLine($"Order Cost: {dosaCost}");
              orders += $"Dosa\t\t\t--- {dosaCost}\n";
              totalCost += dosaCost;
              break;
            case 4:
              Console.WriteLine("Your Order is: Puri");
              Console.WriteLine($"Order Cost: {puriCost}");
              orders += $"Puri\t\t\t--- {puriCost}\n";
              totalCost += puriCost;
              break;
            case 5:
              Console.WriteLine("Your Order is: Veg Biryani");
              Console.WriteLine($"Order Cost: {vegBiryaniCost}");
              orders += $"Veg Biryani\t\t--- {vegBiryaniCost}\n";
              totalCost += vegBiryaniCost;
              break;
            case 6:
              Console.WriteLine("Your Order is: Chapathi with Veg Curry");
              Console.WriteLine($"Order Cost: {chapathiWithVegCurryCost}");
              orders += $"Chapathi with Veg Curry\t--- {chapathiWithVegCurryCost}\n";
              totalCost += chapathiWithVegCurryCost;
              break;
            default:
              Console.WriteLine("Invalid option! Try again...");
              break;
          }
          break;
        case 2:
          Console.WriteLine($"\nNon-Veg Menu:\n\t1. Egg Masala\t---\t{eggMasalaCost}\n\t2. Chicken Thanduri\t---\t{chickenThanduriCost}\n\t3. Whole roast chicken\t---\t{wholeRoastChickenCost}\n\t4. Chicken Biryani\t---\t{chickenBiryaniCost}\n\t5. Rabbit Biryani\t---\t{rabbitBiryaniCost}\n\t6. Chapathi with Chicken curry\t---\t{chapathiWithChickenCurryCost}");
          Console.Write("\nPlease select your order: ");
          int nonVegOrder = Convert.ToInt32(Console.ReadLine());
          switch (nonVegOrder)
          {
            case 1:
              Console.WriteLine("Your Order is: Iddli");
              Console.WriteLine($"Order Cost: {eggMasalaCost}");
              orders += $"Egg Masala\t\t    --- {eggMasalaCost}\n";
              totalCost += eggMasalaCost;
              break;
            case 2:
              Console.WriteLine("Your Order is: Vada");
              Console.WriteLine($"Order Cost: {chickenThanduriCost}");
              orders += $"Chicken Thanduri\t    --- {chickenThanduriCost}\n";
              totalCost += chickenThanduriCost;
              break;
            case 3:
              Console.WriteLine("Your Order is: Dosa");
              Console.WriteLine($"Order Cost: {wholeRoastChickenCost}");
              orders += $"Whole Roast Chicken\t    --- {wholeRoastChickenCost}\n";
              totalCost += wholeRoastChickenCost;
              break;
            case 4:
              Console.WriteLine("Your Order is: Puri");
              Console.WriteLine($"Order Cost: {chickenBiryaniCost}");
              orders += $"Chicken Biryani\t\t    --- {chickenBiryaniCost}\n";
              totalCost += chickenBiryaniCost;
              break;
            case 5:
              Console.WriteLine("Your Order is: Veg Biryani");
              Console.WriteLine($"Order Cost: {rabbitBiryaniCost}");
              orders += $"Rabbit Biryani\t\t    --- {rabbitBiryaniCost}\n";
              totalCost += rabbitBiryaniCost;
              break;
            case 6:
              Console.WriteLine("Your Order is: Chapathi with Veg Curry");
              Console.WriteLine($"Order Cost: {chapathiWithChickenCurryCost}");
              orders += $"Chapathi with Chicken Curry --- {chapathiWithChickenCurryCost}\n";
              totalCost += chapathiWithChickenCurryCost;
              break;
            default:
              Console.WriteLine("Invalid option! Try again...");
              break;
          }
          break;
        case 3:
          Console.WriteLine($"\nStarters Menu:\n\t1. Crispy Corn\t---\t{crispyCornCost}\n\t2. Chicket 65\t---\t{chicken65Cost}\n\t3. Panneer 65\t---\t{panneer65Cost}\n\t4. Panneer Tikka\t---\t{panneerTickaCost}\n\t5. Crispy Mashroom\t---\t{cricpyMushroomCost}");
          Console.Write("\nPlease select your order: ");
          int startersOrder = Convert.ToInt32(Console.ReadLine());
          switch (startersOrder)
          {
            case 1:
              Console.WriteLine("Your Order is: Iddli");
              Console.WriteLine($"Order Cost: {crispyCornCost}");
              orders += $"Crispy Corn\t\t   ---\t{crispyCornCost}\n";
              totalCost += crispyCornCost;
              break;
            case 2:
              Console.WriteLine("Your Order is: Vada");
              Console.WriteLine($"Order Cost: {chicken65Cost}");
              orders += $"Chicken65\t\t   ---\t{chicken65Cost}\n";
              totalCost += chicken65Cost;
              break;
            case 3:
              Console.WriteLine("Your Order is: Dosa");
              Console.WriteLine($"Order Cost: {panneer65Cost}");
              orders += $"Panneer65\t\t   ---\t{panneer65Cost}\n";
              totalCost += panneer65Cost;
              break;
            case 4:
              Console.WriteLine("Your Order is: Puri");
              Console.WriteLine($"Order Cost: {panneerTickaCost}");
              orders += $"Panneer Ticka\t\t   ---\t{panneerTickaCost}\n";
              totalCost += panneerTickaCost;
              break;
            case 5:
              Console.WriteLine("Your Order is: Veg Biryani");
              Console.WriteLine($"Order Cost: {cricpyMushroomCost}");
              orders += $"Cricpy Mushroom\t\t   ---\t{cricpyMushroomCost}\n";
              totalCost += cricpyMushroomCost;
              break;
            default:
              Console.WriteLine("Invalid option! Try again...");
              break;
          }
          break;
        case 4:
          Console.WriteLine($"\nDessert Menu:\n\t1. Gulab Jamun\t---\t{gulabJamunCost}\n\t2. Apprecot Delight\t---\t{appricotDelightCost}\n\t3. Seviyaan Kheer\t---\t{seviyaanKheerCost}\n\t4. Rasmalai\t---\t{rasmalaiCost}\n\t5. Gajar Ka Halwa\t---\t{gajarKaHalwaCost}\n\t6. Kulfi\t---\t{kulfiCost}");
          Console.Write("\nPlease select your order: ");
          int dessertOrder = Convert.ToInt32(Console.ReadLine());
          switch (dessertOrder)
          {
            case 1:
              Console.WriteLine("Your Order is: Iddli");
              Console.WriteLine($"Order Cost: {gulabJamunCost}");
              orders += $"Gulab Jamun\t\t   ---\t{gulabJamunCost}\n";
              totalCost += gulabJamunCost;
              break;
            case 2:
              Console.WriteLine("Your Order is: Vada");
              Console.WriteLine($"Order Cost: {appricotDelightCost}");
              orders += $"Appricot Delight\t\t   ---\t{appricotDelightCost}\n";
              totalCost += appricotDelightCost;
              break;
            case 3:
              Console.WriteLine("Your Order is: Dosa");
              Console.WriteLine($"Order Cost: {seviyaanKheerCost}");
              orders += $"Seviyaan Kheer\t\t   ---\t{seviyaanKheerCost}\n";
              totalCost += seviyaanKheerCost;
              break;
            case 4:
              Console.WriteLine("Your Order is: Puri");
              Console.WriteLine($"Order Cost: {rasmalaiCost}");
              orders += $"Rasmalai\t\t   ---\t{rasmalaiCost}\n";
              totalCost += rasmalaiCost;
              break;
            case 5:
              Console.WriteLine("Your Order is: Veg Biryani");
              Console.WriteLine($"Order Cost: {gajarKaHalwaCost}");
              orders += $"Gajar Ka Halwa\t\t   ---\t{gajarKaHalwaCost}\n";
              totalCost += gajarKaHalwaCost;
              break;
            case 6:
              Console.WriteLine("Your Order is: Chapathi with Veg Curry");
              Console.WriteLine($"Order Cost: {kulfiCost}");
              orders += $"Kulfi\t\t   ---\t{kulfiCost}\n";
              totalCost += kulfiCost;
              break;
            default:
              Console.WriteLine("Invalid option! Try again...");
              break;
          }
          break;
        default:
          Console.WriteLine("Invalid option! Try again...");
          break;
      }

      Console.Write("\nDo you want to order anything else? (y/n): ");
      isOrdering = Convert.ToChar(Console.ReadLine().ToLower());
    } while (isOrdering == 'y');

    if (totalCost >= 1000) discountAmt = totalCost * discount / 100;
    finalBill = totalCost - discountAmt;
    Console.WriteLine($"\nYour orders: \n{orders}");
    Console.WriteLine($"Total Bill: {totalCost}\nDiscount Amount: {discountAmt}\nYour final bill: {finalBill}");
    Console.WriteLine("Thank you for visiting our hotel! Please visit again!");
  }

  /* w.a.p to print 1 to n even numbers */
  public static void PrintNNumbers()
  {
    Console.Write("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
      if (i % 2 == 0) Console.WriteLine($"Sum of numbers: {i}");
    }
  }

  /* w.a.p to print n to 1 numbers */
  public static void PrintNNumbersInReverse()
  {
    Console.Write("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());

    for (int i = n; i >= 1; i--)
    {
      Console.WriteLine(i);
    }
  }

  /* w.a.p to find sum of 1 to n even numbers */
  public static void PrintSumOfNEvenNumbers()
  {
    Console.Write("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    for (int i = 1; i <= n; i++)
    {
      if (i % 2 == 0) sum += i;
    }
    Console.WriteLine($"Sum of {n} even numbers: {sum}");
  }

  /* w.a.p to find product of 1 to n numbers */
  public static void PrintProductOfNNumbers()
  {
    Console.Write("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int prod = 1;

    for (int i = 1; i <= n; i++)
    {
      prod *= i;
    }
    Console.WriteLine($"Product of {n} numbers: {prod}");
  }

  /* w.a.p to print 1 to n, 5 divisibles */
  public static void Print5DivisiblesOfNNumbers()
  {
    Console.Write("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("5's divisibles: ");
    for (int i = 1; i <= n; i++)
    {
      if (i % 5 == 0) Console.WriteLine(i);
    }
  }

  /* w.a.p to print 1 to n odd, even numbers */
  public static void PrintNOddEvenNumbers()
  {
    Console.Write("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Odd\tEven");
    for (int i = 1; i <= n; i++)
    {
      if (i % 2 != 0) Console.Write(i);
      else Console.Write($"\t{i}\n");
    }
  }

  /* w.a.p to read start, end numbers then print all numbers */
  public static void PrintNumbers()
  {
    Console.Write("Enter starting number: ");
    int start = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter ending number: ");
    int end = Convert.ToInt32(Console.ReadLine());

    for (int i = start; i <= end; i++)
    {
      Console.Write($"{i}\t");
    }
  }



  public static void Main(string[] args)
  {
    Console.WriteLine("******************* This is class 5 tasks *******************");
    // ManaHoteWithlSwitchCase();
    // ManaHoteWithlSubMenu();

    // PrintNNumbers();
    // PrintNNumbersInReverse();
    // PrintSumOfNEvenNumbers();
    // PrintProductOfNNumbers();
    // Print5DivisiblesOfNNumbers();
    // PrintNOddEvenNumbers();
    PrintNumbers();
  }
}