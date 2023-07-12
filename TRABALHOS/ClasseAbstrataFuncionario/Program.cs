//main()

using ClasseAbstrataFuncionario;

Comissionado fun1 = new Comissionado(33, "EVELIN MARIANA", 2000, 0.20);
fun1.CalcularSalario(24);
Comissionado fun2 = new Comissionado(44, "RAFAEL NASCIMENTO", 2000, 0.20);
fun2.CalcularSalario(24);
Comissionado fun3 = new Comissionado(55, "HÉLIO APARECIDO", 2000, 0.20);
fun3.CalcularSalario(24);
Assalariado fun4 = new Assalariado(66, "ANTONIA VALDENI", 3000);
fun4.CalcularSalario(24);
Assalariado fun5 = new Assalariado(77, "JOÃO VITOR", 3000);
fun5.CalcularSalario(24);
Assalariado fun6 = new Assalariado(88, "HELENA NASCIMENTO", 3000);
fun6.CalcularSalario(24);
Assalariado fun7 = new Assalariado(99, "EVANDRO OLIVEIRA", 5000);
fun7.CalcularSalario(24);
Assalariado fun8 = new Assalariado(111, "ANA LAURA ", 5000);
fun8.CalcularSalario(24);
Assalariado fun9 = new Assalariado(122, "JOÃO GABRIEL", 5000);
fun9.CalcularSalario(24);

Departamento dep1 = new Departamento(302, "Atendimento");
dep1.Admitir(fun1);
dep1.Admitir(fun2);
dep1.Admitir(fun3);
dep1.ListarFuncionarios();

Departamento dep2 = new Departamento(403, "Financeiro");
dep2.Admitir(fun4);
dep2.Admitir(fun5);
dep2.Admitir(fun6);
dep2.ListarFuncionarios();

Departamento dep3 = new Departamento(606, "Compras e Vendas");
dep3.Admitir(fun7);
dep3.Admitir(fun8);
dep3.Admitir(fun9);
dep3.ListarFuncionarios();

/* dep1.Demitir(33);
dep3.Demitir(111);
dep3.Demitir(122);

Console.WriteLine("\n\tApós a exclusão\t");
dep1.ListarFuncionarios();
dep2.ListarFuncionarios();
dep3.ListarFuncionarios(); */

Console.WriteLine("\n\tFolha de pagamento dos departamentos\t\n");
Console.WriteLine($"Departamento: {dep1.Descricao} \t| Folha: {dep1.CalcularFolha(24):C}");
Console.WriteLine($"Departamento: {dep2.Descricao} \t| Folha: {dep2.CalcularFolha(24):C}");
Console.WriteLine($"Departamento: {dep3.Descricao} \t| Folha: {dep3.CalcularFolha(24):C}");

Dependente depen1 = new Dependente(913, "JOSÉ FELIPE", 15);
Dependente depen2 = new Dependente(781, "SOPHIA RODRIGUES", 21);
Dependente depen3 = new Dependente(981, "RAFAELA TAVARES", 11);
Dependente depen4 = new Dependente(113, "ANTONIO PEREIRA", 19);

fun1.AdicionarDependente(depen1);
fun1.AdicionarDependente(depen4);
fun1.AdicionarDependente(depen3);

fun1.ListarDependentes();

fun1.RemoverDependente(981); 
fun1.RemoverDependente(781); 
fun1.RemoverDependente(113);
fun1.ListarDependentes();


dep1.QuantDependente(); 

