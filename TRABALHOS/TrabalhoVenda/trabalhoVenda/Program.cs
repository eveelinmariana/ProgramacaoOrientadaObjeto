// Funcao Main()

using AgregacaoVenda;
Console.Clear();


Venda v1 = new Venda();
Comprador comprador = new Comprador(1, "Paulo", 45.30);
Vendedor vendedor = new Vendedor(111, "Maiara", 5);
Produto prod1 = new Produto(222, "Arroz", 24.80, 5);
Produto prod2 = new Produto(333, "Feijão", 6.90, 1);
Produto prod3 = new Produto(444, "Açúcar", 8.90, 1);

v1.Comprador = comprador;
v1.Vendedor = vendedor;
v1.VetorProd = new List<Produto>();
v1.VetorProd.Add(prod1);
v1.VetorProd.Add(prod2);
v1.VetorProd.Add(prod3);

v1.MostrarVenda();
System.Console.WriteLine("\n************************************ Itens da Venda ************************************\n");
foreach(Produto prod in v1.VetorProd) {
    prod.MostrarProduto();
}
