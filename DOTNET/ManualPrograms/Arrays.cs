using System.Runtime.InteropServices;

namespace ManualPrograms
{
  public class ArraysClass
  {

    public static int[] intArr1 = { 1, 5, 2, 3, 4, 2, 9, 12, 13, 6, 8, 7, 9, 10, 25 };
    public static int[] intArr2 = { 1, 5, 2, 3, 4, 2, 9, 12, 13, 6, 8, 7, 9, 10, 25, 12 };
    public static string[] strArr = { "Hello", "This", "is", "a", "string", "array" };
    public static char[] charArr = { 'a', 'e', 'i', 'o', 'u' };

    /* Basic Array Operations and Initialization */

    public static void BasicOperations()
    {
      // 1. Declare Array Variable?
      int[] arr1;

      // 2. Initialize integer array with 5 values?
      int[] arr2 = { 5, 4, 6, 2, 1 };

      // 3. Create Empty Integer Array with size 5?
      int[] arr3 = new int[5];

      // 4. Display length of the intArr
      Console.WriteLine($"Length of intArr: {intArr1.Length}");

      // 5. Display First element of array
      Console.WriteLine($"First element of intArr: {intArr1[0]}");

      // 6. Display last element of array
      Console.WriteLine($"Last element of intArr: {intArr1[intArr1.Length - 1]}");

      // 7. Display Sum of First and Last elements of Array
      Console.WriteLine($"Sum of First and Last elements of Array: {intArr1[0] + intArr1[intArr1.Length - 1]}");

      // 8. Check the first element of array is even or not
      string message = intArr1[0] % 2 == 0 ? "First element of the array is Even" : "First element of the array is Odd";
      Console.WriteLine(message);

      // 9. Print Multiplication table for last element in the array
      Console.WriteLine("Multiplication tables: ");
      for (var i = 0; i < intArr1.Length; i++)
      {
        for (var j = 1; j <= 10; j++)
        {
          Console.WriteLine($"{intArr1[i]} X {j} = {intArr1[i] * j}");
        }
        Console.WriteLine();
      }

      // 10. Display the middle element of following array of odd length
      Console.WriteLine($"Middle elemnet of the odd length array: {intArr1[intArr1.Length / 2]}");

      // 11. Display sum of 2 middle elements in the given even array of elements: `Int[] arr = {3, 7, 8, 2, 9, 5, 6, 4};`
      Console.WriteLine($"Middle elemnets of the even length array: {intArr2[intArr2.Length / 2 - 1]},{intArr2[intArr2.Length / 2]}");

      // 12. Display all elements in the array
      for (var i = 0; i < intArr1.Length; i++) Console.Write($"{intArr1[i]} ");
      Console.WriteLine();
      // 13. Display array elements in reverse order
      for (var i = intArr1.Length - 1; i >= 0; i--) Console.Write($"{intArr1[i]} ");
      Console.WriteLine();

      // 14. Find the sum of array elements
      int sum1 = 0;
      for (var i = 0; i < intArr1.Length; i++) sum1 += intArr1[i];
      Console.WriteLine($"Sum of all elements: {sum1}");

      // 15. Display only even numbers in the given array
      int evenSum = 0;
      for (var i = 0; i < intArr1.Length; i++) if (intArr1[i] % 2 == 0) evenSum += intArr1[i];
      Console.WriteLine($"Sum of even elements: {evenSum}");

      // 16. Count odd numbers in the given array
      int oddSum = 0;
      for (var i = 0; i < intArr1.Length; i++) if (intArr1[i] % 2 != 0) oddSum += intArr1[i];
      Console.WriteLine($"Sum of odd elements: {oddSum}");
    }

    /*Array Iteration and Element Swapping*/

    // 17. Display Sum of Even elements in the given array
    public static void SumOfEvenElements()
    {
      int evenSum = 0;
      for (var i = 0; i < intArr1.Length; i++) if (intArr1[i] % 2 == 0) evenSum += intArr1[i];
      Console.WriteLine($"Sum of all elements: {evenSum}");
    }

    // 18. Display elements using for-each loop
    public static void DisplayElements()
    {
      foreach (var element in intArr1) Console.Write($"{element} ");
    }

    // 19. Display sum of elements using for-each loop
    public static void SumOfElements()
    {
      int sum = 0;
      foreach (var element in intArr1) sum += element;

      Console.WriteLine($"Sum of all elements: {sum}");
    }

    // 20. Display even elements in array using for-each loop
    public static void EvenElements()
    {
      foreach (var element in intArr1) if (element % 2 == 0) Console.Write($"{element} ");
    }

    // 21. Find the sum of odd elements in the given array using for-each loop
    public static void SumOfOddElements()
    {
      int oddSum = 0;
      foreach (var element in intArr1) if (element % 2 != 0) oddSum += element;
      Console.WriteLine($"Sum of all elements: {oddSum}");
    }

    // 22. Swap first and second elements in the array then Print elements using for-each
    public static void SwapFirstAndSecondElements()
    {
      int temp = intArr1[0];
      intArr1[0] = intArr1[1];
      intArr1[1] = temp;

      foreach (var element in intArr1) Console.Write($"{element} ");
    }

    // 23. Swap first and last elements in the array then Print elements using for-each loop
    public static void SwapFirstAndLastElements()
    {
      intArr1[0] = intArr1[0] + intArr1[intArr1.Length - 1];
      intArr1[intArr1.Length - 1] = intArr1[0] - intArr1[intArr1.Length - 1];
      intArr1[0] = intArr1[0] - intArr1[intArr1.Length - 1];

      foreach (var element in intArr1) Console.Write($"{element} ");
    }

    // 24. Swap elements in specified locations of arrayInt x = 2, y = 3;`
    public static void SwapElementsAtSpecifiedLocations(int x, int y)
    {
      // XOR operation to swap without temp variable
      // intArr1[x] = intArr1[x] ^ intArr2[y];
      // intArr2[y] = intArr1[x] ^ intArr2[y];
      // intArr1[x] = intArr1[x] ^ intArr2[y];

      // swap in 1 line without temp variable
      intArr1[x] = intArr1[x] + intArr2[y] - (intArr2[y] = intArr1[x]);

      foreach (var element in intArr1) Console.Write($"{element} ");
    }

    // 25. Swap array element with its adjacent element for the specified locationInt loc = 3;`
    public static void SwapWithAdjacentElement(int loc)
    {
      intArr1[loc] = intArr1[loc] * intArr2[loc + 1];
      intArr2[loc + 1] = intArr1[loc] / intArr2[loc + 1];
      intArr1[loc] = intArr1[loc] / intArr2[loc + 1];

      foreach (var element in intArr1) Console.Write($"{element} ");
    }

    // 26. Display Largest element in the array
    public static void DisplayLargestElement()
    {
      int largest = intArr1[0];
      for (var i = 1; i < intArr1.Length; i++)
      {
        if (intArr1[i] > largest)
        {
          largest = intArr1[i];
        }
      }
      Console.WriteLine($"Largest element in the array: {largest}");
    }

    // 27. Display smallest element in the array
    public static void DisplaySmallestElement()
    {
      int smallest = intArr1[0];
      for (var i = 1; i < intArr1.Length; i++)
      {
        if (intArr1[i] < smallest)
        {
          smallest = intArr1[i];
        }
      }
      Console.WriteLine($"Smallest element in the array: {smallest}");
    }


    /* Intermediate Logic and Filtering */
    // 28. Display First even number in the array
    public static void DisplayFirstEvenElement()
    {
      for (var i = 0; i < intArr1.Length; i++)
      {
        if (intArr1[i] % 2 == 0)
        {
          Console.WriteLine($"First even element in the array: {intArr1[i]}");
          break;
        }
      }
    }

    // 29. Display last odd element in the array
    public static void DisplayLastOddElement()
    {
      for (var i = intArr1.Length - 1; i >= 0; i--)
      {
        if (intArr1[i] % 2 != 0)
        {
          Console.WriteLine($"Last odd element in the array: {intArr1[i]}");
          break;
        }
      }
    }

    // 30. Swap Smallest and Largest elements in the array
    public static void SwapSmallestAndLargestElements()
    {
      int smallestIndex = 0;
      int largestIndex = 0;

      for (var i = 1; i < intArr1.Length; i++)
      {
        if (intArr1[i] < intArr1[smallestIndex]) smallestIndex = i;
        if (intArr1[i] > intArr1[largestIndex]) largestIndex = i;
      }

      // Swap smallest and largest elements
      intArr1[largestIndex] = intArr1[smallestIndex] + intArr1[largestIndex] - (intArr1[smallestIndex] = intArr1[largestIndex]);

      Console.WriteLine("Array after swapping smallest and largest elements:");
      foreach (var element in intArr1) Console.Write($"{element} ");
    }

    // 31. Swap First even and Last Odd elements in the array
    public static void SwapFirstEvenAndLastOddElements()
    {
      int firstEvenIndex = -1;
      int lastOddIndex = -1;

      for (var i = 0; i < intArr1.Length; i++)
      {
        if (intArr1[i] % 2 == 0 && firstEvenIndex == -1) firstEvenIndex = i;
        if (intArr1[intArr1.Length - 1 - i] % 2 != 0 && lastOddIndex == -1) lastOddIndex = intArr1.Length - 1 - i;
        if (firstEvenIndex != -1 && lastOddIndex != -1) break;
      }

      // Swap first even and last odd elements
      intArr1[firstEvenIndex] = intArr1[firstEvenIndex] + intArr1[lastOddIndex] - (intArr1[lastOddIndex] = intArr1[firstEvenIndex]);

      Console.WriteLine("Array after swapping first even and last odd elements:");
      foreach (var element in intArr1) Console.Write($"{element} ");
    }

    // 32. Display Second biggest element in the array
    public static void DisplaySecondBiggestElement()
    {
      int largest = int.MinValue;
      int secondLargest = int.MinValue;

      for (var i = 0; i < intArr1.Length; i++)
      {
        if (intArr1[i] > largest)
        {
          secondLargest = largest;
          largest = intArr1[i];
        }
        else if (intArr1[i] > secondLargest && intArr1[i] != largest)
        {
          secondLargest = intArr1[i];
        }
      }

      Console.WriteLine($"Second biggest element in the array: {secondLargest}");
    }

    // 33. Display Second smallest element in the array
    public static void DisplaySecondSmallestElement()
    {
      int smallest = int.MaxValue;
      int secondSmallest = int.MaxValue;

      for (var i = 0; i < intArr1.Length; i++)
      {
        if (intArr1[i] < smallest)
        {
          secondSmallest = smallest;
          smallest = intArr1[i];
        }
        else if (intArr1[i] < secondSmallest && intArr1[i] != smallest)
        {
          secondSmallest = intArr1[i];
        }
      }

      Console.WriteLine($"Second smallest element in the array: {secondSmallest}");
    }

    // 34. Copy elements from one array to another array
    public static void CopyElements()
    {
      int[] src = { 3, 7, 8, 2, 5, 6, 4 };
      int[] dest = new int[src.Length];

      for (var i = 0; i < src.Length; i++)
      {
        dest[i] = src[i];
      }

      Console.WriteLine("Elements copied from source to destination array:");
      foreach (var element in dest) Console.Write($"{element} ");
    }

    // 35. Create new array with only even numbers of given array
    public static void CreateNewArrayWithEvenNumbers()
    {
      int[] evenArray = new int[intArr1.Length];
      int evenIndex = 0;

      for (var i = 0; i < intArr1.Length; i++)
      {
        if (intArr1[i] % 2 == 0)
        {
          evenArray[evenIndex++] = intArr1[i];
        }
      }

      Console.WriteLine("New array with only even numbers:");
      foreach (var element in evenArray) Console.Write($"{element} ");
    }

    // 36. Create new array with only odd numbers of given array
    public static void CreateNewArrayWithOddNumbers()
    {
      int[] oddArray = new int[intArr1.Length];
      int oddIndex = 0;

      for (var i = 0; i < intArr1.Length; i++)
      {
        if (intArr1[i] % 2 != 0)
        {
          oddArray[oddIndex++] = intArr1[i];
        }
      }

      Console.WriteLine("New array with only odd numbers:");
      foreach (var element in oddArray) Console.Write($"{element} ");
    }

    // 37. Create 2 new arrays with even and odd numbers from the given mixed elements array
    public static void CreateTwoNewArraysWithEvenAndOddNumbers()
    {
      int[] evenArray = new int[intArr1.Length];
      int[] oddArray = new int[intArr1.Length];
      int evenIndex = 0;
      int oddIndex = 0;

      for (var i = 0; i < intArr1.Length; i++)
      {
        if (intArr1[i] % 2 == 0)
        {
          evenArray[evenIndex++] = intArr1[i];
        }
        else
        {
          oddArray[oddIndex++] = intArr1[i];
        }
      }

      Console.WriteLine("New array with only even numbers:");
      foreach (var element in evenArray) Console.Write($"{element} ");

      Console.WriteLine("\nNew array with only odd numbers:");
      foreach (var element in oddArray) Console.Write($"{element} ");
    }
    // 38. Check the element is duplicated or not in the given array
    public static void CheckElementIsDuplicated(int ele)
    {
      int count = 0;
      for (var i = 0; i < intArr1.Length; i++) if (intArr1[i] == ele) count++;

      if (count > 1) Console.WriteLine($"Element {ele} is duplicated in the array.");
      else Console.WriteLine($"Element {ele} is not duplicated in the array.");
    }

    /*
   ### Searching, Sorting, and Complex Tasks
     39. Linear Search AlgorithmInt ele = 5;`
     40. Binary Search algorithmInt ele = 5;`
     41. Sort all elements in the array
     42. Display array elements which are greater than average of all elements in the array
     43. Merge 2 arrays: `Int[] a1 = {3, 7, 8, 2,}; Int[] a2 = {5, 6, 4};`
     44. Read the Size and Create Array:
     45. Create the array by reading size and fill the array with elements by reading again from user:
     46. Program to display the pair of elements whose sum equals to 10
     47. Program to replace all duplicates with 0: `int[] arr = {6, 2, 3, 1, 6, 7, 6, 3, 6, 2, 3, 2, 1};`
     48. Program to display pair of elements whose sum is 10 (contains duplicates in array): `int[] arr = {6, 3, 9, 1, 2, 8, 4, 5, 7, 6, 2, 9, 1, 4};`
     49. Program to find the common elements from 2 arrays: `int[] a1 = {1, 2, 5, 5, 8, 9, 5, 7, 10}; int[] a2 = {3, 6, 15, 6, 5, 4, 7, 2, 1};`
     50. Program to find the duplicates in the array: `int[] arr = {1, 2, 5, 5, 8, 9, 2, 5, 7, 1, 10, 1, 2};`
     51. Program to arrange even numbers to left side and odd numbers to right side of Array: `int[] arr = {7, 2, 9, 8, 4, 1, 2, 6, 5};`
     52. Program to check 2 arrays are equal or not: `int[] a1 = {3, 4, 5, 6, 7}; int[] a2 = {3, 4, 5, 6, 7};`
     53. Program to find the missing number in the given array: `int[] arr = {2, 3, 4, 5, 7, 8, 9};`
     54. Program to find the largest difference of Array elements: `int[] arr = {5, 7, 3, 8, 6, 9, 4};`
     55. Program to find the index difference between smallest and largest elements: `int[] arr = {5, 7, 3, 8, 6, 9, 4};`
       56. Program to check array contains only positive numbers or not: `int[] arr = {5, 7, 3, 8, 6, -4, 4};`
       57. Program to Print leader elements in the array (All elements to its right must be smaller to Leader element): `int arr[] = {10, 9, 14, 23, 15, 0, 9};`
       58. Program to find the largest difference pair in the sequence from the given sorted Array: `int[] arr = {5, 7, 13, 15, 16, 19, 34};` o/p: Largest difference pair: {19, 34}

    ### Two Dimensional Array Programs
       59. Define 3x3 dimensional array with elements:
       60. Display elements of 3x3 dimensional array: `int[][] array = {{7, 5, 2},{5, 4, 8},{9, 2, 6}};`
       61. Display smallest element in 3x3 dimensional array: `int[][] array = {{7, 5, 2},{5, 4, 8},{9, 2, 6}};`
       62. Display largest element in 3x3 dimensional array: `int[][] array = {{7, 5, 2},{5, 4, 8},{9, 2, 6}};`
       63. Display sum of each row in the given matrix: `int[][] array = {{7, 5, 2},{5, 4, 8},{9, 2, 6}};`
       64. Display sum of each column in the given matrix: `int[][] array = {{7, 5, 2},{5, 4, 8},{9, 2, 6}};`
       65. Display Max row sum in the given matrix: `int[][] array = {{7, 5, 2},{5, 4, 8},{9, 2, 6}};`
       66. Transpose of matrix: `int[][] array = {{7, 5, 2},{5, 4, 8},{9, 2, 6}};`
       67. Matrix addition program:
       68. Matrix Multiplication Program:
        */



    public static void RunTests()
    {
      Console.WriteLine("\nArray Programs Execution:\n");

      // Basic Array Operations and Initialization
      BasicOperations();

      // Array Iteration and Element Swapping
      SumOfEvenElements();
      DisplayElements();
      SumOfElements();
      EvenElements();
      SumOfOddElements();
      SwapFirstAndSecondElements();
      SwapFirstAndLastElements();
      SwapElementsAtSpecifiedLocations(2, 3);
      SwapWithAdjacentElement(3);
      DisplayLargestElement();
      DisplaySmallestElement();

      // Intermediate Logic and Filtering
      DisplayFirstEvenElement();
      DisplayLastOddElement();
      SwapSmallestAndLargestElements();
      SwapFirstEvenAndLastOddElements();
      DisplaySecondBiggestElement();
      DisplaySecondSmallestElement();
      CopyElements();
      CreateNewArrayWithEvenNumbers();
      CreateNewArrayWithOddNumbers();
      CreateTwoNewArraysWithEvenAndOddNumbers();
      CheckElementIsDuplicated(9);
    }
  }
}