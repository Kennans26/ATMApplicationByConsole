using ATMApp.UI;
using System;

namespace ATMApp.App
{
    internal class ATMApp
    {
        private static void Main(string[] args)
        {
            AppScreen.Welcome();
            long cardNumber = Validator.Convert<long>("your card number");
            Console.WriteLine($"Your card number is: {cardNumber}.");

            Utility.PressEnterToContinue();
        }
    }
}
