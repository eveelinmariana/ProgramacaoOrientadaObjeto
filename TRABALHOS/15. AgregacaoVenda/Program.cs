// Funcao Main()

using AgregacaoVenda;
Console.Clear();


Venda v1 = new Venda();
Comprador comprador = new Comprador(1, "Rafael", 1550.90);
Vendedor vendedor = new Vendedor(999, "Evelin", 2);
Produto prod1 = new Produto(111, "Mouse", 24.80, 1);
Produto prod2 = new Produto(101, "Monitor", 626.90, 1);
Produto prod3 = new Produto(103, "Teclado", 128.80, 1);

v1.Comprador = comprador;
v1.Vendedor = vendedor;
v1.ListaProduto = new List<Produto>();
v1.ListaProduto.Add(prod1);
v1.ListaProduto.Add(prod2);
v1.ListaProduto.Add(prod3);

v1.MostrarVenda();
Console.WriteLine("\n____________________________________ITENS VENDAS____________________________________ \n");
foreach(Produto prod in v1.ListaProduto) {
    prod.MostrarProduto();
}

vendedor.MostrarVendedor();
