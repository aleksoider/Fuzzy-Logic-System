using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy
{
    class MFValue
    {
        private double arg;
        private double v;
        public double Arg
        {
            get
            {
                return arg;
            }

            set
            {
                arg = value;
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
    }
}
