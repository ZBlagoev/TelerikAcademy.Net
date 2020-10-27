using System;

namespace _02._DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 11;

            do
            {
                Console.WriteLine($"Do-while loop step number {counter}");
                counter++;
            }
            while (counter <= 10);
        }
    }
}
