using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        public int IdComprador { get; set; }
        public double Verba { get; set; }
        public string NomeComprador { get; set; }
        

        public Comprador(int id, string nome, double verba)
        {
            IdComprador = id;
            NomeComprador = nome;
            Verba = verba;
        }

        public void MostrarComprador() {
            Console.WriteLine($"ID do comprador: {IdComprador} \tNome: {NomeComprador} \tVerba {Verba}");
        }
    }
}