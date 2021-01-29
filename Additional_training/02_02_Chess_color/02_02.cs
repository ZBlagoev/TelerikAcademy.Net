using System;

namespace _02_02_Chess_color
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int label = char.Parse(Console.ReadLine().ToUpper()) - 64;
            int rank = int.Parse(Console.ReadLine());

            if (label % 2 != 0)
            {
                if (rank % 2 != 0)
                {
                    Console.WriteLine("dark");
                }
                else
                {
                    Console.WriteLine("light");
                }
            } 
            else
            {
                if (rank % 2 != 0)
                {
                    Console.WriteLine("light");
                }
                else
                {
                    Console.WriteLine("dark");
                }
            }



        }
    }
}
