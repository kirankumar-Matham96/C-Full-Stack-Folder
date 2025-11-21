namespace Patterns
{
    class Triangles
    {
        public void PrintTriangleSequence1(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence2(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write($"{j + 1} ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence3(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write($"{i + 1} ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence4(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(j % 2 == 0 ? "1 " : "0 ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence5(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(i % 2 == 0 ? "1 " : "0 ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence6(int numberOfLines)
        {
            Console.WriteLine("\n");
            int count = numberOfLines;
            for (int i = 0; i < numberOfLines; i++)
            {
                count = numberOfLines - i;
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write($"{count} ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence7(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}