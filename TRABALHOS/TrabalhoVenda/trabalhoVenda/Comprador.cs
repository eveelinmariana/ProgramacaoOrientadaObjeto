using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        public int CodComprador { get; set; }
        public string NomeComprador { get; set; }
        public double Verba { get; set; }

        public Comprador(int codigo, string nome, double verba)
        {
            CodComprador = codigo;
            NomeComprador = nome;
            Verba = verba;
        }

        public void MostrarComprador() {
            Console.WriteLine($"Código do comprador: {CodComprador} \tNome: {NomeComprador} \tVerba {Verba}");
        }
    }
}