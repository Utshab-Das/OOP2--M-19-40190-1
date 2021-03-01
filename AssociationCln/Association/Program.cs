using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stn1 = new Student("Utshab Das", "19-40190-1", 3.6f);
            Student stn2 = new Student("Anik Rahman", "19-40191-1", 3.77f);
            Department de1 = new Department(" Engineering ", "CSE");
            Department de2 = new Department(" Engineering ", "EEE ");
            stn1.Dept = de1;
            stn2.Dept = de2;
            stn1.ShowDeptInfo();
            Console.WriteLine("## DETAILS OF THE STUDENTS ## ");
            de1.AddStudent(stn1);
            de1.AddStudent(stn2);

            de1.Print();
        }
    }
}
