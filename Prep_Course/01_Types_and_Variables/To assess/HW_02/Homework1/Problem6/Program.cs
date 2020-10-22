using System;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program that will sum 5 numbers provided by you: \n"); 

            Console.WriteLine("Please input your first number:");  
            string a = Console.ReadLine();
            int firstNumber = int.Parse(a);
            Console.WriteLine("Please input your second number:");
            string b = Console.ReadLine();
            int secondNumber = int.Parse(b);
            Console.WriteLine("Please input your third number:");
            string c = Console.ReadLine();
            int thirdNumber = int.Parse(c);
            Console.WriteLine("Please input your fourth number:");
            string d = Console.ReadLine();
            int fourthNumber = int.Parse(d);
            Console.WriteLine("Please input your fifth number:");
            string e = Console.ReadLine();
            int fifthNumber = int.Parse(e);


            int sum = firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber; 

            Console.WriteLine("\nThank you! The sum of your numbers is: " + sum);
        }
    }
}
