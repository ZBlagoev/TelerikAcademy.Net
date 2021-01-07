using System;
using System.Linq;

namespace Move
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int currentPosition = int.Parse(Console.ReadLine());

            int[] path = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            string[] commands = Console.ReadLine().Split();

            int steps;
            string direction;
            int jump;

            int sumForw = 0;
            int sumBack = 0;

            while (int.TryParse(commands[0], out steps))
            {
                direction = commands[1];
                jump = int.Parse(commands[2]);

                // forwards
                if (direction == "forward")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        currentPosition += jump % path.Length;

                        if (currentPosition > path.Length - 1)
                        {
                            currentPosition -= path.Length;
                        }

                        sumForw += path[currentPosition];
                    }
                }
                else
                {
                    for (int i = 0; i < steps; i++)
                    {
                        currentPosition -= jump % path.Length;
                        
                        if (currentPosition < 0)
                        {
                            //currentPosition = currentPosition % path.Length;
                            currentPosition += path.Length;
                        }

                        sumBack += path[currentPosition];
                    }
                }
                

                commands = Console.ReadLine().Split();
            }



            Console.WriteLine($"Forward: {sumForw}");
            Console.WriteLine($"Backwards: {sumBack}");
        }
    }
}
