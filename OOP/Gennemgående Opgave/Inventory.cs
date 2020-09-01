using System;
using System.Collections.Generic;
using System.Text;

namespace Gennemgående_Opgave
{
    class Inventory
    {
        //A place to store the wares

        public List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }
        
        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }
        
        public List<Item> getAllItems()
        {
            return items;
        }
    }
}
