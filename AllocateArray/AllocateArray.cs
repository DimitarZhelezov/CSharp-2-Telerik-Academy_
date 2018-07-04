using System;
namespace AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(count);
                count += 5;
            }

        }
    }
}
