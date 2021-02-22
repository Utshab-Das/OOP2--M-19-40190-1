using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_LAB_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Our Banking System");
            Console.WriteLine("Savings Account ");
            Savings s1 = new Savings(2-11-01, "utshab",33000);
            Savings s2 = new Savings(2-10-2, "abir", 54300);
            s1.Transfer(5000, s2);
            s2.ShowInfo();
            Console.WriteLine("Special Current Account");
            SpecialCurrent sp1 = new SpecialCurrent(221, "Kamal", 256000);
            SpecialCurrent sp2 = new SpecialCurrent(302, "Lotif", 16000);
            sp1.Transfer(1000, sp2);
            sp2.ShowInfo();
            Console.WriteLine("Fixed Account");
            Fixed f1 = new Fixed(33344, "Akash", 290000, 13);
            Fixed f2 = new Fixed(3453, "Sakib", 18700,19);
            f1.Transfer(5000,f2);
            f2.ShowInfo();
            Console.WriteLine(" Over Draft");
            OverDraft od1 = new OverDraft(101, "Reza",20000);
            OverDraft od2= new OverDraft(102, "Joy", 10000);
            od1.Transfer(6000, od2);
            od2.ShowInfo();
            Console.WriteLine("Thank You !");
        }

        }
    }

