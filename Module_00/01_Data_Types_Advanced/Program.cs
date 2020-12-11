using System;
using static _01_Data_Types_Advanced.Enumeration_types;

namespace _01_Data_Types_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            /**********************************************************************/
            // Season enumeration type
            Season a = Season.Autumn;

            Console.WriteLine($"Integral value of {a} is {(int)a}");

            var b = (Season)1;
            Console.WriteLine(b);

            var c = (Season)4;
            Console.WriteLine(c);

            Console.WriteLine();

            /**********************************************************************/
            // Days enumeration type
            Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
            Console.WriteLine(meetingDays);

            Days homeWorking = Days.Thursday | Days.Friday;
            Console.WriteLine($"Join a meeting by phone on {meetingDays & homeWorking}");

            bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
            Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");

            Console.WriteLine();

            /**********************************************************************/
            // Person object
            PersonObject person1 = new PersonObject("Leopold", 6);
            Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);

                // Declare new person, assign person1 to it.
            PersonObject person2 = person1;

                // Change the name of person2, and person1 also changes.
            person2.Name = "Molly";
            person2.Age = 16;

            Console.WriteLine("person2 Name = {0} Age = {1}", person2.Name, person2.Age);
            Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);
            
            Console.WriteLine();

            /**********************************************************************/
            // Person struct
                // Create  struct instance and initialize by using "new".
                // Memory is allocated on thread stack.
            PersonStruct p1 = new PersonStruct("Alex", 9);
            Console.WriteLine("p1 Name = {0} Age = {1}", p1.Name, p1.Age);

                // Create  new struct object. Note that  struct can be initialized
                // without using "new".
            PersonStruct p2 = p1;

                // Assign values to p2 members.
            p2.Name = "Spencer";
            p2.Age = 7;
            Console.WriteLine("p2 Name = {0} Age = {1}", p2.Name, p2.Age);

                // p1 values remain unchanged because p2 is  copy.
            Console.WriteLine("p1 Name = {0} Age = {1}", p1.Name, p1.Age);

            Console.WriteLine();

            /**********************************************************************/
            // Comparison of objects and structs
            if (person2.Equals(person1))
            {
                Console.WriteLine("person2 and person1 have the same values.");
            }
            else
            {
                Console.WriteLine("person2 and person1 have different values.");
            }


            if (p2.Equals(p1))
            {
                Console.WriteLine("p2 and p1 have the same values.");
            }
            else
            {
                Console.WriteLine("p2 and p1 have different values.");
            }

        }
    }
}
