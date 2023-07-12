using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Comprador 
{
    private string nome;
    private double verba;

    public Comprador(string nome, double verba) {
        this.nome = nome;
        this.verba = verba;
    }

    public string Nome 
    {
        get { return nome; }
        set { nome = value; }
    }

    public double Verba 
    {
        get { return verba; }
        set { verba = value; }
    }

    public void Compra( Produto produto, int quantidade) 
    {
        double valorCompra = produto.Preco * quantidade;
        if (valorCompra <= verba) {
            verba -= valorCompra;
            Console.WriteLine("Compra realizada: " + quantidade + " " + produto.Nome + " por R$" + valorCompra);
        } else {
            Console.WriteLine("Compra não realizada: saldo insuficiente.");
        }
    }
}
