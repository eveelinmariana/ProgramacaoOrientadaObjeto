using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Vendedor {
    private string nome;
    private double comissao;

    public Vendedor(string nome, double comissao) {
        this.nome = nome;
        this.comissao = comissao;
    }

    public string Nome {
        get { return nome; }
        set { nome = value; }
    }

    public double Comissao {
        get { return comissao; }
        set { comissao = value; }
    }

    public void Vende(Produto produto, int quantidade) {
        double valorVenda = produto.Preco * quantidade * (1 - comissao);
        Console.WriteLine("Venda realizada: " + quantidade + " " + produto.Nome + " por R$" + valorVenda);
    }
}