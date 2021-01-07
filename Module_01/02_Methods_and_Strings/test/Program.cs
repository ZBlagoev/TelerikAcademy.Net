using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string[,] userTable = new string[4, 2];

            while (command != "end")
            {
                string[] commandArgs = command.Split(" ");

                switch (commandArgs[0])
                {
                    case "register":
                        // check login info
                            // if login info successful - continue
                            // else save message and break;
                        // log user
                            // if log successful - continue
                            // else save message and break;
                        // output message
                        break;

                    case "delete":
                        // check login info
                        // delete user
                        // output message
                        break;
                }

                Console.ResetColor();
                // read next command
                command = Console.ReadLine();
            }

            // that is how we output
            string message = ProcessCommand(command).Item1;
        }


        /**********************************************************************/
        static (string, bool) ProcessCommand(string command)
        {
            string[] commandArgs = command.Split(" ");

            // validate arguments
            if (commandArgs.Length < 3)
            {
                return ("Too few parameters.", false);
            }

            string username = commandArgs[1];
            string password = commandArgs[2];

            // validate username
            if (username.Length < 3)
            {
                return("Username must be at least 3 characters long.", false);
            }

            // validate password
            if (password.Length < 3)
            {
                return ("Password must be at least 3 characters long.", false);
            }

            return ("valid command", true);
        }

        /**********************************************************************/
        static (string, bool) LogUser(string[,] userTable, string[] commandArgs)
        {
            string username = commandArgs[1];
            string password = commandArgs[2];

            // check if username exists
            bool usernameExists = false;
            for (int i = 0; i < userTable.GetLength(0); i++)
            {
                if (userTable[i, 0] == username)
                {
                    usernameExists = true;
                }
            }

            if (usernameExists)
            {
                return ("Username already exists.", false);
            }

            // find free slot
            int freeSlotIndex = -1;
            for (int i = 0; i < userTable.GetLength(0); i++)
            {
                if (userTable[i, 0] == null)
                {
                    freeSlotIndex = i;
                }
            }

            // no free slots
            if (freeSlotIndex == -1)
            {
                return ("The system supports a maximum number of 4 users.", false);
            }

            // save user
            userTable[freeSlotIndex, 0] = username;
            userTable[freeSlotIndex, 1] = password;

            return ("Registered user.", true);
        }


        /**********************************************************************/
        static void LogMessage(string input)
        {
            if ((input == "Registered user.") || (input == "Deleted account."))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(input);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(input);
                Console.ResetColor();
            }
        }
    }
}
