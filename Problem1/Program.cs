using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int SumOfMultiples = 0;
            int n = 1000;
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    SumOfMultiples += i;
                    continue; ;
                }

                if (i % 5 == 0)
                {
                    SumOfMultiples += i;
                    continue;
                }
            }
            Console.WriteLine(SumOfMultiples);
            Console.ReadLine();

        }
    }
}
