using System;

namespace PrimeTriangle
{
    class PrimeTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string row = "";
            for (int i = 1; i <= n; i++)
            {
                int maxDivider =(int)(Math.Sqrt(i));
                Boolean isPrime = true;

                for (int divider = 2; divider <= maxDivider; divider++)
                {
                    if (i % divider == 0)
                    {
                        isPrime = false;
                    }

                }
                if (isPrime)
                {
                    row += "1";
                    Console.WriteLine(row);
                }
                else
                    row += "0";
            }
            
        }
    }
}
