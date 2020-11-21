/*
The Kitty is a very dangerous and strange creature. She loves to eat but also loves 
to collect souls. Not ordinary souls but the souls of coders. In order to not collect 
your soul Kitty assigned you a task to find how much food and souls she could collect 
in any iteration. Kitty doesn't know she can be deadlocked and the rest of the coders 
will be saved. There is a catch. Kitty could escape a deadlock if she leaves a soul or 
food in that cell.

Your task is to calculate the food and the souls collected by Kitty or to output that 
she is deadlocked.

On the first line of the input you will receive the positions of the coder souls ("@"),
food ("*") and deadlocks ("x") as string.

On the second line of the input you will receive the path of the Kitty as string with 
integers separated by single space. Positive means, move to the right, negative means, 
move to the left.

The starting position will always be at index 0.

The final result is either the souls, food and deadlocks count or a string informing 
that the Kitty is deadlocked. The format is shown in the zero tests and the example.

@ - symbol for coder soul
* - symbol for food
x - symbol for deadlock

- We start at position 0 and collect a soul @
- We move 1 time to the right and now we are at position 1 and collect a soul @
- We move 1 time to the left and now we are at position 0 and nothing is there because we 
  already collected it, so we continue our path.
- We move 1 time to the left and now we are at position 6 (if you exit the array you should 
  enter from the other side) and we collect food *
- We move 4 times to the right and now we are at position 3 and there is a deadlock.

If the deadlock is on even position the Kitty should leave a soul (@) there in order to escape.
If the deadlock is on odd position the Kitty should leave food (*) there in order to escape.
Position 3 is odd so we leave food (*) to escape the deadlock.
*/

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
            for (int i = 0; i < movement.Length; i++)
            {
                // test for start position
                if (i == 0)
                {
                    if (positions[i] == "x")
                    {
                        isDead = true;
                        break;
                    }
                    else if (positions[i] == "@")
                    {
                        soulsCollected++;
                        positions[currentPos] = "0";
                    }
                    else if (positions[i] == "*")
                    {
                        foodCollected++;
                        positions[currentPos] = "0";
                    }

                }

                //// increment of current position
                currentPos = (currentPos + movement[i]) % positions.Length;
                if (currentPos < 0)
                {
                    currentPos = positions.Length + currentPos;
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
