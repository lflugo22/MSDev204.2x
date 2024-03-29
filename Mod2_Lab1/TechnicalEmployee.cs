﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    public class TechnicalEmployee : Employee
    {
        public int successfulCheckIns = 5;

        public TechnicalEmployee(string name) : base(name, 75000)
        {
        }

        public override string employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIns + " successfull check ins.";
        }

    }
}
