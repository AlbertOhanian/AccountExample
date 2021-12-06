using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountWithDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(500);
            account.RegisterHandler(new Account.AccountStateHandler(Show_Message));
            account.Withdraw(300);

            int money=account.CurrentSum;
            Console.WriteLine(money);

            account.Withdraw(250);

            Console.ReadLine();
        }
        private static void Show_Message(String message)
        {
            Console.WriteLine(message);
        }
    }
}
