namespace Patterns
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("\n############ Patterns ############\n");

            Squares squares = new Squares();
            Triangles triangles = new Triangles();

            System.Console.WriteLine("Enter any number\n");
            int n = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();

            squares.PrintSquareOfStars(n);
            squares.PrintSquareOfSymbols('#', n);
            squares.PrintSquareOfSymbols('x', n);
            squares.PrintSquareOfSymbols('.', n);
            squares.PrintSquareOfSymbols('a', n);
            squares.PrintSquareOfSymbols('A', n);
            squares.PrintSquareOfSymbols('1', n);
            squares.PrintSquareOfSymbols('i', n);
            squares.PrintSquareOfNumberSequence1(n);
            squares.PrintSquareOfNumberSequence2(n);
            squares.PrintSquareOfNumberSequence3(n);
            squares.PrintSquareOfNumberSequence4(n);
            squares.PrintSquareOfNumberSequence5(n);
            squares.PrintSquareOfNumberSequence6(n);
            squares.PrintSquareOfNumberSequence7(n);
            // squares.PrintSquareOfCharSequence1(n);
            squares.PrintSquareOfSymbolSequence1(n);
            squares.PrintSquareOfSymbolSequence2(n);

            triangles.PrintTriangleSequence1(n);
            triangles.PrintTriangleSequence2(n);
            triangles.PrintTriangleSequence3(n);
            triangles.PrintTriangleSequence4(n);
            triangles.PrintTriangleSequence5(n);
            triangles.PrintTriangleSequence6(n);
            triangles.PrintTriangleSequence7(n);
            triangles.PrintTriangleSequence8(n);
            triangles.PrintTriangleSequence9(n);
            triangles.PrintTriangleSequence10(n);
            triangles.PrintTriangleSequence11(n);
            triangles.PrintTriangleSequence12(n);
            triangles.PrintTriangleSequence13(n);
            triangles.PrintTriangleSequence14(n);
            triangles.PrintTriangleSequence15(n);
            triangles.PrintTriangleSequence16(n);
            triangles.PrintTriangleSequence17(n);
            triangles.PrintTriangleSequence18(n);
            triangles.PrintTriangleSequence19(n);
            triangles.PrintTriangleSequence20(n);
            triangles.PrintTriangleShape1(n);
            triangles.PrintTriangleShape2(n);
        }
    }
}