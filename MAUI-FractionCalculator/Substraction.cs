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
            int numerator = a.IsNegative == b.IsNegative ? 
                Math.Abs(a.Numerator * b.Denominator - b.Numerator * a.Denominator) : 
                Math.Abs(a.Numerator * b.Denominator + b.Numerator * a.Denominator);

            int aNum = a.Numerator;
            int bNum = b.Numerator;

            if (a.IsNegative == false)
            {
                aNum = -a.Numerator;
            }
            if (b.IsNegative == false)
            {
                bNum = -b.Numerator;
            }

            bool isNegative = (aNum * b.Denominator - bNum * a.Denominator) < 0;

            return new Fraction(numerator, a.Denominator * b.Denominator)
                       { IsNegative = isNegative };
        }
    }
}
