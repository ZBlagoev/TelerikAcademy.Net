/*
Hello you
Write a program that will read a name as input from the console and salute the person.

Input
On the single line you will receive a name (ex: John)
Output
You should print a salutation to the person (ex: Hello, John!)
Input
John
Output
Hello, John!
*/

using System;

namespace Task_02
{
    class Task_02
    {
        static void Main(string[] args)

        {

            string firstName = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", firstName);

        }
    }
}