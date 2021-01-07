using System;
using System.Linq;

namespace Move
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int startPosition = int.Parse(Console.ReadLine());

            int[] path = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            string[] commands = Console.ReadLine().Split();

            int steps;
            string direction;
            int jump;
            int currentPosition;

            int sumForw = 0;
            int sumBack = 0;

            while (int.TryParse(commands[0], out steps))
            {
                direction = commands[1];
                jump = int.Parse(commands[2]);

                // forwards
                if (direction == "forward")
                {
                    currentPosition = startPosition + jump;

                    for (int i = 1; i <= steps; i++)
                    {

                        if (currentPosition > path.Length)
                        {
                            currentPosition = currentPosition % path.Length;
                        }

                        sumForw += path[currentPosition];

                        currentPosition += jump;
                    }
                }
                else
                {
                    currentPosition = Math.Abs(path.Length + startPosition - jump);

                    for (int i = 0; i <= steps; i++)
                    {
                        if (currentPosition < 0)
                        {
                            //currentPosition = currentPosition % path.Length;
                            currentPosition = path.Length + currentPosition;
                        }

                        sumBack += path[currentPosition];

                        currentPosition -= jump;
                    }
                }
                

                commands = Console.ReadLine().Split();
            }



            Console.WriteLine($"Forward: {sumForw}");
            Console.WriteLine($"Backwards: {sumBack}");
        }
    }
}
