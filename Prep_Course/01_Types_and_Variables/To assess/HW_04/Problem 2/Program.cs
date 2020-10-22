using System;
using System.Net;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program asks:                         	user input
            // Company name: 	Telerik Academy
            // Company address: 	31 Al.Malinov, Sofia
            // Phone number: +359 888 55 55 555
            // Fax number: 	
            // Web site: 	http://telerikacademy.com/
            // Manager first name: Martin
            // Manager last name: 	Veshev
            // Manager age: 25
            // Manager phone: 	+359 2 981 981

            Console.WriteLine("Company name");
            String companyName = Console.ReadLine();
            Console.WriteLine("Company adress");
            String companyAdress = Console.ReadLine();
            Console.WriteLine("Phone number");
            String phoneNumber = Console.ReadLine();
            Console.WriteLine("Fax number");
            String faxNumber = Console.ReadLine();
            Console.WriteLine("Web site");
            String webSite = Console.ReadLine();
            Console.WriteLine("Manager first name");
            String managerFirstName = Console.ReadLine();
            Console.WriteLine("Manager last name");
            String managerLastName = Console.ReadLine();
            Console.WriteLine("Manager age");
            String managerAge = Console.ReadLine();
            Console.WriteLine("Manager phone");
            String managerPhone = Console.ReadLine();

            if (faxNumber.Length<=0){
                faxNumber = "(no fax)";
            }

            Console.WriteLine("\n" + companyName);
            Console.WriteLine("Adress: " + companyAdress);
            Console.WriteLine("Tel. " + phoneNumber);
            Console.WriteLine("Fax: " + faxNumber);
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + " " + "(Age: " + managerAge + ", tel. " + managerPhone + ")");            


        }   
    }
}
