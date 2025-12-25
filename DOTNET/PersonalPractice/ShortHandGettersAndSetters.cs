namespace PersonalPractice
{
  class ShortHandGettersAndSetters
  {
    // shorthand setters and getters: "Auto Implemented Properties"
    private int _secretNumber { get; set; }
    private string _password { get; set; }

    public static void Run()
    {
      // shorthand setters and getters
      ShortHandGettersAndSetters p = new ShortHandGettersAndSetters();
      p._secretNumber = 12532;
      Console.WriteLine($"Secret Number: {p._secretNumber}");

      p._password = "@QAwsjld41sdnhdc!";
      Console.WriteLine($"Password: {p._password}");
    }
  }
}