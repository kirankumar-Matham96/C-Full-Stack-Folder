namespace MultiLevelInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("\n ##### Multi Level Inheritance #####\n");
            SportsCar sp = new SportsCar(4, 2, "petrol", "dual", "masarati", 5000, 264);

            System.Console.WriteLine(sp.getTires());
        }
    }
}