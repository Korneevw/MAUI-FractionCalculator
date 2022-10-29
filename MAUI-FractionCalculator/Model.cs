using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_FractionCalculator
{
    public class Model
    {
        public FractionOperation Operation { get; set; }
        public MixedFraction FractionA { get; set; } = new MixedFraction(0, 1, 1);
        public MixedFraction FractionB { get; set; } = new MixedFraction(0, 1, 1);
        public List<FractionOperation> Operations { get; private set; } = new List<FractionOperation>()
        {
            new Addition(),
            new Substraction(),
            new Multiplication(),
            new Division(),
        };
    }
}
