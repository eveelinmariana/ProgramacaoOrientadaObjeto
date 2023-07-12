using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class ContaCorrente : ITributavel
    {
        public double Saldo { get; set; }

        public double CalcularTributos()
        {
            return Saldo * 0.05;
        }
    }
 

}