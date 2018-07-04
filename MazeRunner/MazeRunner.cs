using System;
using System.Collections.Generic;

namespace MazeRunner
{
    class MazeRunner
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> forDigitNumbs = new List<int>();
            for (int i = 0; i < n; i++)
            {
                forDigitNumbs.Add(int.Parse(Console.ReadLine()));
            }
            List<int> currentNumbs = new List<int>();
            
            for (int i = 0; i < forDigitNumbs.Count; i++)
            {
                int sumOfOdd = 0;
                int sumOfEven = 0;
                currentNumbs.Clear();
                currentNumbs.Add(forDigitNumbs[i] / 1000);
                currentNumbs.Add((forDigitNumbs[i] / 100) % 10);
                currentNumbs.Add((forDigitNumbs[i] / 10) % 10);
                currentNumbs.Add(forDigitNumbs[i] % 10);
                for (int j = 0; j <=3; j++)
                {
                    if (currentNumbs[j] % 2 == 0)
                        sumOfEven += currentNumbs[j];
                    else
                        sumOfOdd += currentNumbs[j];
                }
                if (sumOfEven > sumOfOdd)
                    Console.WriteLine("left");
                if (sumOfOdd > sumOfEven)
                    Console.WriteLine("right");
                else if(sumOfEven == sumOfOdd)
                    Console.WriteLine("straight");

            }
            //Console.WriteLine(string.Join(" ", currentNumbs));
        }
    }
}
