/*
Problem 9. Play with Int, Double and String
Write a program that, depending on the user’s choice, inputs an int, double or string variable.
* If the variable is int or double, the program increases it by one. 
* * If the variable is a string, the program appends * at the end. 
* * Print the result at the console. Use switch statement.
*/

using System;

namespace Problem_9._Play_with_Int__Double_and_String
{
    class Problem_09
    {
        static void Main(string[] args)
        {
            // input **********************************************
            Console.WriteLine("Problem 9. Play with Int, Double and String");

            Console.WriteLine("Available types: ");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            Console.Write("Please choose a type: ");
            string choiceOne = Console.ReadLine();

            // output **********************************************
            switch (choiceOne)
            {
                case "1":
                    Console.Write("Please choose an int: ");
                    int choiceI = int.Parse(Console.ReadLine());
                    Console.WriteLine($"result: {choiceI + 1}");
                    break;
                case "2":
                    Console.Write("Please choose a double: ");
                    double choiceD = double.Parse(Console.ReadLine());
                    Console.WriteLine($"result: {choiceD + 1.0}");
                    break;
                case "3":
                    Console.Write("Please choose a string: ");
                    string choiceS = Console.ReadLine();
                    Console.WriteLine($"result: {choiceS}*");
                    break;
            }

        }
    }
}
