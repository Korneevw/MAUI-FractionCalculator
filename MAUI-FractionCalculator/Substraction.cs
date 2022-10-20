using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_FractionCalculator
{
    internal class Substraction : FractionOperation
    {
        public Substraction()
        {
            Symbol = "-";
        }
        public override Fraction Operate(Fraction a, Fraction b)
        {
            return a.Denominator == b.Denominator ?
                new Fraction(a.Numerator - b.Numerator, a.Denominator) :
                new Fraction(a.Numerator * b.Denominator - b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        }
    }
}
