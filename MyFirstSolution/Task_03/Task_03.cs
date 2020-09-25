/*
Rectangle Area
Write a program that will read a width and a height from the console and will 
calculate the area of the rectangle and print it on the console.

Hint
You must parse the input to number before making calculations

JavaScript: Number("42");
C#: int.Parse("42");
Java: Integer.parseInt("42");
Input
On the first line you will receive a number. The width of the rectangle.
On the second line you will receive a number. The height of the rectangle.
Output
You should print the area of the rectangle.
Constraints
The numbers will be integers
*/
using System;

namespace Task03
{
    class Task_03
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int area = int.Parse(a) * int.Parse(b);

            Console.WriteLine(area);

        }
    }
}
