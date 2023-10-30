using ATMApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.App
{
    internal class Entry
    {
        private static void Main(string[] args)
        {
            AppScreen.Welcome();

            ATMApp atmApp = new ATMApp();
            atmApp.CheckUserCardNumberAndPassword();

            //for exit My ATM App
            Utility.PressEnterToContinue();
        }
    }
}
