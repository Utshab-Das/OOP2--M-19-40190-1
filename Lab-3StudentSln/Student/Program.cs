using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.Name = "Utshab Das";
            st1.Department = "CSE";
            st1.Cgpa = 3.75f;
            st1.ShowInfo();
            
        }
        }
    }

