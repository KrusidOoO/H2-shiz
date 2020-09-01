using System;
using System.Threading;

namespace Gennemgående_Opgave
{

    //To do list
    //1. 
    //2.
    //3.
    //4.
    //5.
    //6.
    //7.
    //8.
    //9.
    //10.
    //11.
    //12.



    public class ShopKeeper
    {
        //User Interface for shopping wares
        static void Main()
        {

            InventoryController IC = new InventoryController();

            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine("A customer appears, press 1 to serve him with a list of wares.\n" +
                    "Your supplier is about to leave, press 2 to make a request for a new ware to your list.\n" +
                    "Your entire stock of one ware have been stolen, press 3 to remove it from your list.\n" +
                    "Some of your food in the shop has rotten away, press 4 to update your list.");
                keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("Ho' traveler!\nWhat can I interest you with today?\n");
                        viewList(IC.getInventory());
                        Console.WriteLine("\nhere is a list of items. Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Mr. supplier! I need this new thing the next time you come around\n");
                        Item item = enterRequest();
                        IC.addToInventory(item);
                        Console.WriteLine("\nItem added");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("Damn it! it was my best selling ware as well...");
                        DelItem();
                        Console.Clear();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("Well this is unfortunate...");
                        UpdateItem(IC.getInventory());
                        Console.Clear();
                        break;

                    default:
                        break;
                }
            } while (keyInfo.Key != ConsoleKey.Escape);

            Item enterRequest()
            {
                Console.WriteLine("Enter ID");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Amount");
                int Amount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter description");
                string description = Console.ReadLine();

                Item item = new Item();
                item.ID = ID;
                item.amount = Amount;
                item.name = Name;
                item.description = description;
                return item;
            }

            void viewList(Inventory inventory)
            {
                foreach (Item item in inventory.getAllItems())
                {
                    Console.WriteLine("ID: "+item.ID + " : amount: " + item.amount + " : name: " + item.name + " : desc: " + item.description);

                }
            }

            void DelItem()
            {
                Console.WriteLine("\nEnter the ID of item you want to remove");
                int IDtoBeRemoved = Convert.ToInt32(Console.ReadLine());
                IC.removeFromInventory(IDtoBeRemoved);
                Console.WriteLine("\n Item removed succesfully!");
                Thread.Sleep(1000);
            }

            void UpdateItem(Inventory inventory)
            {
                foreach (Item item in inventory.getAllItems())
                {
                    Console.WriteLine("ID: " + item.ID + " : amount: " + item.amount + " : name: " + item.name + " : desc: " + item.description);

                }

                Console.WriteLine("\nEnter the ID of item you want to update");
                int IDtoBeUpdated = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter the amount you want to update to");
                int newAmount = Convert.ToInt32(Console.ReadLine());

                IC.updateInvetory(IDtoBeUpdated, newAmount);

                Console.WriteLine("\nupdate completed. Press any key to continue.");
                Console.ReadKey();
            }
        }

    }
}
