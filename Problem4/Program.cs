using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int LargestPalindrome = 0;
            for (int x = 100; x <= 999; x++)
            {
                for (int y = 100; y <= 999; y++)
                {
                    int z = x * y;
                    if (IsPalindrome(z))
                    {
                        if (z > LargestPalindrome) LargestPalindrome = z;
                        Console.WriteLine($"x: {x} times y: {y}");
                    }
                }

                double a = (double) x / 999 * 100.0;
                Console.WriteLine($"Progress: {a}");
            }
            Console.WriteLine(LargestPalindrome);
            Console.ReadLine();
        }

        public static bool IsPalindrome(int n)
        {
            string x = RemoveMiddleCharacterIfOdd(n);

            int OtherEndIndex = x.Length - 1;
            for (int i = 0; i < x.Length/2; i++, OtherEndIndex--)
            {
                if (x[i] != x[OtherEndIndex]) return false;
            }
            return true;
        }

        public static string RemoveMiddleCharacterIfOdd(int n)
        {
            string x = n.ToString();
            if (x.Length % 2 == 0) return x;
            else x=x.Remove(x.Length / 2, 1);
            return x;

        }
    }
}
