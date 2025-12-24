namespace Patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n############ Patterns ############\n");
            Console.WriteLine("Enter any number\n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Squares.RunTests(n);
            Triangles.RunTests(n);
        }
    }
}