using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Spisende_Filosoffer
{
    class Filosoffer:Gaffel
    {
        static void Main(string[] args)
        {
            Filosoffer filosoffer = new Filosoffer();
            ThreadStart Filosof1 = new ThreadStart(FilosofThread);
            ThreadStart Filosof2 = new ThreadStart(FilosofThread);
            ThreadStart Filosof3 = new ThreadStart(FilosofThread);
            ThreadStart Filosof4 = new ThreadStart(FilosofThread);
            ThreadStart Filosof5 = new ThreadStart(FilosofThread);

            Thread filosof1 = new Thread(Filosof1);
            Thread filosof2 = new Thread(Filosof2);
            Thread filosof3 = new Thread(Filosof3);
            Thread filosof4 = new Thread(Filosof4);
            Thread filosof5 = new Thread(Filosof5);

            filosof1.Name="Filosof 1";
            filosof2.Name = "Filosof 2";
            filosof3.Name = "Filosof 3";
            filosof4.Name = "Filosof 4";
            filosof5.Name = "Filosof 5";

            filosof1.Start();

            Console.WriteLine("\nPress any key to exit program");
            Console.ReadKey();
        }

        public static void FilosofThread()
        {
            Console.WriteLine("Hello");
            Thread.Sleep(2000);
        }
    }
}
