using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionsPotionsPotions
{
    class DisplayContent
    {
        public static void PrintToOutput(string output)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).Output.Text = output;
        }

        public static void PrintToVendor(string output)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).VendorInventoryList.Text = output;
        }

        public static void PrintToPlayer(string output)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).PlayerInventoryList.Text = output;
        }

        public string ConvertLowerCase(string message) => message.ToLower();

        
    }
}
