using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy
{
    class Parameter
    {
        private double v;
        private string n;

        public string Name
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }
        public double Value
        {
            get
            {
                return v;
            }

            set
            {
                v = value;
            }
        }
        public Parameter(string nn, double vv)
        {
            n = nn;
            v = vv;
        }
    }
}
