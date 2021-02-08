using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_TASK
{
    class Course
    {
        string courseName;
        string courseCode;
        int courseCredit;
        public string CourseName
        {
            set { CourseName = value; }
            get { return CourseName; }
        }

        public string CourseCode
        {
            set { courseCode = value; }
            get { return courseCode; }
        }

        public int CourseCredit
        {
            set { courseCredit = value; }
            get { return courseCredit; }

        }
        public Course(string courseName, string courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name is: " + courseName);
            Console.WriteLine("Course Code is: " + courseCode);
            Console.WriteLine("Course Cresit is: " + courseCredit);

        }
    }

}

