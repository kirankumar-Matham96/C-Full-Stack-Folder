using System.Runtime.InteropServices.Marshalling;

namespace Ploymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("\n##### Welcome to Polymorphism #####\n");

            Addition add = new Addition();

            System.Console.WriteLine(add.add(5));
            System.Console.WriteLine(add.add(5, 10));
            System.Console.WriteLine(add.add(5, 10, 15));
            System.Console.WriteLine(add.add("Hello ", "Raju"));

            Cat cat = new Cat();
            cat.MakeSound();

            Dog dog = new Dog();
            dog.MakeSound();

            Cow cow = new Cow();
            cow.MakeSound();
        }
    }
}