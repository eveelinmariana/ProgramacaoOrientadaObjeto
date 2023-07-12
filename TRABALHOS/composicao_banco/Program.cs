using System;
    
        Banco meuBanco = new Banco();

        meuBanco.AbrirConta();
        ContaCorrente minhaConta = meuBanco.contas[0];
        minhaConta.Depositar(1000);
        minhaConta.Sacar(500);
        minhaConta.GerarExtrato();

        meuBanco.AbrirPoupanca();
        Poupanca minhaPoupanca = meuBanco.poupancas[0];
        minhaPoupanca.Depositar(5000);
        minhaPoupanca.GerarRendimentos();
        Console.WriteLine("Saldo da poupança: {0}", minhaPoupanca.GetSaldo());

        meuBanco.DecretarFalencia();

