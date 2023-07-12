using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public static int IdVenda { get; set; }
        
        public Comprador Comprador { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<Produto> ListaProduto { get; set; }

        public void MostrarVenda() {
            System.Console.WriteLine($"\nCódigo da venda: {IdVenda}");
            Comprador.MostrarComprador();
            Vendedor.MostrarVendedor();
        }

        static Venda() {
            IdVenda = 0;
        }

        public Venda() {
            IdVenda ++;
        }

    }
}