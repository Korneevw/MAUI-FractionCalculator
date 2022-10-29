using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_FractionCalculator
{
    public class MixedFraction : Fraction
    {
        //public int Whole
        //{
        //    get
        //    {
        //        return (base.Numerator - base.Numerator % Denominator) / Denominator;
        //    }
        //    set
        //    {
        //        base.Numerator = NumeratorRemainder + value * Denominator;
        //    }
        //}
        public int Whole { get; set; }
        public override int Numerator
        {
            get
            {
                return NumeratorRemainder + Whole * Denominator;
            }
            set
            {
                base.Numerator = value;
            }
        }
        public int NumeratorRemainder { get; set; }
        //public int NumeratorRemainder
        //{
        //    get
        //    {
        //        return base.Numerator - Whole * Denominator;
        //    }
        //    set
        //    {
        //        Numerator = Whole * Denominator + value;
        //    }
        //}
        public MixedFraction(Fraction f) : base(f.Numerator, f.Denominator)
        {
            Whole = (f.Numerator - f.Numerator % f.Denominator) / f.Denominator;
            NumeratorRemainder = f.Numerator - Whole * f.Denominator;
            IsNegative = f.IsNegative;
        }
        public MixedFraction(int whole, int numeratorRemainder, int denominator) : base(numeratorRemainder + whole * denominator, denominator) 
        {
            Whole = whole;
            NumeratorRemainder = numeratorRemainder;
        }
    }
}
