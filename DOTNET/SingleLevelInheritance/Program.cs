namespace SingleLevelInheritance
{
    /* One Base Class and One Derived class -> Single Level Inheritance */
    class Program
    {
        public static void Main(String[] args)
        {
            System.Console.WriteLine("##### Single Level Inheritance #####");

            Teacher t1 = new Teacher(101, "Upadhyay", 35, "male", "Sanskrit", 50000);
            System.Console.WriteLine($"\nSubject: {t1.getMainSubject()}");
            System.Console.WriteLine(t1.ToString());
            t1.setAge(36);
            System.Console.WriteLine(t1.ToString());
        }
    }
}