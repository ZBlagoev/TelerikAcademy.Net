/*
Shelf Mastery
Pesho has many trophies. Each trophy has a rank (integer number). Pesho already has all the
trophies sorted in ascending order.

You need to place them on 4 shelves.

MAX Rank is the rank of the last trophy.
On the top shelf should be all the trophies that have a rank greater than 90% MAX Rank
On the second - those with rank greater than 50% MAX Rank (remember you can't place one 
trophy on 2 shelves)
On the third - those with rank greater than 20% MAX Rank
On the fourth - all that is left

### Example: If MAX Rank is 100:
1st shelf: all trophies with rank > 90
2d shelf: trophies with rank > 50 (and <= 90)
3d shelf: trophies with rank > 20 (and <= 50)
4th shelf: all with rank <=20
Input
Read from the standard input:

On the first line of input is N the number of trophies.
The second line of input contains N amount of integers (ranks of the trophies), 
separated by a space (" "). They are sorted in ascending order.
Output
Print to the standard output:

There should be 4 lines of output, containing the ranks of the trophies for each shelf 
separated by a space (" ") in descending order.
If there are no trophies for a given shelf you should print "empty"
Constraints
N will always be in the range of 1, 1000
Sample Tests
Input
6
1 2 3 3 5 10
Output
10
empty
5 3 3
2 1
Input
6
1 2 4 6 7 10
Output
10
7 6
4
2 1
Input
3
98 99 100
Output
100 99 98
empty
empty
empty
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace _00_03_Exam_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            List<int> trofies = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            trofies.Reverse(); 

            double max = trofies.Max();

            List<string> shelftOne = new List<string>();
            List<string> shelftTwo = new List<string>();
            List<string> shelftThree = new List<string>();
            List<string> shelftFour = new List<string>();

            // calculation
            for (int i = 0; i < trofies.Count; i++)
            {
                if (trofies[i] > max * 0.90)
                {
                    shelftOne.Add(trofies[i].ToString());
                }
                else if ((trofies[i] > max * 0.50) && (trofies[i] <= max * 0.90))
                {
                    shelftTwo.Add(trofies[i].ToString());
                }
                else if ((trofies[i] > max * 0.20) && (trofies[i] <= max * 0.50))
                {
                    shelftThree.Add(trofies[i].ToString());
                }
                else if (trofies[i] <= max * 0.20)
                {
                    shelftFour.Add(trofies[i].ToString());
                }
            }

            // output
            if (shelftOne.Count < 1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", shelftOne));
            }

            if (shelftTwo.Count < 1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", shelftTwo));
            }

            if (shelftThree.Count < 1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", shelftThree));
            }

            if (shelftFour.Count < 1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", shelftFour));
            }

        }
    }
}
