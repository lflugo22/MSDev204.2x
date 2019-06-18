using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SAL
{
    class Course
    {
        // Private member variables
        private string courseName;
        private string courseNumber;
        private Student[] students;
        private Teacher[] teachers;

        public string CourseName { get => courseName; set => courseName = value; }
        public string CourseNumber { get => courseNumber; set => courseNumber = value; }
        public Student[] Students { get => students; set => students = value; }
        public Teacher[] Teachers { get => teachers; set => teachers = value; }

        public Course(string courseName)
        {
            this.CourseName = courseName;
        }
    }
}
