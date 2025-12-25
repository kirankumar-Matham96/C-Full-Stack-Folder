namespace PersonalPractice
{
  class Strings
  {
    public static void Run()
    {

      string str = "Hello my dear friend!";
      Console.WriteLine($"Index of o is: {str.IndexOf('o')}"); // finding index of a character
      Console.WriteLine($"Index of ea is: {str.IndexOf("ea")}"); // finding index of a sub string

      string str2 = "Kirankumar Matham";
      Console.WriteLine($"Last Name: {str2.Substring(str2.IndexOf(' ')).Trim()}"); // getting sub string from the string from a certain index value

      string[] names = str2.Split(" "); // string to array
      Console.WriteLine($"First Name: {names[0]}, Last Name: {names[1]}");
    }
  }
}