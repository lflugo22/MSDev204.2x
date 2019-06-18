using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SAL
{
    class Degree
    {
        private string degreeName;
        private Course course;

        public string DegreeName { get => degreeName; set => degreeName = value; }
        public Course Course { get => course; set => course = value; }

        public Degree(string degreeName)
        {
            this.DegreeName = degreeName;
        }

    }
}
