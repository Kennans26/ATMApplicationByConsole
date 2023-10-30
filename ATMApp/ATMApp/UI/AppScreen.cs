using ATMApp.Domain.Entities;
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
            Console.WriteLine("\n-------------------Welcome to My ATM App-------------------\n\n");
            //prompt the user to insert card
            Console.WriteLine("Please insert your ATM card: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Note: Actual ATM machine will accept and validate a physical ATM card," +
                " read the card number and validate it.");
            Console.ForegroundColor = ConsoleColor.White;

            Utility.PressEnterToContinue();
        }

        internal static UserAccount UserLoginForm()
        {
            UserAccount tempUserAccount = new UserAccount();

            tempUserAccount.CardNumber = Validator.Convert<long>("your card number");
            tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card PIN:"));
        
            return tempUserAccount;
        }

        internal static void LoginProgress()
        {
            Console.WriteLine("\nChecking card number and PIN...");
            Utility.PrintDotAnimation();
        }
    }
}
