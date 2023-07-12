using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Mensalista : Funcionario
    {
        private int qtdeHorasTrabalhadas;

        public Mensalista()
        { }

        public Mensalista (int codigo, string nome, double salario, int qtdeHorasTrabalhadas) : base (codigo, nome, salario)
        {
            QuantidadeHoras = qtdeHorasTrabalhadas;
        }
        public int QuantidadeHoras
        {
            get { return qtdeHorasTrabalhadas; }
            set { qtdeHorasTrabalhadas = value; }
        }
        
        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("\tQuantidade de Horas Trabalhadas: "+QuantidadeHoras);

        }

    }
}