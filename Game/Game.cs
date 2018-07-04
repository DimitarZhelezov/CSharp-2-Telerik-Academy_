using System;
using System.Collections.Generic;

namespace Game
{
    class Game
    {
        static void Main()
        {
            var n = Console.ReadLine();

            List<int> list = new List<int>();

            //list.Add(n / 100);
            //list.Add((n / 10) % 10);
            //list.Add(n % 10);


            for (int i = 0; i < 3; i++)
            {
                list.Add(n[i] - 48);
            }

            //Console.WriteLine(string.Join(" ", list));

            //if (list[2] == 1)
            //{
            //    result = 3;
            //}
            //else if (list[1] == 1)
            //{
            //    result = list[2] + 2;
            //}
            //else if (list[0] == 1)
            //{
            //    result = list[1] * list[2] + 1;
            //}
            //else
            //{
            //    result = list[0] * list[1] * list[2];
            //}
            //Console.WriteLine(result);
            int result1 = list[0] * list[1] * list[2];
            int result2 = list[0] + list[1] * list[2];
            int result3 = list[0] * list[1] + list[2];
            int result4 = list[0] + list[1] + list[2];

            List<int> bestResult = new List<int>();

            bestResult.Add(result1);
            bestResult.Add(result2);
            bestResult.Add(result3);
            bestResult.Add(result4);
            bestResult.Sort();

            Console.WriteLine(bestResult[3]);


        }
    }
}
