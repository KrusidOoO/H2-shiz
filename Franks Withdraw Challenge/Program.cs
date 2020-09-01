using System;
using System.Threading;

namespace Franks_Withdraw_Challenge
{
    class Program
    {
        public static void CallToChildThread()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Child thread starts");
        }
        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadKey();
        }
    }
}
