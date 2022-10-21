using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_FractionCalculator
{
    public class Addition : FractionOperation
    {
        public Addition()
        {
            Symbol = "+";
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

            bool isNegative = (aNum * b.Denominator + bNum * a.Denominator) < 0;

            return new Fraction(Math.Abs(a.Numerator * b.Denominator - b.Numerator * a.Denominator), a.Denominator * b.Denominator) 
                       { IsNegative = isNegative };
        }
    }
}
