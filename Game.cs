using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static PotionsPotionsPotions.Utility;
using System.IO;
using static PotionsPotionsPotions.LoadData;

namespace PotionsPotionsPotions
{
    class Game
    {
        //instances
        Player player = new Player();
        Vendor vendor = new Vendor()
        {
            Name= "Vendor",

        };

        
        Dictionary<string, string> Recipes = new Dictionary<string, string>();
        Dictionary<string, string> VendorInventory = new Dictionary<string, string>();
        Dictionary<string, string> PlayerInventory = new Dictionary<string, string>();

        public Game()
        {
            LoadData();
        }
        private void LoadData()
        {
            //create starting inventories
            //player.Inventory = LoadLinesFromFile("../../data/defaultPlayerItems.txt");
            //vendor.Inventory = LoadLinesFromFile("../../data/defaultPlayerItems.txt");
            string[] playercontents = GetExternalText("../../data/defaultPlayerItems.txt");

            for (int i = 0; i < playercontents.Length; i++)
            {
                PlayerInventory.Add(playercontents[i], playercontents[i + 1]);
                i++;
            }

            string[] vendorcontents = GetExternalText("../../data/defaultVendorItems.txt");

            for (int i = 0; i < vendorcontents.Length; i++)
            {
                VendorInventory.Add(vendorcontents[i], vendorcontents[i+1]);
                i++;
            }


            string[] contents = GetExternalText("../../data/recipes.txt");
            
            for (int i = 0; i < contents.Length; i++)
            {
                Recipes.Add(contents[i], contents[i + 1]);
                i++;
            }
            //save data read in to the contents string array
            //to the Terms dictionary structure
            //using Key-Value pairs for the
            //terms and definitions
        }

        public string GetAllData()
        {
            string output = "";
            //return all keys and values
            //from the Terms dictionary
            foreach (var item in Recipes)
            {
                output += $"{item.Key}\n{item.Value}\n";
            }
            return output;
        }
        public string GetAllTerms()
        {
            string output = "";
            //add code here 
            //return all keys
            //from the Terms dictionary
            foreach (var item in Recipes)
            {
                output += $"{item.Key}\n";
            }
            return output;
        }

        public string GetAllDefinitions()
        {
            string output = "";
            //add code here 
            //return all values
            //from the Terms dictionary
            foreach (var item in Recipes)
            {
                output += $"{item.Value}\n";
            }
            return output;
        }

        public string GetAllTermsOrderedByLength()
        {
            string output = "";
            //USE LINQ
            //Check the LINQ notes for the OrderBy example:
            //.OrderBy(n => n.Length)
            //return all keys
            //from the Terms dictionary
            //ordered by length
            string[] contents = GetExternalText("../../data/recipes.txt");
            IEnumerable<string> filteredTerms = contents.OrderBy(n => n.Length);
            foreach (string content in filteredTerms)
            {
                output += $"{content}\n";
            }
            return output;
        }

        public string Find(string term)
        {
            //add code here 
            //you can use LINQ or another type of search - your choice
            //if you are using LINQ, check the notes for the Contains example: 
            //where n.Contains ("a")
            //search the Terms dictionary for a key
            //and return the corresponding value
            if (Recipes.ContainsKey(term))
            {
                return Recipes[term];
            }

            return $"Sorry, {term} wasn't found.";
        }

        public string GetVendorData()
        {
            string output = "";
            //return all keys and values
            //from the Terms dictionary
            foreach (var item in VendorInventory)
            {
                output += $"{item.Key}\n{item.Value}\n";
            }
            return output;
        }

        public string GetPlayerData()
        {
            string output = "";
            //return all keys and values
            //from the Terms dictionary
            foreach (var item in PlayerInventory)
            {
                output += $"{item.Key}\n{item.Value}\n";
            }
            return output;
        }

        public bool MakeAPotion()
        {
            if (PlayerInventory.ContainsKey(term))
            {
                //take items out
                //add crafted item
            }
            else
            {
                //tell player they are missing items
            }
        }

    }
}
