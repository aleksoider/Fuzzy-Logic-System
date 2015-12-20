using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy
{
    class LTerm
    {
        private string n;
        private double v;
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
        MFunction MF;
        public MFunction MFunction
        {
            get
            {
                return MF;
            }
            set
            {
                MF = value;
            }
        }
    }
}
