using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[100];
            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the number of elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(" {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.WriteLine(" The values store into the array are : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }

            Console.WriteLine(" The values store into the array in reverse are : ");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.Write("\n\n");
        }
    }
}
