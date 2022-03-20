using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionsPotionsPotions
{
    class Recipe
    {
        //name
        //description
        //ingredients 
        public string Name;
        public string Description;
        public List<Item> Ingredients = new List<Item>();

        //public List<RecipeItem> RecipeItems;

        //public bool CanCraft;

        //public bool CheckForItemsNeeded(Player player)
        //{
        //    foreach (InventorySlot slot in player.PlayerInventory.itemSlots)
        //    {
        //        foreach (RecipeItem item in RecipeItems)
        //        {
        //            if (slot.item == item.Item)
        //                CanCraft = true;
        //        }
        //    }
        //    return false;
        //}
    }
}
