using Heranca;

Funcionario f = new Funcionario();
f.Codigo = 1;
f.Nome = "Evelin";
f.Salario = 2500;
f.Mostrar();

Mensalista m = new Mensalista();
m.Codigo= 2;
m.Nome = "João";
m.Salario = 1500;
m.QuantidadeHoras = 7;
m.Mostrar();


Horista h = new Horista();
h.Codigo = 3;
h.Nome = "Giovana";
h.Salario = 25000;
h.HorasSemTrabalhar = 2;
h.Mostrar();