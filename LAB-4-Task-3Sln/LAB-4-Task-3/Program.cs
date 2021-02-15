using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[100];
            int[] array2 = new int[100];
            int i, n;

            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - : ", i);
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
       
          for (i = 0; i < n; i++)
            {
                array2[i] = array1[i];
            }

            Console.WriteLine("\nThe elements stored in the first array are : ");
            for (i = 0; i < n; i++)
            {
                Console.Write(" {0} ", array1[i]);
            }

            Console.Write("\nThe elements copied into the second array are :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", array2[i]);
            }
            Console.Write("\n\n");
        }
    }
}
