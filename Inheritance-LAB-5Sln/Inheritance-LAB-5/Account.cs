using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_LAB_5
{
    class Account

    {
        private string AccountName;

        public string accName
        {
            get { return AccountName; }
            set { AccountName = value; }
        }
        

        private int accountID;

        public int accId
        {
            get { return accountID; }
            set { accountID = value; }
        }
         private int Balance;

        public int AccB
        {
            get { return Balance; }
            set { Balance = value; }
        }

        public Account()
        {

        }
        public Account(int accountID, string accountName, int balance)
        {
            this.accountID = accountID;
            this.AccountName = accountName;
            this.Balance = balance;
        }
        public void Transfer(int amount, Account acc)
        {
            if (Balance > amount)
            {
                Balance = Balance - amount;
                acc.Balance = acc.Balance + amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }

        }
        public void ShowInfo()
        {

            Console.WriteLine("Account Number : " + accountID);
            Console.WriteLine("Account Name : " + AccountName);
            Console.WriteLine("Balance : " + Balance);
        }
    }
}
