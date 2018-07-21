using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Difference(100));
            Console.WriteLine("end");
            Console.ReadLine();
        }

        public static int Difference(int n)
        {
            int SumOfSquare = 0;
            int Sum = 0;
            for (int i = 0; i <= n; i++)
            {
                SumOfSquare += (int)Math.Pow(i, 2);
                Sum += i;
            }
            Console.WriteLine($"{SumOfSquare},{Sum}");

            int difference = (int)Math.Pow(Sum, 2) - SumOfSquare;
            return difference;
        }

    }
}
