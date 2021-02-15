using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100]; ;
            int x, y, z, size,Uniquenum;

            Console.WriteLine("Enter size of the array: ");
            size = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter elements in the array: ");
            for (x = 0; x < size; x++)
            {
                array[x] = Convert.ToInt32(Console.ReadLine());
            }

            for (x = 0; x < size; x++)
            {
                
                Uniquenum = 1;

                for (y = x + 1; y < size; y++)
                {

                  if (array[x] == array[y])
                    {
                      
                        for (z = y; z < size - 1; z++)
                        {
                            array[z] = array[z + 1];
                        }

                        size--;
                        y--;
                        Uniquenum = 0;
                    }
                }

             
                if (Uniquenum != 1)
                {
                    for (y = x; y < size - 1; y++)
                    {
                        array[y] = array[y + 1];
                    }

                    size--;
                    x--;
                }
            }

           
            Console.WriteLine("All unique elements in the array are: ");
            for (x = 0; x < size; x++)
            {
                Console.WriteLine(array[x] + "\t");
            }
            Console.ReadLine();
        }
    }
}
