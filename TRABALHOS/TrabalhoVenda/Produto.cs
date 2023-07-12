using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Tamanho { get; set; }
        
        public Produto (string n, double p, int t)
        {
            Nome = n;
            Preco = p;
            Tamanho = t;
        }
        
        public void Mostrar()
        {
            Console.WriteLine("Nome: " + Nome + "\tPreço:R$  "
            + Preco + "\tTamanho: " + Tamanho);
        }
    }