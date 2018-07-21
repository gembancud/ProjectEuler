using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int SumOfEvenIntegersInFibonacci = 0;
            int limit = 4000000;
            int prevValue=0;
            int CurrentFibonacciNumber=1;
            while (CurrentFibonacciNumber < limit)
            {
                int temp = CurrentFibonacciNumber;
                CurrentFibonacciNumber = prevValue + CurrentFibonacciNumber;
                prevValue = temp;
                if (CurrentFibonacciNumber % 2 == 0) SumOfEvenIntegersInFibonacci += CurrentFibonacciNumber;
            }
            Console.WriteLine(SumOfEvenIntegersInFibonacci);
            Console.ReadLine();
        }
    }
}
