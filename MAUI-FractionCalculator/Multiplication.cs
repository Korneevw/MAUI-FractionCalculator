using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_FractionCalculator
{
    internal class Multiplication : FractionOperation
    {
        public Multiplication()
        {
            Symbol = "*";
        }
        public override Fraction Operate(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }
    }
}
