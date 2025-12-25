namespace PersonalPractice
{
  class Methods
  {
    public static void Sample(string param1, string param2, string param3)
    {
      Console.WriteLine($" Input params: {param1}, {param2}, {param3}");
    }
    public static void Run()
    {
      // The parameters can be passed as key value pairs when the order of the method params are not matched
      Sample(param2: "Second Param", param3: "Third Param", param1: "First Param");
    }
  }
}