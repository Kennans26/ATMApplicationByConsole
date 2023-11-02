using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterATMUsers.UI
{
    public class App
    {
        public string StartingScreen()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWelcome to the registration department!");

            Console.ForegroundColor = ConsoleColor.Yellow;
            string yesOrNo = "\n\nDo you want to register new users? (yes/no): ";

            Console.Write(yesOrNo);
            Console.ForegroundColor = ConsoleColor.White;

            var userChoice = Console.ReadLine();
            userChoice = userChoice.ToLower();

            return userChoice;
        } 
    }
}
