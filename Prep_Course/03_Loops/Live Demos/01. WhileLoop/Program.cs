using System;

namespace LoopsLiveDemo09
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            while (counter <= 10)
            {
                Console.WriteLine($"While loop step number {counter}");
                counter++;
            }
        }
    }
}
