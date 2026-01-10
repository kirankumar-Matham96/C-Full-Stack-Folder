using System.Collections.Concurrent;

namespace Lists
{
  class Lists
  {
    // list declaration
    static List<string> genericList1 = new List<string> { "1235", "Hello", "Hi", "Welcome", "To", "Lists", "Program" };

    // list declaration
    static List<string> genericList2 = new List<string> { "This", "Is", "Second", "List" };

    // create a list and assign some values to it
    public static void CreateAndInsertIntoList(List<string> list)
    {

      while (true)
      {
        Console.Write("(To stop entering, press 'c')\nEnter a value: ");

        var input = Console.ReadLine().ToLower();

        if (input[0] == 'c') break;

        if (input.IsWhiteSpace()) throw new Exception("Please enter a value. No Empty spaces ara accepted!");

        list.Add(input);
      }
    }

    // display list items
    public static void DisplayListItems(List<string> list)
    {
      Console.WriteLine("The list elements are: ");
      foreach (string i in list)
      {
        Console.Write($"{i} ");
      }
      Console.WriteLine();
    }

    // sorting the list
    public static void SortingList()
    {
      genericList1.Sort();
      DisplayListItems(genericList1);
    }

    // binary search in the list
    public static void BinarySearchList(string el)
    {
      var element = genericList1.BinarySearch(el);
      Console.WriteLine($"Element {el} found at index: {element}");
    }

    // reversing the list
    public static void RevereseList()
    {
      genericList1.Reverse();
      DisplayListItems(genericList1);
    }

    // adding two lists
    public static void AddTwoLists()
    {
      genericList1.AddRange(genericList2);
      DisplayListItems(genericList1);
    }

    // converting list to array
    public static void ConvertListToArray(List<string> list)
    {
      string[] arr = list.ToArray();

      foreach (var i in arr) Console.Write($"{i} ");
    }

    // removing first element from the list
    public static void RemoveFirstElementFromList()
    {
      genericList1.RemoveAt(0);
      DisplayListItems(genericList1);
    }

    // getting size of the list
    public static void GetSizeOfList(List<string> list)
    {
      int size = list.Count();
      Console.WriteLine($"The size of the list is: {size}");
    }

    // removing last element from the list
    public static void RemoveLastElementFromList()
    {
      genericList1.RemoveAt(genericList1.Count - 1);
      DisplayListItems(genericList1);
    }

    // removing certain element from the list
    public static void RemoveCertainElementFromList()
    {
      genericList1.Remove("Hi");
      DisplayListItems(genericList1);
    }

    // removing range of elements from the list
    public static void RemoveRangeElementFromList()
    {
      genericList1.RemoveRange(2, 3);
      DisplayListItems(genericList1);
    }

    // clearing the list
    public static void ClearTheList()
    {
      genericList1.Clear();
      DisplayListItems(genericList1);
    }

    // main method
    public static void Main(string[] args)
    {
      Console.WriteLine(" ******************* Welcome to Lists Programs ******************* ");
      // CreateAndInsertIntoList(genericList1);
      // CreateAndInsertIntoList(genericList2);
      // DisplayListItems(genericList1);
      // DisplayListItems(genericList2);
      // SortingList();
      // BinarySearchList("Hello");
      // RevereseList();
      // AddTwoLists();
      // ConvertListToArray(genericList1);
      // RemoveFirstElementFromList();
      // GetSizeOfList(genericList1);
      // RemoveLastElementFromList();
      // RemoveCertainElementFromList();
      // RemoveRangeElementFromList();
      ClearTheList();
    }
  }
}