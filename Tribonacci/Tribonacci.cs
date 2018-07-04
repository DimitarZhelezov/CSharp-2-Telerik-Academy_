using System;
using System.Collections.Generic;

namespace Tribonacci
{
    class Tribonacci
    {
        static void Main()
        {
            int firstTribNumb = int.Parse(Console.ReadLine());
            int secondTribNumb = int.Parse(Console.ReadLine());
            int thirdTribNumb = int.Parse(Console.ReadLine());
            int theSearchOne = int.Parse(Console.ReadLine());

            List<decimal> tribNumbs = new List<decimal>();
            tribNumbs.Add(firstTribNumb);
            tribNumbs.Add(secondTribNumb);
            tribNumbs.Add(thirdTribNumb);
            int count = 0;
            
            while (tribNumbs.Count < theSearchOne)
            {
                decimal sum = 0;
                sum = tribNumbs[count] + tribNumbs[count + 1] + tribNumbs[count + 2];
                tribNumbs.Add(sum);
                count++;
                
            }
            Console.WriteLine(tribNumbs[tribNumbs.Count - 1]);

            
        }
    }
}
