using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        string name;
        string id;
        string department;
        float cgpa;
        public Student()
        {
            Console.WriteLine(" That is a Constructor with one parameter ");
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Department
        {
            set { department = value; }
            get { return department; }
        }

        public float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }

         public Student(string name, string id, string department, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("Id is: " + id);
            Console.WriteLine("Deparment is: " + department);
            Console.WriteLine("Cgpa is: " + cgpa);
        }

    }
}
