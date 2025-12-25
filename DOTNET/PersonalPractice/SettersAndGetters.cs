
namespace PersonalPractice
{
  class SettersAndGetters
  {
    private int _id;
    private string _name;
    private int _age;

    public void SetId(int id)
    {
      if (id <= 0) throw new Exception("ID cannot be less than or equal to zero");
      _id = id;
    }

    public int GetId()
    {
      return _id;
    }

    public void SetName(string name)
    {
      if (string.IsNullOrEmpty(name.Trim())) throw new Exception("Name cannot be null or empty!");
      _name = name.Trim();
    }

    public string GetName()
    {
      return _name;
    }

    public void SetAge(int age)
    {
      if (age < 18) throw new Exception("Age must be more than 18");
      _age = age;
    }

    public int GetAge()
    {
      return _age;
    }

    public static void Run()
    {
      SettersAndGetters sg = new SettersAndGetters();
      // sg.SetId(0); // throws an error
      // sg.SetId(-10); // throws an error
      sg.SetId(105); // works fine
      Console.WriteLine(sg.GetId());

      // sg.SetName(""); // throws an error
      // sg.SetName(null); // throws an error
      // sg.SetName("   "); // this one is getting accepted. Need to trim it. It is working
      // Console.WriteLine(sg.GetName());
      sg.SetName("    Kiran    ");
      Console.WriteLine(sg.GetName());

      // sg.SetAge(12); // throws an error
      sg.SetAge(25);
      Console.WriteLine(sg.GetAge());
    }
  }
}
