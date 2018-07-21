using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int SmallestDivisible = 1000;
            while (true)
            {
                if (IsEvenlyDivisble(SmallestDivisible))
                    break;
                SmallestDivisible++;
            }
            Console.WriteLine(SmallestDivisible);
            Console.ReadLine();
        }

        public static bool IsEvenlyDivisble(int n)
        {
            for (int i = 1; i < 21; i++)
            {
                if (n % i != 0) return false;
            }
            return true;
        }
    }
}
