using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_LAB_5
{
    class OverDraft : Account
    {
        private int limit = 50000;
        public OverDraft()
        {

        }
        public OverDraft(int accountID, string accountName, int balance)
            : base(accountID, accountName, balance)
        {
            base.AccB = balance + limit;
        }
        public void Transfer(int amount, Account acc)
        {
            if ((base.AccB) >= amount)
                base.Transfer(amount, acc);
            else
                Console.WriteLine("Your Balance is not Sufficient ");
        } 
    }
}
