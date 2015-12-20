using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fuzzy
{
    class MFunction
    {
        private string mft;
        private List<Parameter> ps;

        public string MFType
        {
            get
            {
                return mft;
            }
            set
            {
                mft = value;
            }
        }

        public List<Parameter> Parameters
        {
            get
            {
                return ps;
            }
            set
            {
                ps = value;
            }
        }

        public MFunction(string m, List<Parameter> p)
        {
            mft = m;
            ps = p;
        }

        public MFunction(string m, params double[] p)
        {
            mft = m;
            for (int i = 0; i < p.Length; i++)
            {
                ps[i].Value = p[i];
                ps[i].Name = "A" + i.ToString();
            }
        }

        private double Trap(double x, double a, double b, double c, double d)
        {
            if(x>=a && x<=b)
                return ((x-a)/(b-a));
            else if(x>=b && x<=c) 
                return 1;
            else if(c<=x && x<=d) 
                return ((d-x)/(d-c));
            else return 0;
        }

        private double Zed(double x, double c, double d)
        {
            if(x<=c)
                return 1;
            else if(x>=c && x<=d)
                return ((d-x)/(c-d));
            else return 0;
        }

        private double Es(double x, double a, double b)
        {
            if (x <= a)
                return 0;
            else if (x >= a && x <= b)
                return ((x - a) / (a - b));
            else return 1;
        }

        public double Calc(double x)
        {
            if(mft == "trap")
                return Trap(x, ps[0].Value, ps[1].Value, ps[2].Value, ps[3].Value);
            else if(mft == "zed")
                return Zed(x,ps[2].Value,ps[3].Value);
            else if (mft == "es")
                return Es(x, ps[0].Value, ps[1].Value);
            else return 0;

        }
    }
}
