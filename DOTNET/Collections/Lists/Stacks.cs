using System.Collections;
using System.Data;

namespace CollectionsFramework
{
  /* --------------------------------------------------------------
      Stacks are heterogenious: can store different types of data
   --------------------------------------------------------------*/
  class Stacks
  {
    Stack stack;

    public Stacks()
    {
      stack = new Stack();
    }

    // add item
    public void addItem(Object num)
    {
      stack.Push(num);
    }

    // find length of the stack
    public void getSize()
    {
      Console.WriteLine($"The size of the stack is: {stack.Count}");
    }

    // get top item from the stack
    public void getTopElement()
    {
      Console.WriteLine($"The top element is: {stack.Peek()}");
    }

    // get item
    public void getItem()
    {
      stack.Pop();
    }

    //  chack if element present in the stack
    public bool isExists(Object obj)
    {
      return stack.Contains(obj);
    }
    

    // Update item

    // remove item
    public Object removeTopElement()
    {
      return stack.Pop();
    }

    // clear the stack
    public void clearTheStack()
    {
      stack.Clear();
      Console.WriteLine("The stack is cleared!");
    }

    // print stack
    public void PrintStack()
    {
      foreach (var item in stack)
      {
        Console.Write($"{item} ");
      }
      Console.WriteLine("\n");
    }

    public void RunTests()
    {
      addItem(5);
      addItem("Hello");
      addItem(4.258);
      addItem('a');
      addItem(true);
      addItem(4.52f);
      PrintStack();
      getTopElement();
      Console.WriteLine($"The item removed: {removeTopElement()}");
      PrintStack();
      Console.WriteLine($"Is the stack contains Hello: {isExists("Hello")}");
      Console.WriteLine($"Is the stack contains Hallo: {isExists("Hallo")}");
      // PrintStack();
      // clearTheStack();
      // PrintStack();
      getSize();
    }
  }
}