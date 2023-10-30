using ATMApp.UI;
using System;

namespace ATMApp.App
{
    internal class ATMApp
    {
        private static void Main(string[] args)
        {
            AppScreen.Welcome();
            string? cardNumber = Utility.GetUserInput("your card number");
            Console.WriteLine($"Your card number is: {cardNumber}.");

            Utility.PressEnterToContinue();
        }
    }
}
