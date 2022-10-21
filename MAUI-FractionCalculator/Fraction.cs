using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_FractionCalculator
{
    public class Fraction
    {
        public bool IsNegative { get; set; } = true;
        public int Whole { get { return (Numerator - Numerator % Denominator) / Denominator; } }
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public Fraction(int nominator, int denominator)
        {
            Numerator = nominator;
            Denominator = denominator;
        }   
    }
}
