using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class SeguroVida : ITributavel
    {
        public double CalcularTributos()
        {
            return 75.0;
        }
    }
}