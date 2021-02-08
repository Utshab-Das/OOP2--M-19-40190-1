using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_TASK
{
    class Account
    {
        string accName;
        string accid;
        int balance;
        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }

        public string Accid
        {
            set { accid = value; }
            get { return accid; }
        }

        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public Account(string accName, string accid, int balance)
        {
            this.accName = accName;
            this.accid = accid;
            this.balance = balance;
        }



        public void Deposit(int amount)
        {
            balance = balance + amount;
            {
                Console.WriteLine(balance + " Money Added in your account & Balance is : ");
            }

        }
        public void Withdraw(int amount)
        {
            balance = balance - amount;
            {
                Console.WriteLine(balance + " Money withdrow from your account ");
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine("Account ID is :" + Accid);
            Console.WriteLine("Account Name is :" + AccName);
            Console.WriteLine("Account's Balance is :" + balance);
        }


    }
}
