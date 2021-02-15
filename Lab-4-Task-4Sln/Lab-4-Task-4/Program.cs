using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int x, y, number, count = 0;

            Console.WriteLine("Enter The size of the array: ");
            number = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Enter the number of elements in the array: ");
            for (x = 0; x < number; x++)
            {
                arr[x] = Convert.ToInt32(Console.ReadLine());
            }

             for (x = 0; x < number; x++)
            {
                for (y = x + 1; y < number; y++)
                {
                    
                    if (arr[x] == arr[y])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("\n Total number of duplicate elements found in array:" + count);
            Console.ReadLine();
        }
    }
}
