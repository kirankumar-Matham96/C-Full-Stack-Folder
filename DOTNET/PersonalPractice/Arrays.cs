namespace PersonalPractice
{
  class Arrays
  {
    public static void Run()
    {
      /* 1D Arrays */
      int[] intArr = { 1, 2, 3, 5, 6, 4, 20, 10, 9 };
      string[] strArr = { "I'm", "Kiran!", "I am", "a", "Software Engineer", "specialized", "in", "Full-Stack", "Development." };

      Console.WriteLine("intArr before sorting: ");
      foreach (var el in intArr)
      {
        Console.Write($"{el} ");
      }
      Console.WriteLine();

      Console.WriteLine("intArr after sorting1: ");
      intArr.Sort((a, b) => a - b);
      foreach (var el in intArr)
      {
        Console.Write($"{el} ");
      }
      Console.WriteLine();

      Console.WriteLine("intArr after sorting2: ");
      intArr.Sort((a, b) => b - a);
      foreach (var el in intArr)
      {
        Console.Write($"{el} ");
      }

      Console.WriteLine();

      Console.WriteLine("strArr before sorting: ");
      foreach (var el in strArr)
      {
        Console.Write($"{el} ");
      }
      strArr.Sort();

      Console.WriteLine("strArr after sorting: ");
      foreach (var el in strArr)
      {
        Console.Write($"{el} ");
      }

      Console.WriteLine($"\nLength of strArr: {strArr.Length}");
      Console.WriteLine($"Max: {intArr.Max()}, Min: {intArr.Min()}, Sum: {intArr.Sum()}");

      /* multi dimensional arrays */
      // 2D
      int[,] twoDArr = { { 1, 5, 3 }, { 5, 2, 6 } };
      foreach (var i in twoDArr)
      {
        Console.Write($"{i} ");
      }

      // 3d
      int[,,] arr2 = {
                        { { 1,2,3}, {4,5,6 }, {7,8,9 } },
                        { { 10,11,12}, {13,14,15 }, {16,17,18 } },
                        { { 19,20,21}, { 22,23,24}, {25,26,27 } }
                     };

      foreach (var i in arr2)
      {
        Console.Write($"{i} ");
      }
    }
  }
}