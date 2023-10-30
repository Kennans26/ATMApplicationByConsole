using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            //clears the console screen
            Console.Clear();
            //sets the title of the console window
            Console.Title = "My ATM App";
            //sets the text color or foreground color to white
            Console.ForegroundColor = ConsoleColor.White;

            //set the welcome message
            Console.WriteLine("\n\n-------------------Welcome to My ATM App-------------------\n\n");
            //prompt the user to insert card
            Console.WriteLine("Please insert your ATM card: ");
            Console.WriteLine("Note: Actual ATM machine will accept and validate a physical ATM card," +
                " read the card number and validate it.");

            Console.WriteLine("\n\nPress Enter to continue...\n");
            Console.ReadLine();
        }
    }
}
