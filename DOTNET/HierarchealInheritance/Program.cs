namespace HierarchealInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("##### Hierarcheal Inheritance #####");

            Father son = new Son("Varun", "Talla", 12, "RSVVB");
            Father daughter = new Daughter("Sri Devi", "Talla", 18, "CBSC");

        }
    }
}