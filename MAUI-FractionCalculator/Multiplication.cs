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
            int aNum = a.Numerator;
            int bNum = b.Numerator;

            if (a.IsNegative == true)
            {
                aNum = -a.Numerator;
            }
            if (b.IsNegative == true)
            {
                bNum = -b.Numerator;
            }

            bool isNegative = (aNum * bNum) < 0;

            return new Fraction(a.Numerator * b.Numerator, b.Denominator * a.Denominator)
                       { IsNegative = isNegative };
        }
    }
}
