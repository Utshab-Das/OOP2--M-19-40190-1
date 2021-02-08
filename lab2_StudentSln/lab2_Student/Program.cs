using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            int Physics = 91;
            int Chemistry = 88;
            int Biology = 92;
            int Mathematics = 78;
            int Computer = 76;
            int Grade = (Physics + Chemistry + Biology + Mathematics + Computer) / 5;
            if (Grade >= 90)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (Grade >= 85 && Grade < 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (Grade >= 80 && Grade < 85)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (Grade >= 75 && Grade < 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (Grade >= 50 && Grade < 75)
            {
                Console.WriteLine("Grade: C+");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            Console.WriteLine("");
        }
    }
}
