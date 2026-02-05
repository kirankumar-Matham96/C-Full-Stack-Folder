namespace Tests
{
  class Structs
  {
    struct SimpleStruct
    {
      public int Position;
      public bool Exists;
      public double LastValue;
    }

    public static void RunTests()
    {
      SimpleStruct s;
      s.Position = 1;
      s.Exists = false;
      s.LastValue = 5.4;

      Console.WriteLine($"Position => {s.Position}");
      Console.WriteLine($"Exists => {s.Exists}");
      Console.WriteLine($"LastValue => {s.LastValue}");
    }

  }
}