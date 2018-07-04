using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranks
{
    class Ranks
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> rankedNumbers = new List<int>();
            int counter = 1;
            
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        counter++;
                    }
                    
                }
                rankedNumbers.Add(counter);
                counter = 1;
            }
            Console.WriteLine(string.Join(" ",rankedNumbers));

        }
    }
}
