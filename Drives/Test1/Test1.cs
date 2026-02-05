namespace Tests
{
  class Test1
  {
    public static bool IsEquals(Object obj1, Object obj2)
    {
      return Equals(obj1, obj2);
    }

    public static bool IsEquals2(Object obj1, Object obj2)
    {
      return obj1 == obj2;
    }
    public static void RunTests()
    {
      string str1 = "Hello";
      string str2 = "Hello";

      int[] arr1 = { 1, 2, 3 };
      int[] arr2 = { 1, 2, 3 };

      bool result = Test1.IsEquals(str1, str2);
      bool res1 = Test1.IsEquals2(str1, str2);
      bool result2 = Test1.IsEquals(arr1, arr2);
      bool res2 = Test1.IsEquals2(arr1, arr2);

      Console.WriteLine(result);
      Console.WriteLine(res1);
      Console.WriteLine(result2);
      Console.WriteLine(res2);
    }
  }
}