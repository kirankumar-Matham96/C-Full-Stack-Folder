namespace PersonalPractice
{
  class SettersAndGettersWithProperties
  {
    private int _id;
    private string _name;
    private int _age;

    public int Id
    {
      set
      {
        if (value <= 0) throw new Exception("Id cannot be zero or negative");
        _id = value;
      }
      get
      {
        return _id;
      }
    }

    public string Name
    {
      set
      {
        if (string.IsNullOrEmpty(value.Trim())) throw new Exception("Name must not be empty or null");
        _name = value.Trim();
      }
      get
      {
        return _name;
      }
    }

    public int Age
    {
      set
      {
        if (value < 18) throw new Exception("Age must be 18 or above!");
        _age = value;
      }
      get
      {
        return _age;
      }
    }

    public static void Run()
    {
      SettersAndGettersWithProperties sgp = new SettersAndGettersWithProperties();
      // sgp.Id = 0; // throws an error
      // sgp.Id = -10; // throws an error
      sgp.Id = 105; // works fine
      Console.WriteLine(sgp.Id);

      // sgp.Name = ""; // throws an error
      // sgp.Name = null; // throws an error
      // sgp.Name = "   "; // this one is getting accepted. Need to trim it. It is working
      // Console.WriteLine(sgp.Name);
      sgp.Name = "    Kiran    ";
      Console.WriteLine(sgp.Name);

      // sgp.Age = 12; // throws an error
      sgp.Age = 25;
      Console.WriteLine(sgp.Age);
    }
  }
}