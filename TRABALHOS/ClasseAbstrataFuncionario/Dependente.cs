using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ClasseAbstrataFuncionario
{
    public class Dependente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Dependente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }
        public virtual void MostrarDependente()
        {
            Console.WriteLine($"Código: {Codigo} | Nome: {Nome} | Idade: {Idade}");
        }
        public bool VerificarMaiorIdade()
        {
            return Idade > 18 ? true : false;
        }
    }
}