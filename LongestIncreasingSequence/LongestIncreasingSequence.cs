using System;
namespace LongestIncreasingSequence
{
    class LongestIncreasingSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int lenght = 1;
            int maxLenght = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    lenght++;
                }
                else
                {
                    lenght = 1;
                }
                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                }
            }

            Console.WriteLine(maxLenght);
        }
    }
}
