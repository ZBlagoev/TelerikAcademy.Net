using System;

namespace Processes
{
    public class Class1
    {
        /*********************************************************************************/
        // logging on console - message + color
        static void LogColorMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /*********************************************************************************/
        // processing command - register or delete
        static (bool success, string message) ProcessCommand(string command, string[,] userTable)
        {
            string[] commandArgs = command.Split();

            // checks for correct command formats
            if (commandArgs.Length < 3)
            {
                return (false, "Too few parameters.");
            }

            string username = commandArgs[1];

            if (username.Length < 3)
            {
                return (false, "Username must be at least 3 characters long.");
            }

            string password = commandArgs[2];

            if (password.Length < 3)
            {
                return (false, "Password must be at least 3 characters long.");
            }

            // switch case for the 2 different actions
            /*
            return commandArgs[0] switch
            {
                "register" => Register(username, password, userTable),
                "delete" => Delete(username, password, userTable),

                //default
                _ => (false, "Invalid command")
            };
            */
            //the above code is the nww C#8 way to write the switch-case 

            switch (commandArgs[0])
            {
                case "register":
                    {
                        Register(username, password, userTable);
                        break;
                    }
                case "delete":
                    {
                        Delete(username, password, userTable);
                        break;
                    }
                default:
                    {
                        return (false, "Password must be at least 3 characters long.");
                        break;
                    }
                        
            }

        }

        /*********************************************************************************/
        // 
        static int FindIndex(string username, string[,] userTable)
        {
            for (int index = 0; index < userTable.GetLength(0); index++)
            {
                if (userTable[index, 0] == username)
                {
                    return index;
                }
            }

            return -1;
        }


        /*********************************************************************************/
        // registering in the table
        static (bool success, string message) Register(string username, string password, string[,] userTable)
        {
            // check if user is in the table
            if (FindIndex(username, userTable) >= 0)
            {
                return (false, "Username already exists.");
            }

            // find free slot - will return -1 if table is full, else will return the index of first free slot
            int freeSlotIndex = FindIndex(null, userTable);

            // no free slots
            if (freeSlotIndex == -1)
            {
                return (false, "The system supports a maximum number of 4 users.");
            }

            // save user
            userTable[freeSlotIndex, 0] = username;
            userTable[freeSlotIndex, 1] = password;

            return (true, "Registered user.");
        }

        /*********************************************************************************/
        // delete from the table
        static (bool success, string message) Delete(string username, string password, string[,] userTable)
        {
            // check if user is in the table
            if (FindIndex(username, userTable) < 0)
            {
                return (false, "Invalid account/password.");
            }

            // find the slot to be deleted
            int accountIndex = FindIndex(username, userTable);

            for (int i = 0; i < userTable.GetLength(0); i++)
            {
                if (userTable[i, 0] == username &&
                    userTable[i, 1] == password)
                {
                    accountIndex = i;
                }
            }

            userTable[accountIndex, 0] = null;
            userTable[accountIndex, 1] = null;

            return (true, "Deleted account.");
        }

    }
}
