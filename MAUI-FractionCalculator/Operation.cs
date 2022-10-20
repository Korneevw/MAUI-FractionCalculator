using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_FractionCalculator
{
    public abstract class FractionOperation
    {
        public string Symbol { get; set; } = "Unknown";
        abstract public Fraction Operate(Fraction a, Fraction b);
    }
}
