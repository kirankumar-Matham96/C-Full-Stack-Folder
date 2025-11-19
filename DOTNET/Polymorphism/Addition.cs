namespace Polymorphism
{
    /**
     * Demonstrates method overloading in C#.
     * The Addition class contains multiple 'add' methods with different parameters.
     */
    class Addition
    {
        public int add(int x)
        {
            return x + 5;
        }
        public int add(int x, int y)
        {
            return x + y;
        }
        public int add(int x, int y, int z)
        {
            return x + y + z;
        }
        public string add(string a, string b)
        {
            return a + b;
        }
    }
}