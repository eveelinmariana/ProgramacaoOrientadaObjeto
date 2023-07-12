using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        public int CodVendedor { get; set; }
        public string NomeVendedor { get; set; }
        public double Comissao { get; set; }

        public Vendedor(int codigo, string nome, double comissao) {
            CodVendedor = codigo;
            NomeVendedor = nome;
            Comissao = comissao;
        }
        public void MostrarVendedor() {
            System.Console.WriteLine($"Código do vendedor: {CodVendedor} \tNome: {NomeVendedor} \tComissão: {Comissao}");
        }
    }
}