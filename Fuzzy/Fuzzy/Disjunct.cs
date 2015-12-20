using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy
{
    class Disjunct
    {
        FIS f;
        private List<Conjunct> Conjuncts;
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
            this.v=0;
            for(int i=0;i<this.Conjuncts.Count;i++)
            {
                this.Conjuncts[i].Calc();
                this.v=f.FuzzyOr(this.v,this.Conjuncts[i].Value);
            }
        }
    }
}
