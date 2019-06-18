using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SAL
{
    class Teacher
    {
        private string name;
        public string Name { get => name; set => name = value; }

        public Teacher()
        {

        }

        public Teacher(string name)
        {
            this.Name = name;
        }
    }
}
