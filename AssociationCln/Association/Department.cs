using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Department
    {
        private string dEPTID;

        public string deptId
        {
            get { return dEPTID; }
            set { dEPTID = value; }
        }

        private string deptName;

        public string dEPTName
        {
            get { return deptName; }
            set { deptName = value; }
        }
        private Student[] unstudents;

        public Department()
        {
            unstudents = new Student[100];
        }
        
        private int CountingStudent;

        public int Countstu
        {
            get { return CountingStudent; }
            set { CountingStudent = value; }
        }

        
        public Department(string deptName, string deptID)
        {
            this.dEPTID = deptID;
            this.deptName = deptName;
            unstudents = new Student[100];
        }
        public void AddStudent(params Student[] stu)
        {
            foreach (Student std in stu)
            {
                unstudents[CountingStudent++] = std;
                std.Dept = this;
            }
        }
        public void Print()
        {
            foreach (Student s in unstudents)
            {
                s.ShowInfo();
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Dept Id : " + dEPTID);
            Console.WriteLine("Dept Name : " + deptName);
            
        }
    }
}
