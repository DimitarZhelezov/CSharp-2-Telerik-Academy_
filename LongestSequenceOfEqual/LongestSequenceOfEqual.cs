using System;
using System.Collections.Generic;

namespace LongestSequenceOfEqual
{
    class LongestSequenceOfEqual
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            int counter = 1;
            int maxCounter = new int();
            for (int i = 0; i < number; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    counter++;
                }
                else
                {
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }
                    counter = 1;
                }
            }
            if (list.Count == 1)
                maxCounter = 1;
            if (list.Count > 0)
                Console.WriteLine(maxCounter);

        }
    }
}
