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
        public string ConvertLowerCase(string message) => message.ToLower();

        //external data utilities 
        public static string LoadTextFromFile(string path) => File.ReadAllText(path);

        public static List<Item> LoadLinesFromFile(string path)
        {
            //string output = "";
            List<Item> items = new List<Item>();

            foreach (string s in File.ReadAllLines(path))
            {
                items.Add(new Item() { Name = s });
                // Utility.Print(s);
            }
            return items;
        }
    }
}
