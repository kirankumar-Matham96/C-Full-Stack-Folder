using System.Collections;

namespace CollectionsFramework
{
  /*
    NOTE: ArayLists are Heterogenious in nature. They can store any type of data...
  */
  class ArrayLists
  {
    private ArrayList numericList;
    private ArrayList stringList;
    private ArrayList genericList;

    private ArrayList copyNumericList;
    private ArrayList copyStringList;
    private int[] arr;

    public ArrayLists()
    {
      numericList = new ArrayList();
      stringList = new ArrayList();
      genericList = new ArrayList();
      arr = new int[20];
    }

    public void InsertElement(int e)
    {
      numericList.Add(e);
    }

    public void getLength(ArrayList list)
    {
      Console.WriteLine(list.Count);
    }

    public void InsertElement2(string e)
    {
      stringList.Add(e);
    }

    public void InsertElement2(char e)
    {
      stringList.Add(e);
    }

    public void UpdateElement(int e)
    {
      int index = numericList.IndexOf(e);
      // need to see how to update or replace the element in ArrayList
    }

    public void RemoveElement(int e)
    {
      numericList.Remove(e);
    }

    public void RemoveElementAtIndex(int index)
    {
      numericList.RemoveAt(index);
    }

    public void RemoveRange(int range, int count)
    {
      numericList.RemoveRange(range, count);
    }

    public void RemoveAllElements(ArrayList list)
    {
      list.Clear();
      Console.Write("The list is cleared: ");
      PrintList(list);
    }

    public int FindElement(int e)
    {
      int index = numericList.Contains(e) ? numericList.IndexOf(e) : -1;
      return index;
    }

    public void CheckIfElementExists(ArrayList list, Object? element)
    {
      Console.WriteLine(list.Contains(element));
    }

    public void SortNumericList()
    {
      numericList.Sort();
    }

    public void SortNonNumericList()
    {
      stringList.Sort();
    }

    public void CopyTheList(ArrayList source, ArrayList destination)
    {
      destination = (ArrayList)source.Clone();
      PrintList(destination);
    }

    public void CopyTheListToExistingArray(ArrayList source, int[] destination)
    {
      source.CopyTo(destination);
    }

    public void PrintList(ArrayList list)
    {
      foreach (var item in list)
      {
        Console.Write($"{item} ");
      }
      Console.WriteLine("\n");
    }


    public void RunTests()
    {
      /* Inserting */
      InsertElement(4);
      InsertElement(5);
      InsertElement(3);
      InsertElement(4);
      InsertElement(5);
      InsertElement(3);
      InsertElement(1);
      InsertElement(2);
      PrintList(numericList);

      InsertElement2("Hello");
      InsertElement2("d");
      InsertElement2("This is a string too");
      InsertElement2("c");
      PrintList(stringList);

      /* Updating */
      // UpdateElement(3);

      /* Removing */
      RemoveElement(2);
      PrintList(numericList);
      RemoveElementAtIndex(0);
      PrintList(numericList);
      RemoveRange(0, 2);
      PrintList(numericList);

      /* Finding Index */
      int index = FindElement(4);
      Console.WriteLine($"Index of the element 4 is: {index}");
      PrintList(numericList);

      /* Sorting */
      SortNumericList();
      PrintList(numericList);
      SortNonNumericList();
      PrintList(stringList);

      /* Inserting different types of data */
      genericList.Add(3);
      genericList.Add("Hello");
      genericList.Add("5.6329");
      genericList.Add('c');
      genericList.Add(true);
      genericList.Add(null);
      genericList.Add(3.14f);
      PrintList(genericList);

      /* Printing the elements by index numbers */
      Console.WriteLine($"element in genericList list at index 2 is: {genericList[2]}");
      Console.WriteLine($"element in numericList list at index 2 is: {numericList[2]}");
      Console.WriteLine($"element in stringList list at index 2 is: {stringList[2]}");

      /* inserting elements at a particular index */
      genericList.Insert(2, "How are you?");
      PrintList(genericList);
      genericList.Insert(2, 5);
      PrintList(genericList);
      genericList.Insert(2, 'a');
      PrintList(genericList);

      /* Inserting an entire collection into an ArrayList */
      genericList.InsertRange(0, numericList);
      PrintList(genericList);
      genericList.InsertRange(5, stringList);
      PrintList(genericList);

      /* Finding length of an ArrayList */
      Console.Write($"Lenght of the numericList ArrayList: ");
      getLength(numericList);
      Console.Write($"Lenght of the stringList ArrayList: ");
      getLength(stringList);
      Console.Write($"Lenght of the genericList ArrayList: ");
      getLength(genericList);

      /* Removing all the elements from the ArrayList */
      // RemoveAllElements(genericList);

      /* Checking if element exists in the ArrayList */
      CheckIfElementExists(numericList, 5);
      CheckIfElementExists(stringList, "Hello");
      CheckIfElementExists(genericList, false);
      CheckIfElementExists(genericList, true);

      /* Copying non-generic array */
      CopyTheList(numericList, copyNumericList);
      CopyTheList(stringList, copyStringList);

      /* Copying the non-generic array to existing array */
      CopyTheListToExistingArray(numericList, arr);
      foreach (var i in arr) if (i != 0) Console.Write($"{i} ");
    }
  }
}