using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy
{
    class Production
    {
        Disjunct Ant;
        Literal Cons;
        public Disjunct Antecedent
        {
            get
            {
                return Ant;
            }

            set
            {
                Ant = value;
            }
        }
        public Literal Consequent
        {
            get
            {
                return Cons;
            }

            set
            {
                Cons = value;
            }
        }
        public void Calc();
       // BF bf;
    }
}
