using RegisterATMUsers.UI;
using RegisterATMUsers.Users;
using System;

namespace RegisterATMUsers
{
    internal class Base
    {
        public const string myDB = @"C:\Users\kenna\source\repos\ATMApplication\Users DB";

        private static void Main(string[] args)
        {
            App app = new App();
            var choice = app.StartingScreen();

            if (choice == "no")
            {
                app.DoNotWantToRegistering();
            }

            else
            {
                do
                {
                    Console.Clear();

                    Console.Write("Enter new user's id: ");
                    int currId = int.Parse(Console.ReadLine());

                    Console.Write("Enter new user's full name: ");
                    string currFullName = Console.ReadLine();

                    Console.Write("Enter new user's account number: ");
                    long currAccNumber = long.Parse(Console.ReadLine());

                    Console.Write("Enter new user's card number: ");
                    long currCardNumber = long.Parse(Console.ReadLine());

                    Console.Write("Enter new user's card pin: ");
                    int currCardPin = int.Parse(Console.ReadLine());

                    Console.Write("Enter new user's account balance: ");
                    decimal currAccBalance = decimal.Parse(Console.ReadLine());

                    Console.Write("Enter new user card's locked status: ");
                    bool currIsLocked = bool.Parse(Console.ReadLine());

                    User currUser = new User()
                    {
                        Id = currId,
                        FullName = currFullName,
                        AccountNumber = currAccNumber,
                        CardNumber = currCardNumber,
                        CardPin = currCardPin,
                        AccountBalance = currAccBalance,
                        IsLocked = currIsLocked
                    };

                    var currFile = Path.Combine(myDB, currUser.Id + ".txt");

                    if (File.Exists(currFile))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\nThis student has already been registered!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else
                    {
                        string userToFile = $"User's id: {currUser.Id}" + Environment.NewLine +
                        $"User's full name: {currUser.FullName}" + Environment.NewLine +
                        $"User's account number: {currUser.AccountNumber}" + Environment.NewLine +
                        $"User's card number: {currUser.CardNumber}" + Environment.NewLine +
                        $"User's card pin: {currUser.CardPin}" + Environment.NewLine +
                        $"User's account balance: {currUser.AccountBalance}" + Environment.NewLine +
                        $"User's user card's locked status: {currUser.IsLocked}";

                        File.WriteAllText(currFile, userToFile);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\nStudent was successfully registered!");
                        Console.ForegroundColor = ConsoleColor.White;

                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                    choice = app.StartingScreen();
                } while (choice == "yes");
            }
        }
    }
}
