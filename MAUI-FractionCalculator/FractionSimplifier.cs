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
            return new Fraction(simplifiedNumerator, simplifiedDenominator) { IsNegative = fraction.IsNegative };
        }
        public static MixedFraction SimplifyMixed(MixedFraction mixedFraction)
        {
            int gcd = GreatestCommonDivider(mixedFraction.NumeratorRemainder, mixedFraction.Denominator);
            int simplifiedNumeratorRemainder = mixedFraction.NumeratorRemainder / gcd;
            int simplifiedDenominator = mixedFraction.Denominator / gcd;
            return new MixedFraction(mixedFraction.Whole, simplifiedNumeratorRemainder, simplifiedDenominator) { IsNegative = mixedFraction.IsNegative };
        }
        private static int GreatestCommonDivider(int a, int b)
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
