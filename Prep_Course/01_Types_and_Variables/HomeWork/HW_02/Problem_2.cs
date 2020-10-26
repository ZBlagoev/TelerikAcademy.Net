/*
 * A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. 
 * Write a program that reads the information about a company and its manager and prints it back on the console.
 */

using System;

namespace HW_02
{
    class Problem_2
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Problem 2: Print Company Information");

            Console.Write("company name: ");
            string cName = Console.ReadLine();
            Console.Write("company address: ");
            string cAddress = Console.ReadLine();
            Console.Write("company number: ");
            string pNumber = Console.ReadLine();
            Console.Write("company fax: ");
            string fNumber = Console.ReadLine();
            Console.Write("company websit: ");
            string websie = Console.ReadLine();
            Console.Write("manager first name: ");
            string mName1 = Console.ReadLine();
            Console.Write("manager second name: ");
            string mName2 = Console.ReadLine();
            Console.Write("manager age: ");
            string mAge = Console.ReadLine();
            Console.Write("manager number: ");
            string mPhone = Console.ReadLine();

            // calculations
                //company name
            if (string.IsNullOrEmpty(cName.Trim()))
            {
                cName = "(no name)";
            }
                // company address
            if (string.IsNullOrEmpty(cAddress.Trim()))
            {
                cAddress = "(no address)";
            }
                // phone number
            if (string.IsNullOrEmpty(pNumber.Trim()))
            {
                pNumber = "(no phone)";
            }
                // fax number
            if (string.IsNullOrEmpty(fNumber.Trim()))
            {
                fNumber = "(no fax)";
            }
                // website
            if (string.IsNullOrEmpty(websie.Trim()))
            {
                websie = "(no website)";
            }
                //manager first name
            if (string.IsNullOrEmpty(mName1.Trim()))
            {
                mName1 = "(no first name)";
            }
                // manager last name
            if (string.IsNullOrEmpty(mName2.Trim()))
            {
                mName2 = "(no last name)";
            }
                // manager age
            if (string.IsNullOrEmpty(mAge.Trim()))
            {
                mAge = "(no age)";
            }
                // manager phone
            if (string.IsNullOrEmpty(mPhone.Trim()))
            {
                mPhone = "(no phone)";
            }

            // output
            Console.WriteLine();
            Console.WriteLine($"{cName} \n" +
                              $"Address: {cAddress} \n" +
                              $"Tel. {pNumber} \n" +
                              $"Fax: {fNumber} \n" +
                              $"Web site: {websie} \n" +
                              $"Manager: {mName1} {mName2} (age: {mAge}, tel. {mPhone})");
        }
    }
}
