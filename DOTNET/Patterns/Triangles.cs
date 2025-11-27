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
            int count = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (count >= 9) count = 0;
                    count++;
                    Console.Write($"{count} ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence8(int numberOfLines)
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

        public void PrintTriangleSequence9(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = numberOfLines - i; j <= numberOfLines; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence10(int numberOfLines)
        {
            Console.WriteLine("\n");
            int count = numberOfLines;
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write($"{count} ");
                    count--;
                }
                count = numberOfLines;
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence11(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = numberOfLines - i; j > 0; j--)
                {
                    Console.Write($"{i + 1} ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence12(int numberOfLines)
        {
            Console.WriteLine("\n");
            int count = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = numberOfLines - i; j > 0; j--)
                {
                    count++;
                    Console.Write($"{count} ");
                }
                count = 0;
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence13(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = i + 1; j <= numberOfLines; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence14(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfLines - i; j++)
                {
                    Console.Write($"{j + 1} ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence15(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = i + 1; j <= numberOfLines; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence16(int numberOfLines)
        {
            Console.WriteLine("\n");
            int count = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfLines - i; j++)
                {
                    if (count >= 9) count = 0;
                    count++;
                    Console.Write($"{count} ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence17(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfLines - i; j++)
                {
                    Console.Write(i % 2 == 0 ? $"1 " : "0 ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence18(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = numberOfLines - i; j > 0; j--)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence19(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = numberOfLines; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleSequence20(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = numberOfLines; i > 0; i--)
            {
                for (int j = numberOfLines; j > numberOfLines - i; j--)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }


        /* '*' patterns */
        public void PrintTriangleShape1(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = numberOfLines - i; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void PrintTriangleShape2(int numberOfLines)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = numberOfLines - i; j > 0; j--)
                {
                    Console.Write("  ");
                }


                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("* ");
                }
                // Console.Write("* ");
                Console.WriteLine();

            }
        }
    }
}