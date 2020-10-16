/*
 * A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. 
 * Write a program that reads the information about a company and its manager and prints it back on the console.
 */

using System;

namespace HW_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string cName = "(no name)";
            string cAddress = "(no address)";
            string pNumber = "(no phone)";
            string fNumber = "(no fax)";
            string websie = "(no website)";
            string mName1 = "(no name)";
            string mName2 = "(no name)";
            string mAge = "(no age)";
            string mPhone = "(no phone)";

            cName = Console.ReadLine();
            cAddress = Console.ReadLine();
            pNumber = Console.ReadLine();
            fNumber = Console.ReadLine();
            websie = Console.ReadLine();
            mName1 = Console.ReadLine();
            mName2 = Console.ReadLine();
            mAge = Console.ReadLine();
            mPhone = Console.ReadLine();

            // output
            Console.WriteLine($"{cName} \n" +
                              $"Address: {cAddress} \n" +
                              $"Tel. {pNumber} \n" +
                              $"Fax: {fNumber} \n" +
                              $"Web site: {websie} \n" +
                              $"Manager: {mName1} {mName2} (age: {mAge}, tel. {mPhone})");
            
            

        }
    }
}





/*
Company name:	Telerik Academy
Company address:	31 Al. Malinov, Sofia
Phone number:	+359 888 55 55 555
Fax number:	
Web site:	http://telerikacademy.com/
Manager first name:	Martin
Manager last name:	Veshev
Manager age:	25
Manager phone:	+359 2 981 981

Telerik Academy
Address: 31 Al. Malinov, Sofia
Tel. +359 888 55 55 555
Fax: (no fax)
Web site: http://telerikacademy.com/
Manager: Martin Veshev (age: 25, tel. +359 2 981 981)
*/