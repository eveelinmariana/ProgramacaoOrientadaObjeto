using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        public int IdProduto { get; set; }
        private string nomeProduto;
        public double Preco { get; set; }
        public int Tamanho { get; set; }
        public string NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }

        public void MostrarProduto() {
            Console.WriteLine($"ID do Produto: {IdProduto} \tNome: {NomeProduto} \tPreço: {Preco:C} \tTamanho: {Tamanho} und.");
        }

        public Produto(int id, string nome, double preco, int tamanho)
        {
            IdProduto = id;
            NomeProduto = nome;
            Preco = preco;
            Tamanho = tamanho;
        }

    }
}