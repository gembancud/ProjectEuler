using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10001;
            int currentNumber = 2;
            int LargestPrime = 0;
            while (n != 0) 
            {
                while (!IsPrime(currentNumber))
                {
                    currentNumber++;
                }

                if (IsPrime(currentNumber))
                {
                    LargestPrime = currentNumber;
                    Console.WriteLine(LargestPrime);
                    currentNumber++;
                }

                n--;
            }

            Console.ReadLine();
        }

        public static bool IsPrime(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
