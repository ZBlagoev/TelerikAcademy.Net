/*
Diff Checker
Git stopped working because the diffing algorithm is buggy so guess who will have to re-implement it?

To start with something simpler, you will need to compare two arrays, and display 
a + if there's a match between a pair of elements or a - if there is none. 
If there are more numbers in one of the arrays, display a 'x' for the missing number 
in the other array.

Study the examples below to get a clearer understanding.

Input
There are two lines of input, each one containing numbers, separated by a space.
Output
For each pair of elements, print a new line in the format:
+ {firstArrElement} {secondArrElement} - if equal
- {firstArrElement} {secondArrElement} - if different
Replace a missing element with 'x', if necessary.
Sample Tests
Input
1 2 3 4 5 7
1 2 4 4 5 6
Output
+ 1 1
+ 2 2
- 3 4
+ 4 4
+ 5 5
- 7 6
Input
1 2 3 4 5 6
1 2 3 4
Output
+ 1 1
+ 2 2
+ 3 3
+ 4 4
- 5 x
- 6 x
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace _00_02_Exam_Tasks_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            List<string> arrOne = Console.ReadLine().Split(' ').ToList();
            List<string> arrTwo = Console.ReadLine().Split(' ').ToList();

            // calculation
            if (arrOne.Count > arrTwo.Count)
            {
                for (int i = 0; i <= arrOne.Count - arrTwo.Count; i++)
                {
                    arrTwo.Add("x");
                }
            }
            else if (arrOne.Count < arrTwo.Count)
            {
                for (int i = 0; i <= arrTwo.Count - arrOne.Count; i++)
                {
                    arrOne.Add("x");
                }
            }

            // output
            for (int j = 0; j < arrOne.Count; j++)
            {
                if (arrOne[j] == arrTwo[j])
                {
                    Console.WriteLine($"+ {arrOne[j]} {arrTwo[j]}");
                }
                else
                {
                    Console.WriteLine($"- {arrOne[j]} {arrTwo[j]}");
                }
            }



            // test
            //Console.WriteLine(string.Join(",", arrOne));
            //Console.WriteLine(string.Join(",", arrTwo));

        }
    }
}
