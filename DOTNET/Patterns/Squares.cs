namespace Patterns
{
    public class Squares
    {
        public static void PrintSquareOfStars(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintSquareOfSymbols(char symbol, int n)
        {
            System.Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{symbol} ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintSquareOfNumberSequence1(int n)
        {
            System.Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintSquareOfNumberSequence2(int n)
        {
            System.Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{i + 1} ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintSquareOfNumberSequence3(int n)
        {
            System.Console.WriteLine("\n");
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    count++;
                    Console.Write($"{count} ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintSquareOfNumberSequence4(int n)
        {
            System.Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{1 + j + i} ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintSquareOfNumberSequence5(int n)
        {
            System.Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{j + 1} ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintSquareOfNumberSequence6(int n)
        {
            System.Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > 0; j--)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintSquareOfNumberSequence7(int n)
        {
            System.Console.WriteLine("\n");
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }

        /* need to convert the integers to characters */
        public static void PrintSquareOfCharSequence1(int n)
        {
            Console.WriteLine("\n");
            char c = 'A';
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write($"{c} ");
                }
                c++;
                Console.WriteLine();
            }
        }

        public static void PrintSquareOfCharSequence2(int n)
        {
            Console.WriteLine("\n");
            char c = (char)((int)'A' + n - 1);
            for (int i = n; i > 0; i--)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write($"{c} ");
                }
                c--;
                Console.WriteLine();
            }
        }

        public static void PrintSquareOfCharSequence3(int n)
        {
            Console.WriteLine("\n");
            for (int i = n; i > 0; i--)
            {
                char c = (char)((int)'A' + n - 1);
                for (int j = 1; j <= n; j++)
                {
                    Console.Write($"{c} ");
                    c--;
                }
                Console.WriteLine();
            }
        }

        public static void PrintSquareOfSymbolSequence1(int n)
        {
            System.Console.WriteLine("\n");
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(i % 2 == 0 ? "# " : "$ ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintSquareOfSymbolSequence2(int n)
        {
            System.Console.WriteLine("\n");
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(j % 2 != 0 ? "# " : "$ ");
                }
                Console.WriteLine();
            }
        }

        public static void RunTests(int n)
        {
            // Squares.PrintSquareOfStars(n);
            // Squares.PrintSquareOfSymbols('#', n);
            // Squares.PrintSquareOfSymbols('x', n);
            // Squares.PrintSquareOfSymbols('.', n);
            // Squares.PrintSquareOfSymbols('a', n);
            // Squares.PrintSquareOfSymbols('A', n);
            // Squares.PrintSquareOfSymbols('1', n);
            // Squares.PrintSquareOfSymbols('i', n);
            // Squares.PrintSquareOfNumberSequence1(n);
            // Squares.PrintSquareOfNumberSequence2(n);
            // Squares.PrintSquareOfNumberSequence3(n);
            // Squares.PrintSquareOfNumberSequence4(n);
            // Squares.PrintSquareOfNumberSequence5(n);
            // Squares.PrintSquareOfNumberSequence6(n);
            // Squares.PrintSquareOfNumberSequence7(n);
            // Squares.PrintSquareOfCharSequence1(n);
            // Squares.PrintSquareOfCharSequence2(n);
            Squares.PrintSquareOfCharSequence3(n);
            // Squares.PrintSquareOfSymbolSequence1(n);
            // Squares.PrintSquareOfSymbolSequence2(n);
        }
    }
}