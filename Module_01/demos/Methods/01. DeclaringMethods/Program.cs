using System;

namespace DeclaringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // methods are "called" by using the () operator
            // "call" - force the method to execute the code inside its body
            PrintWelcomeMessage();
        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Hello, user!");
            Console.WriteLine("Enjoy using our system");
            Console.WriteLine("If you have any issues, type --help");
            Console.WriteLine($"Have a nice {DateTime.Now.DayOfWeek}!");
        }
    }
}
