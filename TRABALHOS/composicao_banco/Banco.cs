using System;
class Banco {
    public ContaCorrente[] contas;
    public Poupanca[] poupancas;
    private int numContas;
    private int numPoupancas;
    
    public Banco() {
        contas = new ContaCorrente[100];
        poupancas = new Poupanca[100];
        numContas = 0;
        numPoupancas = 0;
    }

    public void AbrirConta() {
        ContaCorrente novaConta = new ContaCorrente();
        contas[numContas] = novaConta;
        numContas++;
    }

    public void AbrirPoupanca() {
        Poupanca novaPoupanca = new Poupanca();
        poupancas[numPoupancas] = novaPoupanca;
        numPoupancas++;
    }

    public void DecretarFalencia() {
        contas = new ContaCorrente[100];
        poupancas = new Poupanca[100];
        numContas = 0;
        numPoupancas = 0;
    }
}