using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    public class Employee
    {
        private static int employeeCount = 1;

        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;


        public string Name { get => employeeName; set => employeeName = value; }
        public double BaseSalary { get => employeeBaseSalary; set => employeeBaseSalary = value; }
        public int ID { get => employeeId; set => employeeId = value; }

        public Employee(string name, double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
            ID = employeeCount++;
        }

        public string toString() => ID + " " + this.Name;

        public virtual string employeeStatus() => toString() + " is in the company's system.";
     

}
}
