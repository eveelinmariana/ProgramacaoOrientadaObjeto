using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public List<Dependente> VetDependentes { get; set; }
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            VetDependentes = new List<Dependente>();  
        }
        public abstract double CalcularSalario(int diasUteis);
        public virtual void MostrarFuncionario()
        {
            Console.WriteLine($"Código: {Codigo} \t| Nome: {Nome} \t| Salário: {Salario:C}");
        }
        public void AdicionarDependente(Dependente dep)
        {
            VetDependentes.Add(dep);
        }
        public void RemoverDependente(int codigo)
        {
            for (int i = 0; i < VetDependentes.Count; i++)
            {
                Dependente dep = VetDependentes.ElementAt<Dependente>(i);
                if (dep.Codigo == codigo)
                    VetDependentes.Remove(dep);
            }
        }
        public void ListarDependentes()
        {
            Console.Write($"Dependentes do funcionário {Nome}");
            Console.Write("\n");
            for (int i = 0; i < VetDependentes.Count; i++)
            {
                Dependente dep = VetDependentes.ElementAt<Dependente>(i);
                dep.MostrarDependente();
            }
        }
    }
}