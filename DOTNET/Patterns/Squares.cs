namespace Patterns
{
    class Squares
    {
        public void PrintSquareOfStars(int n)
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

        public void PrintSquareOfSymbols(char symbol, int n)
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

        public void PrintSquareOfNumberSequence1(int n)
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

        public void PrintSquareOfNumberSequence2(int n)
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

        public void PrintSquareOfNumberSequence3(int n)
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

        public void PrintSquareOfNumberSequence4(int n)
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

        public void PrintSquareOfNumberSequence5(int n)
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

        public void PrintSquareOfNumberSequence6(int n)
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

        public void PrintSquareOfNumberSequence7(int n)
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
        // public void PrintSquareOfCharSequence1(int n)
        // {
        //     System.Console.WriteLine("\n");
        //     for (int i = n; i > 0; i--)
        //     {
        //         for (int j = 0; j < n; j++)
        //         {
        //             Console.Write($"{i} ");
        //         }
        //         Console.WriteLine();
        //     }
        // }

        public void PrintSquareOfSymbolSequence1(int n)
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

        public void PrintSquareOfSymbolSequence2(int n)
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

    }
}