using System.Runtime.InteropServices;

namespace ManualPrograms
{
  public class ArraysClass
  {

    public static int[] intArr1 = { 1, 5, 2, 3, 4, 2, 9, 12, 13, 6, 8, 7, 9, 10, 25 };
    public static int[] intArr2 = { 1, 5, 2, 3, 4, 2, 9, 12, 13, 6, 8, 7, 9, 10, 25, 12 };
    public static int[] sortedIntArr = { -20, -15, -10, -2, 0, 1, 5, 6, 7, 9, 10, 15, 19, 25, 50 };
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
      for (int i = 0; i < intArr1.Length; i++)
      {
        for (int j = 1; j <= 10; j++)
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
      for (int i = 0; i < intArr1.Length; i++) Console.Write($"{intArr1[i]} ");
      Console.WriteLine();
      // 13. Display array elements in reverse order
      for (int i = intArr1.Length - 1; i >= 0; i--) Console.Write($"{intArr1[i]} ");
      Console.WriteLine();

      // 14. Find the sum of array elements
      int sum1 = 0;
      for (int i = 0; i < intArr1.Length; i++) sum1 += intArr1[i];
      Console.WriteLine($"Sum of all elements: {sum1}");

      // 15. Display only even numbers in the given array
      int evenSum = 0;
      for (int i = 0; i < intArr1.Length; i++) if (intArr1[i] % 2 == 0) evenSum += intArr1[i];
      Console.WriteLine($"Sum of even elements: {evenSum}");

      // 16. Count odd numbers in the given array
      int oddSum = 0;
      for (int i = 0; i < intArr1.Length; i++) if (intArr1[i] % 2 != 0) oddSum += intArr1[i];
      Console.WriteLine($"Sum of odd elements: {oddSum}");
    }

    /*Array Iteration and Element Swapping*/

    // 17. Display Sum of Even elements in the given array
    public static void SumOfEvenElements()
    {
      int evenSum = 0;
      for (int i = 0; i < intArr1.Length; i++) if (intArr1[i] % 2 == 0) evenSum += intArr1[i];
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
      Console.WriteLine($"Sum of odd elements: {oddSum}");
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
      foreach (var element in intArr1) Console.Write($"{element} ");
      Console.WriteLine();
      intArr1[x] = intArr1[x] + intArr1[y] - (intArr1[y] = intArr1[x]);

      foreach (var element in intArr1) Console.Write($"{element} ");
    }

    // 25. Swap array element with its adjacent element for the specified locationInt loc = 3;`
    public static void SwapWithAdjacentElement(int loc)
    {
      intArr1[loc] = intArr1[loc] * intArr1[loc + 1];
      intArr1[loc + 1] = intArr1[loc] / intArr1[loc + 1];
      intArr1[loc] = intArr1[loc] / intArr1[loc + 1];

      foreach (var element in intArr1) Console.Write($"{element} ");
    }

    // 26. Display Largest element in the array
    public static void DisplayLargestElement()
    {
      int largest = intArr1[0];
      for (int i = 1; i < intArr1.Length; i++)
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
      for (int i = 1; i < intArr1.Length; i++)
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
      for (int i = 0; i < intArr1.Length; i++)
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
      for (int i = intArr1.Length - 1; i >= 0; i--)
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

      for (int i = 1; i < intArr1.Length; i++)
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

      for (int i = 0; i < intArr1.Length; i++)
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

      for (int i = 0; i < intArr1.Length; i++)
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

      for (int i = 0; i < intArr1.Length; i++)
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

      for (int i = 0; i < src.Length; i++)
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

      for (int i = 0; i < intArr1.Length; i++)
      {
        if (intArr1[i] % 2 == 0)
        {
          evenArray[evenIndex++] = intArr1[i];
        }
      }

      Console.WriteLine("\nNew array with only even numbers:");
      for (int element = 0; element < evenIndex; element++) Console.Write($"{evenArray[element]} ");
    }

    // 36. Create new array with only odd numbers of given array
    public static void CreateNewArrayWithOddNumbers()
    {
      int[] oddArray = new int[intArr1.Length];
      int oddIndex = 0;

      for (int i = 0; i < intArr1.Length; i++) if (intArr1[i] % 2 != 0) oddArray[oddIndex++] = intArr1[i];

      Console.WriteLine("\nNew array with only odd numbers:");
      for (int element = 0; element < oddIndex; element++) Console.Write($"{oddArray[element]} ");
    }

    // 37. Create 2 new arrays with even and odd numbers from the given mixed elements array
    public static void CreateTwoNewArraysWithEvenAndOddNumbers()
    {
      int[] evenArray = new int[intArr1.Length];
      int[] oddArray = new int[intArr1.Length];
      int evenIndex = 0;
      int oddIndex = 0;

      for (int i = 0; i < intArr1.Length; i++)
      {
        if (intArr1[i] % 2 == 0) evenArray[evenIndex++] = intArr1[i];
        else oddArray[oddIndex++] = intArr1[i];
      }

      Console.WriteLine("\nNew array with only even numbers:");
      for (int element = 0; element < evenIndex; element++) Console.Write($"{evenArray[element]} ");

      Console.WriteLine("\nNew array with only odd numbers:");
      for (int element = 0; element < oddIndex; element++) Console.Write($"{oddArray[element]} ");
    }

    // 38. Check the element is duplicated or not in the given array
    public static void CheckElementIsDuplicated(int ele)
    {
      for (int i = 0; i < intArr1.Length; i++)
      {
        if (intArr1[i] == ele)
        {
          Console.WriteLine($"Element {ele} is duplicated in the array.");
          return;
        }
      }
      Console.WriteLine($"Element {ele} is not duplicated in the array.");
    }


    /*  ### Searching, Sorting, and Complex Tasks */

    //  39. Linear Search AlgorithmInt ele = 5;
    public static void LinearSearch(int ele)
    {
      for (int i = 0; i < intArr1.Length; i++)
      {
        if (intArr1[i] == ele) { Console.WriteLine($"{ele} found at index: {i}"); return; }
      }
      Console.WriteLine($"{ele} is not found in the array");
    }

    /*  40. Binary Search algorithmInt ele = 5;
        -> get the middle index element
        -> Check if the element matches. If yes, terminate the process.
        -> If not, check if the element is smaller or larger than middle element.
        -> Based on the result either make the middle element as smaller element or larger element.
        -> Then continue the process untill the element is found.
    */
    public static void BinarySearch(int ele)
    {
      int smallestIdx = 0;
      int n = sortedIntArr.Length;
      int largestIdx = n - 1;
      Console.WriteLine($"smallestIdx: {smallestIdx}, largestIdx: {largestIdx}");
      Console.WriteLine("Entering while loop...");

      int middleIndex;
      while (n > 0)
      {
        n--;
        middleIndex = (smallestIdx + largestIdx) / 2;

        if (sortedIntArr[middleIndex] == ele)
        {
          Console.WriteLine($"{ele} found at index: {middleIndex}");
          return;
        }

        if (sortedIntArr[middleIndex] < ele)
        {
          smallestIdx = middleIndex;
        }
        else
        {
          largestIdx = middleIndex;
        }
      }
      Console.WriteLine($"{ele} not found in the array");
    }

    //  41. Sort all elements in the array
    public static void SortArrayInAscendingOrder()
    {
      for (int i = 0; i < intArr1.Length; i++)
      {
        for (int j = 0; j < intArr1.Length; j++)
        {
          if (intArr1[i] > intArr1[j]) intArr1[j] = intArr1[i] + intArr1[j] - (intArr1[i] = intArr1[j]);
        }
      }
      foreach (var i in intArr1) Console.Write($"{i} ");
    }

    //  42. Display array elements which are greater than average of all elements in the array
    public static void SortArrayInDescendingOrder()
    {
      for (int i = 0; i < intArr1.Length; i++)
      {
        for (int j = 0; j < intArr1.Length; j++)
        {
          if (intArr1[i] < intArr1[j]) intArr1[j] = intArr1[i] + intArr1[j] - (intArr1[i] = intArr1[j]);
        }
      }
      Console.WriteLine();
      foreach (var i in intArr1) Console.Write($"{i} ");
    }

    /*  43. Merge 2 arrays: `Int[] a1 = {3, 7, 8, 2,}; Int[] a2 = {5, 6, 4};`
        -> Need to use merge sort algorithm later
    */
    public static void MergeTwoArrays()
    {
      int[] a1 = { 3, 7, 8, 2 };
      int[] a2 = { 5, 6, 4 };
      int[] result = new int[a1.Length + a2.Length];

      int index = 0;

      foreach (var i in a1)
      {
        result[index] = i;
        index++;
      }
      foreach (var i in a2)
      {
        result[index] = i;
        index++;
      }
      for (int i = 0; i <= index; i++)
      {
        for (int j = 1; j <= index; j++)
        {
          if (result[i] > result[j]) result[j] = result[i] + result[j] - (result[i] = result[j]);
        }
      }
      foreach (var i in result) Console.Write($"{i} ");
    }

    //  45. Create the array by reading size and fill the array with elements by reading again from user:
    public static void ReadInputAndCreateAnArray()
    {
      Console.Write("Enter the array size: ");
      int n = Convert.ToInt32(Console.ReadLine());

      int[] arr = new int[n];

      for (int i = 0; i < arr.Length; i++)
      {
        Console.Write("Enter the number at index {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
      }

      foreach (var i in arr) Console.WriteLine($"{i} ");
    }

    //  46. Program to display the pair of elements whose sum equals to 10
    public static void DispalyPairWhoseSumIs10()
    {
      for (int i = 0; i < intArr2.Length; i++)
      {
        for (int j = 0; j < intArr2.Length; j++)
        {
          if (intArr2[i] + intArr2[j] == 10) Console.Write($"({intArr2[i]},{intArr2[j]}) ");
        }
      }
    }

    //  47. Program to replace all duplicates with 0: `int[] arr = {6, 2, 3, 1, 6, 7, 6, 3, 6, 2, 3, 2, 1};`
    public static void ReplaceAllDuplicatesWith0()
    {
      int[] arr = { 6, 2, 3, 1, 6, 7, 6, 3, 6, 2, 3, 2, 1 };

      for (int i = 0; i < arr.Length; i++)
      {
        for (int j = i; j < arr.Length; j++)
        {
          if (i == j) continue;
          if (arr[i] == arr[j]) arr[j] = 0;
        }
      }
      foreach (var i in arr) Console.Write($"{i} ");
    }

    //  48. Program to display pair of elements whose sum is 10 (contains duplicates in array): `int[] arr = {6, 3, 9, 1, 2, 8, 4, 5, 7, 6, 2, 9, 1, 4};`
    public static void DispalyPairWhoseSumIs10WithDuplicates()
    {
      int[] arr = { 6, 3, 9, 1, 2, 8, 4, 5, 7, 6, 2, 9, 1, 4 };

      for (int i = 0; i < arr.Length; i++)
      {
        for (int j = i; j < arr.Length; j++)
        {
          if (arr[i] + arr[j] == 10) Console.Write($"({arr[i]},{arr[j]}) ");
        }
      }
    }

    //  49. Program to find the common elements from 2 arrays: `int[] a1 = {1, 2, 5, 5, 8, 9, 5, 7, 10}; int[] a2 = {3, 6, 15, 6, 5, 4, 7, 2, 1};`
    public static void DisplayCommonElements()
    {
      int[] a1 = { 1, 2, 5, 5, 8, 9, 5, 7, 10 };
      int[] a2 = { 3, 6, 15, 6, 5, 4, 7, 2, 1 };

      for (int i = 0; i < a1.Length; i++)
      {
        for (int j = 0; j < a2.Length; j++)
        {
          if (a1[i] == a2[j]) Console.Write($"{a1[i]} ");
        }
      }
    }

    //  50. Program to find the duplicates in the array: `int[] arr = {1, 2, 5, 5, 8, 9, 2, 5, 7, 1, 10, 1, 2};`
    public static void FindDuplicatesInArray()
    {
      int[] arr = { 1, 2, 5, 5, 8, 9, 2, 5, 7, 1, 10, 1, 2 };
      Console.WriteLine("Duplicate elements in the array:");

      for (int i = 0; i < arr.Length; i++)
      {
        for (int j = i + 1; j < arr.Length; j++)
        {
          if (arr[i] == arr[j]) Console.Write($"{arr[i]} ");
        }
      }
    }

    //  51. Program to arrange even numbers to left side and odd numbers to right side of Array: `int[] arr = {7, 2, 9, 8, 4, 1, 2, 6, 5};`
    public static void ArrangeEvenOdd()
    {
      int[] arr = { 7, 2, 9, 8, 4, 1, 2, 6, 5 };
      int[] result = new int[arr.Length];
      int evenIndex = 0;
      int oddIndex = arr.Length - 1;

      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] % 2 == 0)
        {
          result[evenIndex++] = arr[i];
        }
        else
        {
          result[oddIndex--] = arr[i];
        }
      }

      Console.WriteLine("Array after arranging even numbers to left and odd numbers to right:");
      foreach (var i in result) Console.Write($"{i} ");
    }

    //  52. Program to check 2 arrays are equal or not: `int[] a1 = {3, 4, 5, 6, 7}; int[] a2 = {3, 4, 5, 6, 7};`
    public static void CheckArraysEqual()
    {
      int[] a1 = { 3, 4, 5, 6, 7 };
      int[] a2 = { 3, 4, 5, 6, 7 };

      if (a1.Length != a2.Length)
      {
        Console.WriteLine("Arrays are not equal.");
        return;
      }

      for (int i = 0; i < a1.Length; i++)
      {
        if (a1[i] != a2[i])
        {
          Console.WriteLine("Arrays are not equal.");
          return;
        }
      }
      Console.WriteLine("Arrays are equal.");
    }

    //  53. Program to find the missing number in the given array: `int[] arr = {2, 3, 4, 5, 7, 8, 9};`
    public static void FindMissingNumber()
    {
      int[] arr = { 2, 3, 4, 5, 7, 8, 9 };
      int n = arr.Length + 1; // Since one number is missing
      int expectedSum = n * (n + 1) / 2;
      int actualSum = 0;

      for (int i = 0; i < arr.Length; i++)
      {
        actualSum += arr[i];
      }

      int missingNumber = expectedSum - actualSum;
      Console.WriteLine($"Missing number in the array is: {missingNumber}");
    }

    //  54. Program to find the largest difference of Array elements: `int[] arr = {5, 7, 3, 8, 6, 9, 4};`
    public static void FindLargestDifference()
    {
      int[] arr = { 5, 7, 3, 8, 6, 9, 4 };
      int largest = int.MinValue;
      int smallest = int.MaxValue;

      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] > largest) largest = arr[i];
        if (arr[i] < smallest) smallest = arr[i];
      }

      int difference = largest - smallest;
      Console.WriteLine($"Largest difference between elements in the array is: {difference}");
    }

    //  55. Program to find the index difference between smallest and largest elements: `int[] arr = {5, 7, 3, 8, 6, 9, 4};`
    public static void FindIndexDifference()
    {
      int[] arr = { 5, 7, 3, 8, 6, 9, 4 };
      int largestIndex = 0;
      int smallestIndex = 0;
      int largest = int.MinValue;
      int smallest = int.MaxValue;

      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] > largest)
        {
          largest = arr[i];
          largestIndex = i;
        }
        if (arr[i] < smallest)
        {
          smallest = arr[i];
          smallestIndex = i;
        }
      }

      int indexDifference = Math.Abs(largestIndex - smallestIndex);
      Console.WriteLine($"Index difference between smallest and largest elements is: {indexDifference}");
    }

    //  56. Program to check array contains only positive numbers or not: `int[] arr = {5, 7, 3, 8, 6, -4, 4};`
    public static void CheckArrayContainsOnlyPositiveNumbers()
    {
      int[] arr = { 5, 7, 3, 8, 6, -4, 4 };
      foreach (var num in arr)
      {
        if (num < 0)
        {
          Console.WriteLine("Array contains negative numbers.");
          return;
        }
      }
      Console.WriteLine("Array contains only positive numbers.");
    }

    //  57. Program to Print leader elements in the array (All elements to its right must be smaller to Leader element): `int arr[] = {10, 9, 14, 23, 15, 0, 9};`
    public static void PrintLeaderElements()
    {
      int[] arr = { 10, 9, 14, 23, 15, 0, 9 };
      Console.WriteLine("Leader elements in the array:");

      for (int i = 0; i < arr.Length; i++)
      {
        bool isLeader = true;
        for (int j = i + 1; j < arr.Length; j++)
        {
          if (arr[j] >= arr[i])
          {
            isLeader = false;
            break;
          }
        }
        if (isLeader) Console.Write($"{arr[i]} ");
      }
    }

    //  58. Program to find the largest difference pair in the sequence from the given sorted Array: `int[] arr = {5, 7, 13, 15, 16, 19, 34};` o/p: Largest difference pair: {19, 34}
    public static void FindLargestDifferencePairInSortedArray()
    {
      int[] arr = { 5, 7, 13, 15, 16, 19, 34 };
      int smallest = arr[0];
      int largest = arr[arr.Length - 1];

      Console.WriteLine($"Largest difference pair: {{{smallest}, {largest}}}");
    }

    /* ### Two Dimensional Array Programs */

    //  59. Define 3x3 dimensional array with elements:
    public static void Declare3DArr()
    {
      int[,] arr = new int[3, 3];
    }

    //  60. Display elements of 3x3 dimensional array: `int[][] array = {{7, 5, 2},{5, 4, 8},{9, 2, 6}};`
    public static void Display3DArrayElements()
    {
      int[,] array = { { 7, 5, 2 }, { 5, 4, 8 }, { 9, 2, 6 } };

      for (int i = 0; i < array.GetLength(0); i++)
      {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write($"{array[i, j]} ");
        }
      }
    }

    //  61. Display smallest element in 3x3 dimensional array: `int[][] array = {{7, 5, 2},{5, 4, 8},{9, 2, 6}};`
    public static void SmallestEleIn2DArr()
    {
      int[,] array = { { 7, 5, 2 }, { 5, 4, 8 }, { 9, 2, 6 } };
      int smallest = int.MaxValue;

      for (int i = 0; i < array.GetLength(0); i++)
      {
        for (var j = 0; j < array.GetLength(1); j++)
        {
          if (array[i, j] < smallest) smallest = array[i, j];
        }
      }
      Console.WriteLine($"Smallest element is: {smallest}");
    }

    //  62. Display largest element in 3x3 dimensional array: `int[][] array = {{7, 5, 2},{5, 4, 8},{9, 2, 6}};`
    public static void BiggestEleIn2DAr()
    {
      int[,] array = { { 7, 5, 2 }, { 5, 4, 8 }, { 9, 2, 6 } };
      int biggest = int.MinValue;

      for (int i = 0; i < array.GetLength(0); i++)
      {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          if (array[i, j] > biggest) biggest = array[i, j];
        }
      }
      Console.WriteLine($"biggest element is: {biggest}");
    }

    //  63. Display sum of each row in the given matrix: `int[][] array = {{7, 5, 2},{5, 4, 8},{9, 2, 6}};`
    public static void SumOfEachRowIn2DMatrix()
    {
      int[,] arr = { { 7, 5, 2 }, { 5, 4, 8 }, { 9, 2, 6 } };
      for (int i = 0; i < arr.GetLength(0); i++)
      {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
          sum += arr[i, j];
        }
        Console.WriteLine($"sum of row {i} is: {sum}");
      }
    }

    //  64. Display sum of each column in the given matrix: `int[][] array = {{7, 5, 2},{5, 4, 8},{9, 2, 6}};`
    public static void SumOfEachColumnIn2DMatrix()
    {
      int[,] arr = { { 7, 5, 2 }, { 5, 4, 8 }, { 9, 2, 6 } };

      for (int i = 0; i < arr.GetLength(0); i++)
      {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
          sum += arr[j, i];
        }
        Console.WriteLine($"Sum of clumn {i} is: {sum}");
      }
    }

    //  65. Display Max row sum in the given matrix: `int[][] array = {{7, 5, 2},{5, 4, 8},{9, 2, 6}};`
    public static void MaxRowSum()
    {
      int[,] arr = { { 7, 5, 2 }, { 5, 4, 8 }, { 9, 2, 6 } };
      int maxSum = int.MinValue;

      for (int i = 0; i < arr.GetLength(0); i++)
      {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
          sum += arr[i, j];
        }

        if (maxSum < sum) maxSum = sum;
      }

      Console.WriteLine($"Max row sum is: {maxSum}");
    }

    /*  66. Transpose of matrix: `int[][] array = {{7, 5, 2},{5, 4, 8},{9, 2, 6}};`
        => If we change rows to columns and columns to rows, then that matrix is called as transpose of the given matrix.
          
          ->  7, 5, 2
              5, 4, 8
              9, 2, 6
          
          -> Transpose of above matrix will be: 
              7, 5, 9
              5, 4, 2
              2, 8, 6
          
          -> Indeces: 
              0,0  0,1   0,2
              1,0  1,1   1,2
              2,0  2,1   2,2

          -> Approach1: If matrix itself shoild be updated, then swap elements if row != col
          -> Approach2: If new matrix is needed, then create a new array and insert rows to cols and cols to rows
    */
    public static void TransposeOfGivenMatrix()
    {
      int[,] arr = { { 7, 5, 2 }, { 5, 4, 8 }, { 9, 2, 6 } };
      int[,] transposeArr = new int[arr.GetLength(0), arr.GetLength(1)];

      for (int i = 0; i < arr.GetLength(0); i++)
      {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
          transposeArr[j, i] = arr[i, j];
        }
      }

      for (int row = 0; row < arr.GetLength(0); row++)
      {
        for (var col = 0; col < arr.GetLength(1); col++)
        {
          Console.Write($"{arr[row, col]} ");
        }
        Console.WriteLine();
      }
    }

    //  67. Matrix addition program:
    public static void AddTwo2DMatrices()
    {
      int[,] matrix1 = new int[3, 3];
      int[,] matrix2 = new int[3, 3];
      int[,] result = new int[3, 3];

      Console.WriteLine("Enter numbers for Matrix1: \n");
      for (int row = 0; row < matrix1.GetLength(0); row++)
      {
        Console.WriteLine($"Enter numbers for row {row}:");
        for (int col = 0; col < matrix1.GetLength(1); col++)
        {
          Console.Write($"Enter a number for column {col}: ");
          matrix1[row, col] = Convert.ToInt32(Console.ReadLine());
        }
      }

      Console.WriteLine("Enter numbers for Matrix2: \n");
      for (int row = 0; row < matrix2.GetLength(0); row++)
      {
        Console.WriteLine($"Enter numbers for row {row}:");
        for (int col = 0; col < matrix2.GetLength(1); col++)
        {
          Console.Write($"Enter a number for column {col}: ");
          matrix2[row, col] = Convert.ToInt32(Console.ReadLine());
        }
      }

      for (int row = 0; row < result.GetLength(0); row++)
      {
        for (var col = 0; col < result.GetLength(1); col++)
        {
          result[row, col] = matrix1[row, col] + matrix2[row, col];
        }
      }

      for (var row = 0; row < result.GetLength(0); row++)
      {
        for (var col = 0; col < matrix1.GetLength(1); col++)
        {
          Console.Write($"{matrix1[row, col]} ");
        }
        Console.Write("\t");
        for (var col = 0; col < matrix2.GetLength(1); col++)
        {
          Console.Write($"{matrix2[row, col]} ");
        }
        Console.WriteLine();
      }

      Console.WriteLine();
      Console.WriteLine("Sum of matrix1 and matrix2 is: ");

      for (int row = 0; row < result.GetLength(0); row++)
      {
        for (var col = 0; col < result.GetLength(1); col++)
        {
          Console.Write($"{result[row, col]} ");
        }
        Console.WriteLine();
      }
    }

    /*  68. Matrix Multiplication Program:
          => Matrix multiplication:

            -> Matrix1:
                1 2 3
                4 5 6
                7 8 9
            
            -> Matrix2:
                3 2 1
                6 5 4
                9 8 7
            
            -> Multiplication Result:
                (1x3 + 2x6 + 3x9) (1x2 + 2x5 + 3x8) (1x1 + 2x4 + 3x7)      3+12+27   2+10+24   1+8+21       72   36   30
                (4x3 + 5x6 + 6x9) (4x2 + 5x5 + 6x8) (4x1 + 5x4 + 6x7)  =>  12+30+54  8+25+48   4+20+42  =>  96   171  66
                (7x3 + 8x6 + 9x9) (7x2 + 8x5 + 9x8) (7x1 + 8x4 + 9x7)      21+48+81  14+40+72  7+32+63      150  136  102
            
            -> Formula:
                a11*b11 + a12*b21 + a13*b31   a11*b12 + a12*b22 + a13*b32   a11*b13 + a12*b23 + a13*b33
                a21*b11 + a22*b21 + a23*b31   a21*b12 + a22*b22 + a23*b32   a21*b13 + a22*b23 + a23*b33
                a31*b11 + a32*b21 + a33*b31   a31*b12 + a32*b22 + a33*b32   a31*b13 + a32*b23 + a33*b33
    */
    public static void MatrixMultiplication()
    {
      int[,] mat1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
      int[,] mat2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
      int[,] result = new int[3, 3];

      for (int i = 0; i < result.GetLength(0); i++)
      {
        for (int j = 0; j < result.GetLength(1); j++)
        {
          result[i, j] = (mat1[i, 0] * mat2[0, j]) + (mat1[i, 1] * mat2[1, j]) + (mat1[i, 2] * mat2[2, j]);
        }
      }

      for (int i = 0; i < result.GetLength(0); i++)
      {
        for (int j = 0; j < result.GetLength(1); j++)
        {
          Console.Write($"{result[i, j]} ");
        }
        Console.WriteLine();
      }

    }



    public static void RunTests()
    {
      Console.WriteLine("\nArray Programs Execution:\n");

      // Basic Array Operations and Initialization
      // BasicOperations();

      // Array Iteration and Element Swapping
      // SumOfEvenElements();
      // DisplayElements();
      // SumOfElements();
      // EvenElements();
      // SumOfOddElements();
      // SwapFirstAndSecondElements();
      // SwapFirstAndLastElements();
      // SwapElementsAtSpecifiedLocations(2, 3);
      // SwapWithAdjacentElement(3);
      // DisplayLargestElement();
      // DisplaySmallestElement();

      // Intermediate Logic and Filtering
      // DisplayFirstEvenElement();
      // DisplayLastOddElement();
      // SwapSmallestAndLargestElements();
      // SwapFirstEvenAndLastOddElements();
      // DisplaySecondBiggestElement();
      // DisplaySecondSmallestElement();
      // CopyElements();
      // CreateNewArrayWithEvenNumbers();
      // CreateNewArrayWithOddNumbers();
      // CreateTwoNewArraysWithEvenAndOddNumbers();
      // CheckElementIsDuplicated(9);

      // Searching, Sorting, and Complex Tasks
      // Console.Write("Enter a number: ");
      // LinearSearch(Convert.ToInt32(Console.ReadLine()));
      // Console.Write("Enter a number: ");
      // BinarySearch(Convert.ToInt32(Console.ReadLine()));
      // SortArrayInAscendingOrder();
      // SortArrayInDescendingOrder();
      MergeTwoArrays();
      // ReadInputAndCreateAnArray();
      // DispalyPairWhoseSumIs10();
      // ReplaceAllDuplicatesWith0();
      // Further complex tasks can be added here

      // Two Dimensional Array Programs
      // Declare3DArr();
      // Display3DArrayElements();
      // SmallestEleIn2DArr();
      // BiggestEleIn2DAr();
      // SumOfEachRowIn2DMatrix();
      // SumOfEachColumnIn2DMatrix();
      // MaxRowSum();
      // TransposeOfGivenMatrix();
      // AddTwo2DMatrices();
      // MatrixMultiplication();

    }
  }
}