using System;
using System.Collections.Generic;
using System.Text;

namespace Gennemgående_Opgave
{
    class Inventory
    {
        //A place to store the wares

        List<Item> items = new List<Item>();

        void AddItem(Item item)
        {
            items.Add(item);
        }
        
        void RemoveItem(Item item)
        {
            items.Remove(item);
        }
        
        List<Item> getAllItems()
        {
            return items;
        }
        

    }
}
