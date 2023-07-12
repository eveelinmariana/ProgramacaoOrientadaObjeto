using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        public int CodProduto { get; set; }
        private string nomeProduto;
        public double Preco { get; set; }
        public int Tamanho { get; set; }
        public string NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }

        public void MostrarProduto() {
            Console.WriteLine($"Código do Produto: {CodProduto} \tNome: {NomeProduto} \tPreço: {Preco:C} \tTamanho: {Tamanho} kg.");
        }

        public Produto(int codigo, string nome, double preco, int tamanho)
        {
            CodProduto = codigo;
            NomeProduto = nome;
            Preco = preco;
            Tamanho = tamanho;
        }

    }
}