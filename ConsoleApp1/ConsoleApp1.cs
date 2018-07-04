using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class ConsoleApp1
    {
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal k = decimal.Parse(Console.ReadLine());
            decimal factorialSum = 1;
            decimal numerator = 1;
            decimal denomerator = 1;
            decimal count = 1;
            for (decimal i = n - k + 1; i <= n; i++)
            {
                numerator = numerator * i;
                denomerator = denomerator * count;
                count++;
                
            }
            factorialSum = numerator / denomerator;
            Console.WriteLine(factorialSum);
           
        }
    }
}
