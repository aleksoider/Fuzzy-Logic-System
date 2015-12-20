using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy
{
    class Conjunct
    {
        private FIS f;
        private List<Literal> Literals;
        private double v;
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
        public void Calc()
        {
            this.v = 1;
            for (int i = 0; i < this.Literals.Count; i++)
            {
                Literals[i].Calc();
                this.v = f.FuzzyAnd(this.v, Literals[i].Value);
            }
        }
    }
}
