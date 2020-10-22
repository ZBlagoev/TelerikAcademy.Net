using System;
using System.Threading;

namespace P2_PrintCompanyInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string faxNumber = Console.ReadLine();
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            string managerAge = Console.ReadLine();
            Console.Write("Manager phone: ");
            string managerPhone = Console.ReadLine();

            //checking if company phone, fax, website, manager phone available
            if (String.IsNullOrEmpty(phoneNumber))
            { 
                phoneNumber = "(no phone)";
            }

            if (String.IsNullOrEmpty(faxNumber))
            {
                faxNumber = "(no fax)";
            }

            if(String.IsNullOrEmpty(webSite))
            {
               webSite  = "(no website)";
            }

            if(String.IsNullOrEmpty(managerPhone))
            {
                managerPhone = "(no phone)";
            }

            //print output
            Console.WriteLine($"{companyName}\n" + 
                $"Address: {companyAddress}\n" + 
                $"Tel. {phoneNumber}\n" + 
                $"Fax: {faxNumber}\n" + 
                $"Web site: {webSite}\n" + 
                $"Manager: {managerFirstName} {managerLastName} (age: {managerAge}, tel. {managerPhone})");
        }
    }
}
