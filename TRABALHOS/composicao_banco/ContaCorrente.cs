using System;
class ContaCorrente {
    private double saldo;
    private double chequeEspecial;

    public ContaCorrente() {
        saldo = 0;
        chequeEspecial = 1000;
    }

    public void Depositar(double valor) {
        saldo += valor;
    }

    public void Sacar(double valor) {
        if (saldo + chequeEspecial < valor) {
            Console.WriteLine("Saldo insuficiente.");
        } else {
            saldo -= valor;
        }
    }

    public void GerarExtrato() {
        Console.WriteLine("Saldo: {0}\nCheque especial: {1}", saldo, chequeEspecial);
    }
}