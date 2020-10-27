using System;

namespace _08._Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                if (i == 13)
                {
                    break;
                }
            }
        }
    }
}
