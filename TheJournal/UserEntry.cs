using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheJournal
{
    class UserEntry
    {
        public static void UserOption()
        {
            string _userInput;
            while (true)
            {
                Console.WriteLine("Welcome to the Journal");
                Console.WriteLine("Please select one of the following choices");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("What would you like to do?");

                _userInput = Console.ReadLine();

                if (_userInput == "1")
                {
                    Utilities.Write();
                }
                else if (_userInput == "2")
                {
                    Utilities.Display();
                }
                else if (_userInput == "3")
                {
                    Utilities.Load();
                }
                else if (_userInput == "4")
                {
                    Utilities.Save();
                }
                else if (_userInput == "5")
                {
                    Utilities.Quit();
                    break; // Exit the while loop
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }

                Console.ReadLine();
            }
        }

    }
}
