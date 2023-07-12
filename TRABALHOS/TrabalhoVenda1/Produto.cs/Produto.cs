using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Produto {
    private string nome;
    private double preco;
    private string tamanho;

    public Produto(string nome, double preco, string tamanho) {
        this.nome = nome;
        this.preco = preco;
        this.tamanho = tamanho;
    }

    public string Nome {
        get { return nome; }
        set { nome = value; }
    }

    public double Preco {
        get { return preco; }
        set { preco = value; }
    }

    public string Tamanho {
        get { return tamanho; }
        set { tamanho = value; }
    }
}