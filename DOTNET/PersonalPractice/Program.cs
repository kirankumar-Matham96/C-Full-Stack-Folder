using System;
using System.Linq;
using System.IO;

namespace PersonalPractice
{
  class Program
  {
    public static void Main(string[] args)
    {

      /* Setters and Getters */
      // SettersAndGetters.Run();

      /* Setters and Getters with properties */
      // SettersAndGettersWithProperties.Run();

      /* Setters and Getters with Shorthand Properties notation */
      // ShortHandGettersAndSetters.Run();

      /* Strings */
      // Strings.Run();

      /* Arrays */
      // Arrays.Run();

      /* Methods */
      // Methods.Run();

      /* Working with Files */
      // Files.Run();

      /* Nullable & Null Coalacing */
      /*
          // nullable: other data types in c# cannot hold null values. To make them hold null, we can use nullable operators
          int? i = null; // Syntax: <data_type>? <identifier> = null;

          // null-coalacing: If we want to store null values to non nullable variables, we can use it
          int j = i ?? 0; // Syntax: <data_type> <identifier> = <nullable_variable> ?? <default_value_if_the_value_is_null>
      */
    }

    /* Destructors */
    ~Program()
    {
      Console.WriteLine("Destructor is called...");
      // no params and returns
      // No need to call it
      // It will be called by the garbage collector by default
      // It is used to remove/close all the resources used in the life time of the class.
    }
  }
}