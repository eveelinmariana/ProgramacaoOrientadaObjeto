using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public List<Funcionario> VetFuncionarios { get; set; }
        public Departamento(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
            VetFuncionarios = new List<Funcionario>();
        }
        public void Admitir(Funcionario func)
        {
            VetFuncionarios.Add(func);
        }
        public void Demitir(int codigo)
        {
            for (int i = 0; i < VetFuncionarios.Count; i++)
            {
                Funcionario func = VetFuncionarios.ElementAt<Funcionario>(i);
                if (func.Codigo == codigo)
                    VetFuncionarios.Remove(func);
            }
        }
        public void ListarFuncionarios()
        {
            Console.Write($"\n\tFunciários do departamento {Descricao} \n");
            Console.Write("\n");
            for (int i = 0; i < VetFuncionarios.Count; i++)
            {
                Funcionario func = VetFuncionarios.ElementAt<Funcionario>(i);
                func.MostrarFuncionario();
            }
        }
         public void QuantDependente()
        {
            int count_dependentes = 0;
            for (int i = 0; i < VetFuncionarios.Count; i++)
            {
                Funcionario func = VetFuncionarios.ElementAt<Funcionario>(i);
                for (int j = 0; j < func.VetDependentes.Count; j++)
                {
                    count_dependentes++;
                }
            }
            Console.WriteLine($"\nO departamento {Descricao} possui {count_dependentes} dependentes.");
        }
        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
                for (int i = 0; i < VetFuncionarios.Count; i++)
                {
                    Funcionario func = VetFuncionarios.ElementAt<Funcionario>(i);
                    folha = folha + func.CalcularSalario(diasUteis);
                }
            return folha;
        }
    }
}