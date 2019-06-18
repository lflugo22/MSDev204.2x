using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SAL
{
    class Student
    {
        private string name;
        private static int studentCount = 0;

        public string Name { get => name; set => name = value; }

        public Student()
        {
            // Increment student count
            studentCount++;
        }

        public Student(string name)
        {
            this.Name = name;

            // Increment student count
            studentCount++;
        }

        public static int StudentCount()
        {
            return studentCount;
        }


    }
}
