using System;

namespace Methods_class_activity
{
    class Program
    {
        static void Main(string[] args)
        {
            // initial input
            string command = InputCommand();

            //table creation
            string[,] userTable = UserTableCreation(4, 2);

            // command processing
            ProcessCommandCycle(userTable, command);

        }

        /*********************************************************************************/
        // method for processing command cycle - with end condition
        static void ProcessCommandCycle(string[,] userTable, string endCommand = "end")
        {
            string command = endCommand;
            
            while (command != "end")
            {
                // process command
                var (success, message) = ProcessCommand(command, userTable);

                // logging on console
                LogMessage(message, success ? ConsoleColor.DarkGreen : ConsoleColor.Red);

                // reed new input
                command = InputCommand();
            }
        }

        /*********************************************************************************/
        // processing the input command - register or delete
        static (bool success, string message) ProcessCommand(string command, string[,] userTable)
        {
            string[] commandArgs = command.Split(" ");

            // check for validation
            var (success, message, username, password) = ValidationOfParameters(commandArgs);

            if (!success)
            {
                return (success, message);
            }

            // switch case for the 2 different actions
            return commandArgs[0] switch
            {
                "register" => Register(username, password, userTable),
                "delete" => Delete(username, password, userTable),

                //default
                _ => (false, "Invalid command")
            };
        }

        /*********************************************************************************/
        // method for making a registeration in the table
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
                return (false, $"The system supports a maximum number of {MaxUsers(userTable)} users.");
            }

            // save user
            userTable[freeSlotIndex, 0] = username;
            userTable[freeSlotIndex, 1] = password;

            return (true, "Registered user.");
        }

        /*********************************************************************************/
        // method for deleting a registry from the table
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

        /*********************************************************************************/
        // validation checks
        static (bool success, string message, string username, string password) ValidationOfParameters(string[] commandArgs)
        {
            string username = "";
            string password = "";

            // checks for correct command formats
            if (commandArgs.Length < 3)
            {
                return (false, "Too few parameters.", username, password);
            }

            // check for username
            username = commandArgs[1];

            if (username.Length < 3)
            {
                return (false, "Username must be at least 3 characters long.", username, password);
            }

            // check for password
            password = commandArgs[2];

            if (password.Length < 3)
            {
                return (false, "Password must be at least 3 characters long.", username, password);
            }

            return (true, "validation ok", username, password);
        }

        /*********************************************************************************/
        // method for finding the index in the user table
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
        // method for input on the console
        static string InputCommand()
        {
            Console.ResetColor();
            string input = Console.ReadLine();
            return input;
        }

        /*********************************************************************************/
        // method for creating user table with predefined dims
        static string[,] UserTableCreation(int x, int y)
        {
            string[,] userTable = new string[x, y];
            return userTable;
        }

        /*********************************************************************************/
        // method for user table dimentions check
        static int MaxUsers(string[,] userTable)
        {
            int x = userTable.GetLength(0);
            return x;   
        }

        /*********************************************************************************/
        // method for logging results on the console
        static void LogMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
        }




        

        



    }
}
