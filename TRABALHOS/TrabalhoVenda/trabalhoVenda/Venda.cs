using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public static int CodVenda { get; set; }
        
        public Comprador Comprador { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<Produto> VetorProd { get; set; }

        public void MostrarVenda() {
            System.Console.WriteLine($"\nCódigo da venda: {CodVenda}");
            Comprador.MostrarComprador();
            Vendedor.MostrarVendedor();
        }

        static Venda() {
            CodVenda = 0;
        }

        public Venda() {
            CodVenda ++;
        }

    }
}