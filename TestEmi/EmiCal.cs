using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEmi
{
    internal class EmiCal
    {
        public double emi_calculator(double p, double i, double t, double n)
        {
            i = i / 100;
            double emi = (p * Math.Pow((1 + i / n), (t * n))) / 24;
            return (emi);
        }
    }
}
