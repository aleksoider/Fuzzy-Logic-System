using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy
{
    class Literal
    {
        private string vn;
        private string ltn;
        private bool neg;
        private double v;
        public string VarName
        {
            get
            {
                return vn;
            }
            set
            {
               vn = value;
            }
        }
        public string LTName
        {
            get
            {
                return ltn;
            }

            set
            {
                ltn = value;
            }
        }
        public bool Negative
        {
            get
            {
                return neg;
            }
            set
            {
                neg = value;
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
        public void Calc(){
         //   this.v = Fuzzy.FIS//Inputs(Me.VarName).LTerms(Me.LTName).Value;
            if (this.neg)
                this.v = 1 - this.v;
        }
    }
}
