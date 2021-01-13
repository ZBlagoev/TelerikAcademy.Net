using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BoardR
{
    class BoardItem
    {
        /*fields**************************************************************/
        private static int nextID = 1;

        private int id;
        private string title;
        private DateTime dueDate;
        private CurrentStatus status;
       

        /*enums***************************************************************/
        private enum CurrentStatus 
        {
            Open, Todo, InProgress, Done, Verified
        }

        /*methods**************************************************************/

        /// <summary>
        /// Prints the ID of the board item
        /// </summary>
        /// <returns>`void`</returns>
        /// <author>Zhelyazko Blagoev</author>
        public void PrintID()
        {
            Console.WriteLine($"ID: {this.id.ToString("X3")}");
        }

        /// <summary>
        /// Prints the title of the board item
        /// </summary>
        /// <returns>`void`</returns>
        /// <author>Zhelyazko Blagoev</author>
        public void PrintTitle()
        {
            Console.WriteLine($"title: {this.title}");
        }

        /// <summary>
        /// Prints the due date of the board item
        /// </summary>
        /// <returns>`void`</returns>
        /// <author>Zhelyazko Blagoev</author>
        public void PrintDueDate()
        {
            Console.WriteLine($"due date: {this.dueDate.ToString("dd-MM-yyyy", CultureInfo.CurrentCulture)}");
        }

        /// <summary>
        /// Prints the status of the board item
        /// </summary>
        /// <returns>`void`</returns>
        /// <author>Zhelyazko Blagoev</author>
        public void PrintStatus()
        {
            Console.WriteLine($"status: {this.status}");
        }

        /// <summary>
        /// Reverses the status of the board item backwards by 1, according to
        /// the scheme Open <- Todo <- InProgress <- Done <- Verified
        /// </summary>
        /// <returns>`void`</returns>
        /// <author>Zhelyazko Blagoev</author>
        public void RevertStatus()
        {
            if (this.status > CurrentStatus.Open && this.status <= CurrentStatus.Verified)
            {
                this.status--;
            }
            else
            {
                Console.WriteLine("Cannot revert status further");
            }
        }

        /// <summary>
        /// Advances the status of the board item forward by 1, according to
        /// the scheme Open -> Todo -> InProgress -> Done -> Verified
        /// </summary>
        /// <returns>`void`</returns>
        /// <author>Zhelyazko Blagoev</author>
        public void AdvanceStatus()
        {
            if (this.status >= CurrentStatus.Open && this.status < CurrentStatus.Verified)
            {
                this.status++;
            }
            else
            {
                Console.WriteLine("Cannot advance status further");
            }
        }

        /// <summary>
        /// Returns information about the board item: title, status and due date in format dd-MM-yyyy
        /// </summary>
        /// <returns>'string' - title, status and due date *</returns>
        /// <author>Zhelyazko Blagoev</author>
        public string ViewInfo()
        {
            string viewInfo = $"'{this.title}' [{this.status}|{this.dueDate.ToString("dd-MM-yyyy", CultureInfo.CurrentCulture)}]";

            return viewInfo;
        }

        /*constructor**********************************************************/
         // later needs to be transferred in Main so that the 
         // try-catch will be
         // in the console so that we can prompt the user to 
         // put new values to the wanted fileds
        public BoardItem(string title, DateTime dueDate)
        {
            // declaring title of BoardItem
            if (string.IsNullOrEmpty(title) || title.Length < 4)
            {
                throw new ArgumentException("Please provide a valid title");
            }
            else
            {
                this.title = title;
            }

            // declaring due date of BoardItem
            if (dueDate < DateTime.Now.AddHours(1)) 
            {
                throw new ArgumentException("Please provide a valid time");
            }
            else
            {
                this.dueDate = dueDate;
            }

            // declaring status - by default 'Open'
            this.status = CurrentStatus.Open;

            // id 
            this.id = nextID++;
        }

    }
}
