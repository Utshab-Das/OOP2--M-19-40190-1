using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_TASK
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("Amrito", "2395333", 31900);
            acc1.ShowDetails();
            acc1.Deposit(15000);
            acc1.Withdraw(12150);
            acc1.ShowDetails();

            Console.WriteLine();
            Course cse1 = new Course("Object Oriented Programming 2", " CSE3103 ", 3);
            cse1.ShowCourseInfo();
        }
    }
}
