using System;
using System.Threading;

namespace Franks_Withdraw_Challenge
{
    class Program
    {
        public static Handler handler = new Handler();
        public static void Main(string[] args)
        {
            handler.WithdrawMethod(handler.moneyBalance);
            ThreadStart secondThreadStart = new ThreadStart(SecondThread);
            Thread secondThread = new Thread(secondThreadStart);
            secondThread.Start();
            secondThread.Join();
            Console.WriteLine("\nBoth tasks completed, press any key to continue");
            Console.ReadKey();
        }
        public static void SecondThread()
        {
            Thread.Sleep(1000);
            handler.WithdrawMethod(handler.moneyBalance);
        }
    }
}