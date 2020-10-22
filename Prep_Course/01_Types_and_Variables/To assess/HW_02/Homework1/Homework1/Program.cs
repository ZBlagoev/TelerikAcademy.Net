using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your company name?"); 
            string companyName = Console.ReadLine();
            Console.WriteLine("What is your company address?");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("What is the company telephone number?");
            string telephoneNumber = Console.ReadLine();
            Console.WriteLine("What is the company fax number?");
            string faxNumber = Console.ReadLine();
            Console.WriteLine("What is the company website?");
            string companyWebsite = Console.ReadLine();
            Console.WriteLine("What is the first name of the manager?");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("What is the second name of the manager?");
            string managerSecondName = Console.ReadLine();
            Console.WriteLine("Please specify the age of the manager.");
            string managerAge = Console.ReadLine();
            Console.WriteLine("What is the manager's phone number?");
            string managerPhoneNumber = Console.ReadLine();

            Console.WriteLine(); //separator

            Console.WriteLine("Company Name: " + companyName);
            Console.WriteLine("Company Address: " + companyAddress);
            Console.WriteLine("Company Phone: " + telephoneNumber);
            Console.WriteLine("Company Fax: " + faxNumber);
            Console.WriteLine("Company Website: " + companyWebsite);
            Console.WriteLine("Manager First Name: " + managerFirstName);
            Console.WriteLine("Manager Second Name: " + managerSecondName);
            Console.WriteLine("Manager Age: " + managerAge);
            Console.WriteLine("Manager Phone Number: " + managerPhoneNumber);

            
        }
    }
}
