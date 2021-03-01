using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Student
    {

        private string name;

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        private Department dept;
        public Department Dept
        {
            set { this.dept = value; }
            get { return this.dept; }
        }
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public Student(string name, string id, float cgpa)
        {

            this.id = id;
            this.name = name;
            this.cgpa = cgpa;
        }
        public void ShowInfo()
        {
            
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("CGPA : " + cgpa);
        }
        public void ShowDeptInfo()
        {
            ShowInfo();
            Dept.ShowInfo();
        }
    }
}
