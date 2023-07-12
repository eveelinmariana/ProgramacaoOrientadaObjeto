using System;
class Poupanca {
    private double saldo;

    public Poupanca() {
        saldo = 0;
    }

    public void Depositar(double valor) {
        saldo += valor;
    }

    public void Sacar(double valor) {
        if (saldo < valor) {
            Console.WriteLine("Saldo insuficiente.");
        } else {
            saldo -= valor;
        }
    }

    public void GerarRendimentos() {
        saldo *= 1.01;
    }

    public double GetSaldo() {
        return saldo;
    }
}