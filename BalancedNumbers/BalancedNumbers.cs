using System;

namespace BalancedNumbers
{
    class BalancedNumbers
    {
        static void Main(string[] args)
        {
            int count = 0;
            var sum = 0;
            while (count < 1000)
            {
                var n = Console.ReadLine();
                int numb1 = n[0] - 48;
                int numb2 = n[1] - 48;
                int numb3 = n[2] - 48;
                if (numb2 == numb3 + numb1)
                {
                    sum += int.Parse(n);
                }
                else
                    break;
            }
            Console.WriteLine(sum);
        }
    }
}
