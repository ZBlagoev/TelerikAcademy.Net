using System;

namespace Problem_2._Print_Company_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company name:");
            string compName = Console.ReadLine();
            Console.WriteLine("Company address:");
            string compAddress = Console.ReadLine();
            Console.WriteLine("Phone number:");
            string compPhoneNum = Console.ReadLine();
            Console.WriteLine("Fax number:");
            string compFaxNum = Console.ReadLine();
            Console.WriteLine("Web site:");
            string compWebSite = Console.ReadLine();
            Console.WriteLine("Manager first name:");
            string mngrFirstName = Console.ReadLine();
            Console.WriteLine("Manager last name:");
            string mngrLastName = Console.ReadLine();
            Console.WriteLine("Manager age:");
            string mngrAge = Console.ReadLine();
            Console.WriteLine("Manager phone:");
            string mngrPhone = Console.ReadLine();


            Console.WriteLine(compName);
            Console.WriteLine($"Address: {compAddress}");
            if (string.IsNullOrEmpty(compPhoneNum))
            {
                Console.WriteLine("Tel.: No tel.");
            }
            else
            {
                Console.WriteLine($"Tel.: {compPhoneNum}");
            }
            if (string.IsNullOrEmpty(compFaxNum))
            {
                Console.WriteLine("Fax: No fax");
            }
            else
            {
                Console.WriteLine($"Fax: {compFaxNum}");
            }
            Console.WriteLine($"Website: {compWebSite}");
            Console.WriteLine($"Manager: {mngrFirstName} {mngrLastName} (age: {mngrAge}, tel. {mngrPhone}))");
        }
    }
}
//A company has name, address, phone number, fax number, web site and manager.The manager has first name, last name, age and a phone number.Write a program that reads the information about a company and its manager and prints it back on the console.
//Example input:
//Program asks:                        	user input
//Company name:	Telerik Academy
//Company address:	31 Al.Malinov, Sofia
//Phone number:	+359 888 55 55 555
//Fax number:	
//Web site:	http://telerikacademy.com/
//Manager first name:	Martin
//Manager last name:	Veshev
//Manager age:	25
//Manager phone:	+359 2 981 981

//Example output:
//Telerik Academy
//Address: 31 Al.Malinov, Sofia
//Tel. +359 888 55 55 555
//Fax: (no fax)
//Web site: http://telerikacademy.com/
//Manager: Martin Veshev (age: 25, tel. +359 2 981 981)