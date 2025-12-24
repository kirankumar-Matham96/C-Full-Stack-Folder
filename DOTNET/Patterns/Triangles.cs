namespace Patterns
{
    public class Triangles
    {
        public static void PrintTriangleSequence1(int numberOfLines)
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

        public static void PrintTriangleSequence2(int numberOfLines)
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

        public static void PrintTriangleSequence3(int numberOfLines)
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

        public static void PrintTriangleSequence4(int numberOfLines)
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

        public static void PrintTriangleSequence5(int numberOfLines)
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

        public static void PrintTriangleSequence6(int numberOfLines)
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

        public static void PrintTriangleSequence7(int numberOfLines)
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

        public static void PrintTriangleSequence8(int numberOfLines)
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

        public static void PrintTriangleSequence9(int numberOfLines)
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

        public static void PrintTriangleSequence10(int numberOfLines)
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

        public static void PrintTriangleSequence11(int numberOfLines)
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

        public static void PrintTriangleSequence12(int numberOfLines)
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

        public static void PrintTriangleSequence13(int numberOfLines)
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

        public static void PrintTriangleSequence14(int numberOfLines)
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

        public static void PrintTriangleSequence15(int numberOfLines)
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

        public static void PrintTriangleSequence16(int numberOfLines)
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

        public static void PrintTriangleSequence17(int numberOfLines)
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

        public static void PrintTriangleSequence18(int numberOfLines)
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

        public static void PrintTriangleSequence19(int numberOfLines)
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

        public static void PrintTriangleSequence20(int numberOfLines)
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

        public static void PrintTriangleSequence21(int numberOfLines)
        {

            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int spaces = numberOfLines - 1; spaces >= i; spaces--)
                {
                    Console.Write($"  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                for (int k = i - 1; k > 0; k--)
                {
                    Console.Write($"{k} ");
                }
                Console.WriteLine();
            }

        }

        public static void PrintTriangleSequence22(int numberOfLines)
        {
            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int spaces = numberOfLines - i; spaces > 0; spaces--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i}");
                }
                for (int k = 2; k <= i; k++)
                {
                    Console.Write($"{i}");
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangleSequence23(int numberOfLines)
        {
            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int spaces = 1; spaces <= i; spaces++)
                {
                    Console.Write($"  ");
                }
                for (int j = 1; j <= numberOfLines - i; j++)
                {
                    Console.Write($"{j} ");
                }
                for (int j = numberOfLines - i + 1; j > 0; j--)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        /* '*' patterns */
        public static void PrintTriangleShape1(int numberOfLines)
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

        public static void PrintTriangleShape2(int numberOfLines)
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

        public static void PrintTriangleShape3(int numberOfLines = 5)
        {
            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int k = 1; k <= numberOfLines * 2 - 1; k++)
                {
                    if (i + k == numberOfLines + 1 || k - i == numberOfLines - 1 || i == numberOfLines)
                    {
                        Console.Write("* ");
                    }
                    else Console.Write("  ");
                }
                System.Console.WriteLine();
            }
        }

        public static void PrintTriangleShape4(int numberOfLines = 5)
        {
            for (int i = 1; i <= numberOfLines + 2; i++)
            {
                for (int j = 1; j <= numberOfLines + 3; j++)
                {
                    if (i == 1 || j == 1 || i == numberOfLines + 2 || j == numberOfLines + 3) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangleShape5(int numberOfLines = 5)
        {
            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int j = 1; j <= numberOfLines * 2 - 1; j++)
                {
                    if (i == 1 || i == j || i + j == numberOfLines * 2) Console.Write("* ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangleShape6(int numberOfLines = 5)
        {
            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == numberOfLines || j == 1 || i == j) Console.Write("* ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangleShape7(int numberOfLines = 5)
        {
            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int j = 1; j <= numberOfLines; j++)
                {
                    if (i == numberOfLines || j == numberOfLines || i + j >= numberOfLines + 1) Console.Write("* ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangleShape8(int numberOfLines = 5)
        {
            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int j = 1; j <= numberOfLines; j++)
                {
                    if (i == 1 || j == numberOfLines || i == j) Console.Write("* ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangleShape9(int numberOfLines = 5)
        {
            string spaces = "";
            for (int i = numberOfLines; i > 0; i--)
            {
                Console.Write(spaces);
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                spaces += "  ";
                Console.WriteLine();
            }
        }

        public static void PrintTriangleShape10(int numberOfLines = 5)
        {
            string spaces = "";
            for (int i = numberOfLines; i > 0; i--)
            {
                Console.Write(spaces);
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                spaces += " ";
                Console.WriteLine();
            }
        }

        public static void PrintTriangleShape11(int numberOfLines = 5)
        {
            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int j = numberOfLines - i; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangleShape12(int numberOfLines = 5)
        {
            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int spaces = numberOfLines - i; spaces > 0; spaces--)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int spaces = i - 1; spaces > 0; spaces--)
                {
                    Console.Write("  ");
                }
                for (int j = numberOfLines - i; j >= 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangleShape13(int numberOfLines = 5)
        {
            for (int i = 0; i <= numberOfLines; i++)
            {
                Console.WriteLine();
                for (int j = numberOfLines - i; j > 0; j--)
                {
                    Console.Write("* ");
                }
            }
            for (int i = 2; i <= numberOfLines; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintTriangleShape14(int numberOfLines = 5)
        {
            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int spaces = numberOfLines - i; spaces > 0; spaces--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = numberOfLines - 1; i > 0; i--)
            {
                for (int spaces = 1; spaces <= numberOfLines - i; spaces++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        /* Alphabet patterns */

        public static void PrintAlphabetPattern1(int numberOfLines)
        {
            for (int i = 1; i <= numberOfLines; i++)
            {
                char c = 'A';
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{c} ");
                    c++;
                }
                Console.WriteLine();
            }
        }

        public static void PrintAlphabetPattern2(int numberOfLines)
        {
            for (int i = 1; i <= numberOfLines; i++)
            {
                char c = (char)((int)('A') + i - 1);
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{c} ");
                    c--;
                }
                Console.WriteLine();
            }
        }

        public static void PrintAlphabetPattern3(int numberOfLines)
        {
            for (int i = 1; i <= numberOfLines; i++)
            {
                char c = (char)((int)('A') + numberOfLines - 1 - (i - 1));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{c} ");
                    c++;
                }
                Console.WriteLine();
            }
        }

        public static void PrintAlphabetPattern4(int numberOfLines)
        {
            for (int i = numberOfLines; i > 0; i--)
            {
                char c = 'A';
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{c} ");
                    c++;
                }
                Console.WriteLine();
            }
        }

        public static void PrintAlphabetPattern5(int numberOfLines)
        {
            int k = 0;
            for (int i = numberOfLines; i > 0; i--)
            {
                char c = (char)((int)('A') + k);
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{c} ");
                    c++;
                }
                k++;
                Console.WriteLine();
            }
        }

        public static void PrintAlphabetPattern6(int numberOfLines)
        {
            for (int i = numberOfLines; i > 0; i--)
            {
                char c = (char)((int)('A') + numberOfLines - 1);
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{c} ");
                    c--;
                }
                Console.WriteLine();
            }
        }

        public static void PrintAlphabetPattern7(int numberOfLines)
        {
            for (int i = numberOfLines; i > 0; i--)
            {
                char c = (char)((int)'A' + i - 1);
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{c} ");
                    c--;
                }
                Console.WriteLine();
            }
        }

        public static void RunTests(int n)
        {
            // Triangles.PrintTriangleSequence1(n);
            // Triangles.PrintTriangleSequence2(n);
            // Triangles.PrintTriangleSequence3(n);
            // Triangles.PrintTriangleSequence4(n);
            // Triangles.PrintTriangleSequence5(n);
            // Triangles.PrintTriangleSequence6(n);
            // Triangles.PrintTriangleSequence7(n);
            // Triangles.PrintTriangleSequence8(n);
            // Triangles.PrintTriangleSequence9(n);
            // Triangles.PrintTriangleSequence10(n);
            // Triangles.PrintTriangleSequence11(n);
            // Triangles.PrintTriangleSequence12(n);
            // Triangles.PrintTriangleSequence13(n);
            // Triangles.PrintTriangleSequence14(n);
            // Triangles.PrintTriangleSequence15(n);
            // Triangles.PrintTriangleSequence16(n);
            // Triangles.PrintTriangleSequence17(n);
            // Triangles.PrintTriangleSequence18(n);
            // Triangles.PrintTriangleSequence19(n);
            // Triangles.PrintTriangleSequence20(n);
            // Triangles.PrintTriangleSequence21(n);
            // Triangles.PrintTriangleSequence22(n);
            // Triangles.PrintTriangleSequence23(n);

            // Triangles.PrintTriangleShape1(n);
            // Triangles.PrintTriangleShape2(n);
            // Triangles.PrintTriangleShape3(n);
            // Triangles.PrintTriangleShape4(n);
            // Triangles.PrintTriangleShape5(n);
            // Triangles.PrintTriangleShape6(n);
            // Triangles.PrintTriangleShape7(n);
            // Triangles.PrintTriangleShape8(n);
            // Triangles.PrintTriangleShape9(n);
            // Triangles.PrintTriangleShape10(n);
            // Triangles.PrintTriangleShape11(n);
            // Triangles.PrintTriangleShape12(n);
            // Triangles.PrintTriangleShape13(n);
            Triangles.PrintTriangleShape14(n);

            // Triangles.PrintAlphabetPattern1(n);
            // System.Console.WriteLine();
            // Triangles.PrintAlphabetPattern2(n);
            // System.Console.WriteLine();
            // Triangles.PrintAlphabetPattern3(n);
            // System.Console.WriteLine();
            // Triangles.PrintAlphabetPattern4(n);
            // System.Console.WriteLine();
            // Triangles.PrintAlphabetPattern5(n);
            // System.Console.WriteLine();
            // Triangles.PrintAlphabetPattern6(n);
            // System.Console.WriteLine();
            // Triangles.PrintAlphabetPattern7(n);
        }

    }
}