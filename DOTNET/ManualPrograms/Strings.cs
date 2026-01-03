// using System.Exception;

using System.Threading.Channels;

namespace ManualProgramms
{
  public class Strings : Exception
  {

    /* ### Programs on Characters and Strings */

    // 1. Program to Check the character is vowel or not;
    public static void IsVowel()
    {
      Console.Write("Enter a character: ");
      string ip = Console.ReadLine().ToLower();
      char ch = ip[0];

      if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        Console.WriteLine($"{ch} is a vowel");
      else
        Console.WriteLine($"{ch} is not a vowel");
    }

    // 2. Program to check the given character is digit or not;
    // 3. Program to check the given character is digit or not: (Duplicate question)
    public static void IsDigit()
    {
      Console.Write("Enter a character: ");
      char ch = Console.ReadKey().KeyChar;

      string message = ch >= 48 && ch <= 57 ? $"\n{ch} is a Digit" : $"\n{ch} is not a digit";
      Console.WriteLine(message);
    }


    // 4. Program to check the character is upper case alphabet or not
    public static void IsUpperCase()
    {
      Console.Write("Enter a character: ");
      char ch = Convert.ToChar(Console.ReadLine());

      string message = ((int)ch >= 65 && (int)ch <= 90) ? $"\n{ch} is uppercase" : $"\n{ch} is not uppercase";
      Console.WriteLine(message);
    }

    // 5. Program to check the character is Alphabet or not
    public static void IsAlphabet()
    {
      Console.Write("Enter a character: ");
      char ch = Console.ReadKey().KeyChar;

      string message = (((int)ch >= 65 && (int)ch <= 90) || ((int)ch >= 97 && (int)ch <= 122)) ? $"\n{ch} is an Alphabet" : $"\n{ch} is not an Alphabet";
      Console.WriteLine(message);
    }

    // 6. Program to check the character is special symbol or not
    public static void IsSpecialCharacter()
    {
      Console.Write("Enter a character: ");
      char ch = Console.ReadKey().KeyChar;

      string message = !((int)ch >= 48 && (int)ch <= 57) && !((int)ch >= 65 && (int)ch <= 90) && !((int)ch >= 97 && (int)ch <= 122) ? $"\n{ch} is a special character" : $"\n{ch} is not a special character";
      Console.WriteLine(message);
    }

    // 7. Program to display ASCII value of given character
    public static void DispalyASCIIOfChar()
    {
      Console.Write("Enter a character: ");
      char ch = Console.ReadKey().KeyChar;

      Console.WriteLine($"\nASCII value of {ch} is: {(int)ch}");
    }

    // 8. Program to convert upper case character to lower case character
    public static void GetLowerCase()
    {
      Console.Write("Enter an upper case character: ");
      string ip = Console.ReadLine();
      char ch = Convert.ToChar(ip.ToLower());

      if (!((int)ch >= 65 && (int)ch <= 90) && !((int)ch >= 97 && (int)ch <= 122))
      {
        Console.WriteLine($"{ip} is not an alphabet to convert to lower case");
        return;
      }

      Console.WriteLine($"\nLower case: {ch}");
    }

    // 9. Display the length of given character array
    public static void GetLengthOfArray()
    {
      char[] arr = { 'a', 'x', '3', 'm', 'x', '@', 'p', '7', 'm', '4', '$' };
      Console.WriteLine($"Length of the given aay is: {arr.Length}");
    }

    // 10. Display First character of character array:
    public static void GetFirstCharacter()
    {
      char[] arr = { 'a', 'x', '3', 'm', 'x', '@', 'p', '7', 'm', '4', '$' };
      Console.WriteLine($"First character of a character array: {arr[0]}");
    }

    // 11. Check the First character is Alphabet or Not:
    public static void IsFirstCharAlphabet()
    {
      char[] arr = { 'a', 'x', '3', 'm', 'x', '@', 'p', '7', 'm', '4', '$' };
      string message = ((int)arr[0] >= 65 && (int)arr[0] <= 90) || ((int)arr[0] >= 97 && (int)arr[0] <= 122) ? $"\n{arr[0]} is an aplphabet" : $"\n{arr[0]} is not an aplphabet";
      Console.WriteLine(message);
    }

    // 12. Display all characters in the array:
    public static void DisplayCharactersInArr()
    {
      char[] arr = { 'a', 'x', '3', 'm', 'x', '@', 'p', '7', 'm', '4', '$' };
      foreach (var c in arr) Console.Write($"{c} ");
    }

    // 13. Display in reverse order:
    public static void DisplayArrayInReverse()
    {
      char[] arr = { 'a', 'x', '3', 'm', 'x', '@', 'p', '7', 'm', '4', '$' };
      Console.Write("Array in reverse order: ");
      for (int i = arr.Length - 1; i >= 0; i--)
      {
        Console.Write($"{arr[i]} ");
      }
    }

    // 14. Display only alphabets in the array:
    public static void DisplayAlphabetsInArray()
    {
      char[] arr = { 'a', 'x', '3', 'm', 'x', '@', 'p', '7', 'm', '4', '$' };
      // foreach (var i in arr) if (char.IsLetter(i)) Console.Write($"{i} ");
      foreach (var i in arr) if (((int)i >= 65 && (int)i <= 90) || ((int)i >= 97 && (int)i <= 122)) Console.Write($"{i} ");
    }


    // 15. Count alphabets, digits and symbols in the array:
    public static void CountDigitsAlphabetsSymbolsInArr()
    {
      char[] arr = { 'a', 'x', '3', 'm', 'x', '@', 'p', '7', 'm', '4', '$' };
      int alphabets = 0, digits = 0, symbols = 0;

      // foreach (var i in arr)
      // {
      //   if (char.IsLetter(i)) alphabets++;
      //   else if (char.IsDigit(i)) digits++;
      //   else symbols++;
      // }

      foreach (var i in arr)
      {
        if (((int)i >= 65 && (int)i <= 90) || ((int)i >= 97 && (int)i <= 122)) alphabets++;
        else if ((int)i >= 48 && (int)i <= 57) digits++;
        else symbols++;
      }
      Console.WriteLine($"Alphabet Count: {alphabets}\nDigit Count: {digits}\nSymbols Count: {symbols}");
    }

    // 16. Display Sum of Digits:
    public static void GetSumOfDigitsInCharArr()
    {
      char[] arr = { 'a', 'x', '3', 'm', 'x', '@', 'p', '7', 'm', '4', '$' };
      int sum = 0;

      foreach (var i in arr) if (char.IsDigit(i)) sum += Convert.ToInt32(i);
      Console.WriteLine($"Sum of digits in a given character array: {sum}");
    }

    // 17. Display array using for each:
    public static void DisplayArrUsingForeach()
    {
      char[] arr = { 'a', 'x', '3', 'm', 'x', '@', 'p', '7', 'm', '4', '$' };
      foreach (char ch in arr) Console.Write($"{ch} ");
    }

    /* ### String Programs */

    // 18. Program to display length of String:
    public static void DisplayLengthOfString()
    {
      string s = "Coding";
      Console.WriteLine($"Length of the given array is: {s.Length}");
    }

    // 19. Program to display First and Last characters of String:
    public static void DisplayFirstAndLastCharsOfAString()
    {
      string s = "Coding";
      Console.WriteLine($"First Character: {s[0]}\nLast Character: {s[s.Length - 1]}");
    }

    // 20. Program to Print String character by character:
    public static void DisplayAllCharactersInAString()
    {
      string s = "Coding";
      foreach (char i in s)
      {
        Console.WriteLine(i);
      }
    }

    // 21. Program to Print the String in reverse order:
    public static void DisplayTheStringInReverseOrder()
    {
      string s = "Coding";
      for (var i = s.Length - 1; i >= 0; i--)
      {
        Console.Write($"{s[i]}");
      }
    }
    // 22. Program to check the 2 strings equal or not:
    public static void CheckIfTwoStringsAreEqual()
    {
      string s1 = "Coding";
      string s2 = "Code";
      for (var i = 0; i < s1.Length; i++)
      {
        if (s1[i] != s2[i])
        {
          Console.WriteLine($"\"{s1}\" and \"{s2}\" are not equal");
          return;
        }
      }
      Console.WriteLine($"\"{s1}\" and \"{s2}\" are equal");
    }

    // 23. Program to create reverse string from given string:
    public static void GetRevereseString()
    {
      string s = "Coding";
      string rev = "";

      for (var i = s.Length - 1; i >= 0; i--)
      {
        rev += s[i];
      }
      Console.WriteLine($"Reverese string of \"{s}\" is: \"{rev}\"");
    }

    // 24. Program to count Alphabets, Digits and Symbols in the given String:
    public static void CountAlphabetsDigitsSymbolsInString()
    {
      string s = "Coding@365";
      int alphabetCount = 0, digitCount = 0, symbolCount = 0;

      for (var i = 0; i < s.Length; i++)
      {
        if (char.IsLetter(s[i])) alphabetCount++;
        else if (char.IsDigit(s[i])) digitCount++;
        else symbolCount++;
      }
      Console.WriteLine($"Alphabets Count: {alphabetCount}\nDigits Count: {digitCount}\nSymbols Count; {symbolCount}");
    }

    // 25. Check String is Palindrome or Not:
    public static void IsPalindromeString()
    {
      string line = "racecar";
      string rev = "";

      for (var i = line.Length - 1; i >= 0; i--)
      {
        rev += line[i];
      }

      for (int i = 0; i < line.Length; i++)
      {
        if (line[i] != rev[i])
        {
          Console.WriteLine($"The given string \"{line}\" is not a Palindrome");
          return;
        }
      }
      Console.WriteLine($"The given string \"{line}\" is a Palindrome");
    }

    // 26. Program to find the sum of digits in the given String:
    public static void GetSumOfDigitsInString()
    {
      // string s = "Coding@365";
    }

    // 27. Display the ASCII values of characters in the given String:
    public static void DisplayASCIIValuesOfEachCharInString()
    {
      // string s = "Coding";

    }

    // 28. Program to convert upper case string to lower case string:
    public static void ConvertUpperCaseStringToLowerCaseString()
    {
      // string s = "CoDinG@365";
      // String res = "";
    }

    // 29. Program to display highest digit in the given String:
    public static void DisplayHighestDigitInString()
    {
      // string s = "coding@365";
    }
    /*


                  ---

                  ### String Array Programs

                  30. Program to find the length of String array:

                  ```
                  String[] arr = {"java", "asp", "servlets", "ado.net", "springBoot"};
                  ```

                  31. Program to display Strings from Array:

                  ```
                  String[] arr = {"java", "asp", "servlets", "ado.net", "springBoot"};
                  ```

                  32. Program to display the length of each String in the array:

                  ```
                  String[] arr = {"java", "asp", "servlets", "ado.net", "springBoot"};
                  ```

                  33. Program to display First and Last characters of each string in the array:

                  ```
                  String[] arr = {"java", "asp", "servlets", "ado.net", "springBoot"};
                  ```

                  34. Program to display String array in reverse order:

                  ```
                  String[] arr = {"java", "asp", "servlets", "ado.net", "springBoot"};
                  ```

                  35. Program to display each String in reverse order from Array:

                  ```
                  String[] arr = {"java", "asp", "servlets", "ado.net", "springBoot"};
                  ```

                  ---

                  ### Advanced String Programs

                  36. Program to Split the String into Words:

                  ```
                  string s = "This is simple english sentence";
                  ```

                  37. Program to count number of words in the given string without split() method:

                  ```
                  string s = "This is simple english sentence";
                  ```

                  38. Program to check two strings are Anagrams or not:
                  We can say if two strings are an anagram of each other if they contain the same characters but at different orders.
                  For example, army & mary

                  ```
                  string s1 = "army";
                  string s2 = "mary";
                  ```

                  39. Program to display longest word in the given String:

                  ```
                  string s = "This is the Longest Sentence in English";
                  ```

                  40. Program to remove duplicates in the String:

                  ```
                  string str = "aaabbababaaacccbabdcccddddbac";
                  String res = "";
                  ```

                  41. Program to remove spaces in String:

                  ```
                  string s = "This is a String";
                  ```

                  42. Program to remove multiple spaces in the given string:

                  ```
                  string s = "This   is   a   String";
                  ```

                  43. Program to Print characters specified by the number of times:

                  ```
                  Input: abc3e2f4
                  Expected output: abccceeffff
                  ```

                  44. Program to swap the side-by-side characters in the given string:

                  ```
                  string s1 = "abcde";
                  string s2 = "";
                  ```

                  45. Program to display the character count in the given string:

                  ```
                  Input: aaabbbacccddacdd
                  Output: a-5, b-3, c-5, d-4
                  ```

                  ---

                  If you want, I can also:

                  * Convert these into Java / C# programs
                  * Put them into a Word / PDF / text file
                  * Group them topic-wise for interview prep

                  Just tell me 👍


        */



    public static void RunTests()
    {
      /* Character programs */
      // IsVowel();
      // IsDigit();
      // IsUpperCase();
      // IsAlphabet();
      // IsSpecialCharacter();
      // DispalyASCIIOfChar();
      // GetLowerCase();
      // GetLengthOfArray();
      // GetFirstCharacter();
      // IsFirstCharAlphabet();
      // DisplayCharactersInArr();
      // DisplayArrayInReverse();
      // DisplayAlphabetsInArray();
      // CountDigitsAlphabetsSymbolsInArr();
      // GetSumOfDigitsInCharArr();
      // DisplayArrUsingForeach();

      /* String Programs */
      // DisplayLengthOfString();
      // DisplayFirstAndLastCharsOfAString();
      // DisplayAllCharactersInAString();
      // DisplayTheStringInReverseOrder();
      // CheckIfTwoStringsAreEqual();
      // GetRevereseString();
      // CountAlphabetsDigitsSymbolsInString();
      IsPalindromeString();
    }
  }
}