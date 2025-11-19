using System.Runtime.CompilerServices;

namespace OOPs
{
    public class PracticeMethods
    {
        
        public static void IsPrime(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine($"{n} is not a prime number");
                return;
            }

            bool isPrime = true;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{n} is a prime number");
            }
            else
            {
                Console.WriteLine($"{n} is not a prime number");
            }
        }

        public static void Table(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
        }

        public static bool CanVote(int age)
        {
            if (age >= 18) return true;
            return false;
        }

        public static string FindTheBigNumber(int x, int y, int z)
        {
            if (x > y && x > z)
            {
                return $"{x} is the biggest number";
            }
            else if (y > x && y > z)
            {
                return $"{y} is the biggest number";
            }
            else
            {
                return $"{z} is the biggest number";
            }
        }

        public string IsEven(int num)
        {
            if (num % 2 == 0) return $"{num} is even number";
            return $"{num} is odd number";
        }

        public static void IsAlphabet(char c)
        {
            Console.WriteLine("\n" + Char.IsLetter(c));
        }

        public void IsAlphaNumeric(char c)
        {
            Console.WriteLine(Char.IsLetterOrDigit(c) ? $"\n{c} is alphanumeric" : $"\n{c} is not alphanumeric");
        }
    }
}