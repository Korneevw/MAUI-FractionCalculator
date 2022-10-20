using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_FractionCalculator
{
    public static class FractionSimplifier
    {
        public static Fraction Simplify(Fraction fraction)
        {
            int gcd = GreatestCommonDivider(fraction.Numerator, fraction.Denominator);
            int simplifiedNumerator = fraction.Numerator / gcd;
            int simplifiedDenominator = fraction.Denominator / gcd;
            return new Fraction(simplifiedNumerator, simplifiedDenominator);
        }
        public static int GreatestCommonDivider(int a, int b)
        {
            int n = a % b;

            if (n == 0)
            {
                return b;
            }
            else
            {
                return GreatestCommonDivider(b, n);
            }
        }
    }
}
