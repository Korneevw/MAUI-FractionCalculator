using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_FractionCalculator
{
    internal class Division : FractionOperation
    {
        public Division()
        {
            Symbol = "/";
        }
        public override Fraction Operate(Fraction a, Fraction b)
        {
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

            bool isNegative = (aNum * bNum) < 0;

            return new Fraction(a.Numerator * b.Denominator, b.Numerator * a.Denominator)
                       { IsNegative = isNegative };
        }
    }
}
