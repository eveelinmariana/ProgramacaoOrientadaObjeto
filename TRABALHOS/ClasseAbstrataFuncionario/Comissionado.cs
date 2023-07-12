using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataFuncionario
{
    public class Comissionado : Funcionario
    {
        public double Porcentagem { get; set; }
        public Comissionado(int codigo, string nome, double salario, double porcentagem)
        : base(codigo, nome, salario)
        {
            Porcentagem = porcentagem;
        }
        public override double CalcularSalario(int diasUteis)
        {
            return Salario = Salario += Salario / 30 * diasUteis * Porcentagem;
        }
        public override void MostrarFuncionario()
        {
            base.MostrarFuncionario();
            Console.WriteLine($"\t Porcentagem: {Porcentagem * 100}%");
        }
    }
}