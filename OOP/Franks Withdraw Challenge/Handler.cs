using System;

namespace Franks_Withdraw_Challenge
{
    class Handler
    {
        public int moneyBalance = 20000;
        public void WithdrawMethod(int moneyOnBalance)
        {
            Console.WriteLine("Please input the amount you want to withdraw");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            int newBalance = moneyOnBalance - withdrawAmount;
            if (newBalance < 0)
            {
                Console.WriteLine("Could not withdraw that amount, " +
                    "since your balance would be negative after the transaction.\n" +
                    "Here is your balance: " + moneyOnBalance);
            }
            else
            {
                moneyBalance = newBalance;
                Console.WriteLine("Here is your new balance\n" + newBalance);
            }
        }
    }
}
