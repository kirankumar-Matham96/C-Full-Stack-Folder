namespace Ploymorphism
{
    /** 
     * Interface representing an animal that can make a sound.
     * example for method overriding (runtime, dynamic, late binding) 
     */
    interface IAnimal
    {
        void MakeSound();
    }

    class Cat : IAnimal
    {
        public void MakeSound()
        {
            System.Console.WriteLine("Mew!");
        }
    }

    class Dog : IAnimal
    {
        public void MakeSound()
        {
            System.Console.WriteLine("Woof!");
        }
    }

    class Cow : IAnimal
    {
        public void MakeSound()
        {
            System.Console.WriteLine("Mooo!");
        }
    }
}