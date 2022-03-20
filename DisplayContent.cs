using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionsPotionsPotions
{
    class DisplayContent
    {
        public static void Print(string output)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).Output.Text = output;
        }
        

        public string ConvertLowerCase(string message) => message.ToLower();

        
    }
}
