using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class StartTable
    {
        public int I { get; }
        public int J { get; }
        public double[] Function { get; }

        public double[,] Restrictions { get; }

        public StartTable(int i, int j, double[] function, double[,] restrictions)
        {
            this.I = i;
            this.J = j;
            this.Function = function;
            this.Restrictions = restrictions;
        }
    }
}
