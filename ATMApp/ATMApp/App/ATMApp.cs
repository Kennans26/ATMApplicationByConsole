using ATMApp.Domain.Entities;
using ATMApp.Domain.Interfaces;
using ATMApp.UI;
using System;

namespace ATMApp.App
{
    internal class ATMApp : IUserLogin
    {
        private List<UserAccount> userAccountList;
        private UserAccount selectedAccount;

        public void CheckUserCardNumberAndPassword()
        {
            bool isCorrectLogin = false;

            UserAccount tempUserAccount = new UserAccount();

            tempUserAccount.CardNumber = Validator.Convert<long>("your card number");
            tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card PIN:"));

            Console.WriteLine("\nChecking card number and PIN...");
            int timer = 10;
            for (int i = 0; i < timer; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }

            Console.Clear();
        }

        public void InitializedData()
        {
            userAccountList = new List<UserAccount>
            {
                new UserAccount
                {
                    Id = 1,
                    FullName = "FullName1",
                    AccountNumber = 001,
                    CardNumber = 123456,
                    CardPin = 123123,
                    AccountBalance = 50000.00m,
                    IsLocked = false
                },
                new UserAccount
                {
                    Id = 2,
                    FullName = "FullName2",
                    AccountNumber = 002,
                    CardNumber = 654321,
                    CardPin = 321321,
                    AccountBalance = 4000.00m,
                    IsLocked = false
                },
                new UserAccount
                {
                    Id = 3,
                    FullName = "FullName3",
                    AccountNumber = 003,
                    CardNumber = 135790,
                    CardPin = 024680,
                    AccountBalance = 2000.00m,
                    IsLocked = true
                }
            };
        }
    }
}
