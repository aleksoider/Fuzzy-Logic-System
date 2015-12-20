using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy
{
    class FIS
    {
        private List<Variable> Inputs;
        private List<Variable> Outputs;
        private List<Production> Productions;
        private List<Parameter> Parameters;
        public FIS();
        public void FuzzyAnd(){}//&
        public void FuzzyOr();//V
        public double DefuzzMethod(List<MFValue> x)
        {
            double num, den;
            num = 0;
            den = 0;
            for (int i = 0; i < x.Count; i++)
            {
                num = num + x[i].Value * i;
                den = den + x[i].Value;
            }
            return num / den;
        }
        public void Fuzzyfication()
        {
            for (int i = 0; i < this.Inputs.Count; i++)
            {
                for (int j = 0; j < this.Inputs[i].LTerms.Count; j++)
                {
                    this.Inputs[i].LTerms[j].Value = this.Inputs[i].LTerms[j].MFunction.Calc(this.Inputs[i].Value);
                }
            }
        }
        public void Agregation()
        {
            for (int i = 0; i < this.Productions.Count; i++)
            {
                this.Productions[i].Calc();
            }
        }
        public void Activation()
        {
            for (int i = 0; i < this.Productions.Count; i++)
            {
                this.Productions[i].Consequent.Value=FuzzyAnd(this.Productions[i].Antecedent.Value,this.Productions[i].BF)
            }
        }
        public void Accumulation()
        {
            for (int i = 0; i < this.Outputs.Count; i++)
            {
                for (int j = 0; j < this.Outputs[i].LTerms.Count; j++)
                {
                    this.Outputs[i].LTerms[j].Value = 0;
                    for (int k = 0; k < this.Productions.Count; k++)
                    {
                        if (this.Productions[i].Consequent.VarName == this.Outputs[i].Name &&
                                this.Productions[i].Consequent.LTName == this.Outputs[i].LTerms[j].Name)
                            this.Outputs[i].LTerms[j].Value = FuzzyOr(this.Outputs[i].LTerms[j].Value, this.Productions[i].Consequent.Value);                        
                    }
                }
            }
        }

        public double FuzzyOr(double p, double p_2)
        {
            throw new NotImplementedException();
        }
        public void CutAndUnion()
        {
            for (int i = 0; i < this.Outputs.Count; i++)
            {
                for (int j = 0; j < this.Outputs[i].MFValues.Count; j++)
                {
                    this.Outputs[i].MFValues[j].Value = 0;
                    for (int k = 0; k < this.Outputs[i].LTerms.Count; k++)
                    {
                        this.Outputs[i].LTerms[j].Value =
                                this.Outputs[i].MFValues[j].Value = FuzzyOr(this.Outputs[i].MFValues[j].Value,
                                    this.Outputs[i].LTerms[k].MFunction.Calc(this.Outputs[i].MFValues[j].Arg),
                                    this.Outputs[i].LTerms[k].Value);
                    }
                }
            }
        }
        public void Defuzzification()
        {
            for (int i = 0; i < this.Outputs.Count; i++)
            {
                this.Outputs[i].Value = this.DefuzzMethod(this.Outputs[i].MFValues);       
            }
        }
    }
}
