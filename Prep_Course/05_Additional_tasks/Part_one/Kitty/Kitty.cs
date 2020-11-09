

using System;
using System.Linq;

namespace Kitty
{
    class Kitty
    {
        static void Main(string[] args)
        {
            // input
                
                // positions array
            //Console.Write("positions: ");
            string input = Console.ReadLine();

            string[] positions = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                positions[i] = input[i].ToString();
            }
                // movement array
            //Console.Write("movement: ");
            int[] movement = Console.ReadLine().Split().Select(int.Parse).ToArray();

                // indexes
            int currentPos = 0;
            int foodCollected = 0;
            int soulsCollected = 0;
            int deadlocks = 0;
            int jumpsMade = 0;

            bool isDead = false;

            // calculation
            for (int i = -1; i < movement.Length; i++)
            {
                    // test for start position
                if (i == -1)
                {
                    if (positions[0] == "x")
                    {
                        isDead = true;
                        break;
                    }
                    else
                    {
                        ++i;
                    }
                }

                    // increment of current position
                if (movement[i] > 0)
                {
                    if ((currentPos + movement[i]) > positions.Length)
                    {
                        currentPos = currentPos + movement[i] - positions.Length;
                    }
                    else
                    {
                        currentPos += movement[i];
                    }
                }
                else if (movement[i] < 0)
                {
                    if ((currentPos + movement[i]) < 0)
                    {
                        currentPos = positions.Length + (currentPos + movement[i]);
                    }
                    else
                    {
                        currentPos += movement[i];
                    }
                }
                
                    // actions on current position
                if (positions[currentPos] == "@")
                {
                    soulsCollected++;
                    positions[currentPos] = "0";
                }
                else if (positions[currentPos] == "*")
                {
                    foodCollected++;
                    positions[currentPos] = "0";
                }
                else if (positions[currentPos] == "x")
                {
                    if ((currentPos % 2 == 0) && (soulsCollected > 0))
                    {
                        soulsCollected--;
                        deadlocks++;
                        positions[currentPos] = "@";
                    }
                    else if ((currentPos % 2 == 0) && (soulsCollected <= 0))
                    {
                        jumpsMade = i + 1;
                        isDead = true;
                        break;
                    }
                    else if ((currentPos % 2 != 0) && (foodCollected > 0))
                    {
                        foodCollected--;
                        deadlocks++;
                        positions[currentPos] = "*";
                    }
                    else if ((currentPos % 2 != 0) && (foodCollected <= 0))
                    {
                        jumpsMade = i + 1;
                        isDead = true;
                        break;
                    }
                }
                else if (positions[currentPos] == "0")
                {
                    continue;
                }
            }

            // output
            if (isDead)
            {
                Console.WriteLine("You are deadlocked, you greedy kitty!");
                Console.WriteLine($"Jumps before deadlock: {jumpsMade}");
            }
            else
            {
                Console.WriteLine($"Coder souls collected: {soulsCollected}");
                Console.WriteLine($"Food collected: {foodCollected}");
                Console.WriteLine($"Deadlocks: {deadlocks}");
            }
                
        }
    }
}
