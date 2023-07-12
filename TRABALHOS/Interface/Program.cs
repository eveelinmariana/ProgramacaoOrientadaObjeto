using Interface;

ContaCorrente conta = new ContaCorrente();
conta.Saldo = 1000.0;

SeguroVida seguro = new SeguroVida();

TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
totalizador.Adiciona(conta);
totalizador.Adiciona(seguro);

Console.WriteLine("Total de tributos: " + totalizador.Total);
