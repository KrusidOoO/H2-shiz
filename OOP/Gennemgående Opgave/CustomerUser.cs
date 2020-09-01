using System;

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



    class CustomerUser
    {
        //User Interface for shopping wares
        static void Main()
        {
            Console.WriteLine("A customer appears, press 1 to serve him with a list of wares.\n" +
                "Your supplier is about to leave, press 2 to make a request for a new ware to your list.\n" +
                "Your entire stock of one ware have been stolen, press 3 to remove it from your list.\n" +
                "Some of your food in the shop has rotten away, press 4 to update your list.");
            ConsoleKeyInfo keyInfo = Console.ReadKey();





            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("Hello traveler!\nWhat can I interest you with today?");
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Mr. supplier! I need this new thing the next time you come around");
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine("Damn it! it was my best selling ware as well...");
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Console.WriteLine("Well this is unfortunate...");
                    break;

                default:
                    break;
            }
        }

    }
}
