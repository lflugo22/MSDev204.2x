using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SAL
{
    class UProgram
    {
        private string programName;
        private Degree degree;

        public string ProgramName { get => programName; set => programName = value; }
        public Degree Degree { get => degree; set => degree = value; }

        public UProgram(string programName)
        {
            this.ProgramName = programName;
        }

        
    }
}
