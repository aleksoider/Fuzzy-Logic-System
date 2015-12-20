using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy
{
    class Variable
    {
        private string n;
        private double v;
        private int lb;
        private int rb;
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
        public int LeftB
        {
            get
            {
                return lb;
            }

            set
            {
                lb = value;
            }
        }
        public int RightB
        {
            get
            {
                return rb;
            }

            set
            {
                rb = value;
            }
        }
        private List<LTerm> LT;
        private List<MFValue> MFV;
        public List<LTerm> LTerms
        {
            get
            {
                return LT;
            }

            set
            {
                LT = value;
            }
        }
        public List<MFValue> MFValues
        {
            get
            {
                return MFV;
            }

            set
            {
                MFV = value;
            }
        }
    }
}
