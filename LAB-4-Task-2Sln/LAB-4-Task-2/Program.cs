using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 8, 9, 2, 4, 1, 6, 5, 3, 3, 3, 12, 18, 11, 10, 33  };
            Console.WriteLine("\n Myarray: [{0}]", string.Join(", ", numbers));
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
