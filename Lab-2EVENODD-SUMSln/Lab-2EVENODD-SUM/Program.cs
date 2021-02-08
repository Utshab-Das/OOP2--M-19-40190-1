using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2EVENODD_SUM
{
    class Program
    {
            static void Main(string[] args)
        {
            int n = 100;
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i <= 2 * n; i++)
            {
                if ((i & 1) == 0)
                    evenSum += i;
                else
                    oddSum += i;
            }
            Console.WriteLine("Sum of First " + n + "Even numbers = " + evenSum);
            Console.WriteLine("Sum of First " + n + "odd numbers = " + oddSum);
        }
    }
}
