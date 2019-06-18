using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SAL
{
    class Program
    {
        static void Main(string[] args)
        {
            UProgram uProgram = new UProgram("Information Technology");

            Student student1 = new Student("John Doe");
            Student student2 = new Student("Jane Doe");
            Student student3 = new Student();
            student3.Name = "Jack Black";

            Course myCourse = new Course("Programming with C#");
            myCourse.Students = new Student[3];
            myCourse.Students[0] = student1;
            myCourse.Students[1] = student2;
            myCourse.Students[2] = student3;

            Teacher myTeacher = new Teacher("Aristotle");
            myCourse.Teachers = new Teacher[1];
            myCourse.Teachers[0] = myTeacher;

            Degree myDegree = new Degree("Batchelors");
            myDegree.Course = myCourse;

            uProgram.Degree = myDegree;

            Console.WriteLine($"The {uProgram.ProgramName} program contains the {uProgram.Degree.DegreeName}");
            Console.WriteLine($"The name of the course in the {uProgram.Degree.DegreeName} degree is {uProgram.Degree.Course.CourseName}");
            Console.WriteLine($"The {uProgram.Degree.Course.CourseName} course has {Student.StudentCount()} students enrolled.");




        }
    }
}
