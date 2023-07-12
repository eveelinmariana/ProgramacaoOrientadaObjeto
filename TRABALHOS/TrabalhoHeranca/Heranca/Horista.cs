using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Horista : Funcionario
    {
        private int horasSemTrabalhar ;

        public Horista()
        {  }

        public Horista (int codigo, string nome, double salario, int horasSemTrabalhar) : base (codigo, nome, salario)
        {
            HorasSemTrabalhar = horasSemTrabalhar;
        }
    
         public int HorasSemTrabalhar
         {
            get { return horasSemTrabalhar; }
            set { horasSemTrabalhar = value; }
         }
        
        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("\tQuantidade de Horas Sem trabalhadas: "+HorasSemTrabalhar);

        }
    }
}