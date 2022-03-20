using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PotionsPotionsPotions
{
    class Utility
    {
        public static string ShowAllItemsInList(List<Item> items)
        {
            string output = "";

            foreach (Item i in items)
            {
                output += $"{i.Name} ({i.Quantity}) ({i.Price}) {Environment.NewLine}";
            }


            return output;
        }
       
    }
}
