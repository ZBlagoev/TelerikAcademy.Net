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
            string cName = Console.ReadLine();
            string cAddress = Console.ReadLine();
            string pNumber = Console.ReadLine();
            string fNumber = Console.ReadLine();
            string websie = Console.ReadLine();
            string mName1 = Console.ReadLine();
            string mName2 = Console.ReadLine();
            string mAge = Console.ReadLine();
            string mPhone = Console.ReadLine();

            // calculations
                //company name
            if (string.IsNullOrEmpty(cName))
            {
                cName = "(no name)";
            }
                // company address
            if (string.IsNullOrEmpty(cAddress))
            {
                cAddress = "(no address)";
            }
                // phone number
            if (string.IsNullOrEmpty(pNumber))
            {
                pNumber = "(no phone)";
            }
                // fax number
            if (string.IsNullOrEmpty(fNumber))
            {
                fNumber = "(no fax)";
            }
                // website
            if (string.IsNullOrEmpty(websie))
            {
                websie = "(no website)";
            }
                //manager first name
            if (string.IsNullOrEmpty(mName1))
            {
                mName1 = "(no first name)";
            }
                // manager last name
            if (string.IsNullOrEmpty(mName2))
            {
                mName2 = "(no last name)";
            }
                // manager age
            if (string.IsNullOrEmpty(mAge))
            {
                mAge = "(no age)";
            }
                // manager phone
            if (string.IsNullOrEmpty(mPhone))
            {
                mPhone = "(no phone)";
            }

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
