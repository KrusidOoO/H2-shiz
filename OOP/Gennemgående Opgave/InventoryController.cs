namespace Gennemgående_Opgave
{
    class InventoryController
    {
        //Knows something and can do something (knows if there is enough of the specific ware and can execute "transaction")
        Inventory inventory = new Inventory();

        public void addToInventory(Item item)
        {
            inventory.AddItem(item);
        }

        public Inventory getInventory()
        {
            return inventory;
        }

        public void removeFromInventory(int ID)
        {
            foreach (Item item in inventory.getAllItems())
            {
                if (item.ID == ID)
                {
                    inventory.RemoveItem(item);
                    break;
                }
            }
        }

        public void updateInvetory(int ID, int newAmount)
        {
            int count = 0, index = -1;

            foreach (Item item in inventory.getAllItems())
            {
                if (item.ID == ID)
                {
                    index = count;
                    inventory.items[index].amount = newAmount;
                }
                count++;
            }
        }
    }
}
