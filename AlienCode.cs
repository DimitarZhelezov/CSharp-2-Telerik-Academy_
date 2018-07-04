using System;
using System.Collections.Generic;

namespace AlienCode
{
    class AlienCode
    {
        static void Main()
        {
            var input = Console.ReadLine();
            List<char> list = new List<char>();
            List<int> result = new List<int>();


            for (int i = 0; i < input.Length; i++)
            {
                list.Add(input[i]);

            }
            list.ConvertAll(x => (int)x);
            bool isSpace = false;
            int count = list.Count - 1;
            int numberOfLoops = 0;
            int positionOfSpace = 0;
            for (int j = 0; j < list.Count; j++)
            {
                if (list[j] == ' ')
                {
                    isSpace = true;
                    positionOfSpace = j;
                }
            }
            numberOfLoops = list.Count - positionOfSpace;
            if (isSpace == false)
            {
                for (int i = 0; i < list.Count / 2; i++)
                {
                    result.Add(list[i] - list[count]);

                    if (result[i] < 0)
                    {
                        result[i] = result[i] * (-1);
                    }
                    count--;
                }
            }

            else if (isSpace == true)
            {
                list.RemoveAt(positionOfSpace);
                if (list.Count % 2 == 0)
                {
                    for (int i = 0; i < positionOfSpace; i++)
                    {
                        result.Add(list[i] - list[count - 1]);

                        if (result[i] < 0)
                        {
                            result[i] = result[i] * (-1);
                        }
                        count--;
                    }

                }
                else if (list.Count % 2 != 0)
                {

                }


            }


            for (int i = 0; i < result.Count; i++)
            {

                Console.Write((char)(result[i] + 97));

            }
            if (isSpace == true && list.Count % 2 == 0)
                Console.WriteLine(" ");

        }
    }
}
