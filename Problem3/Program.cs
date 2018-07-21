using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 600851475143;
            long prevn = 0;
            while (true)
            {
                prevn = n;
                n = Factorize(n);
                if (prevn == n) break;
                else Console.WriteLine(n);
            }
            Console.ReadLine();
        }

        public static long Factorize(long n)
        {

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return n / i;
            }
            return n;
        }
    }
}
