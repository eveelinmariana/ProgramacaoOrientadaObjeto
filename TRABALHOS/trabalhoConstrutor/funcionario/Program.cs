using System;

        Funcionario f1 = new Funcionario("Evelin", 2000);
        Funcionario f2 = new Funcionario("Gabriela", 2500);
        Funcionario f3 = new Funcionario("Ana", 3000);

        f1.AumentoSalario(10); 
        f2.AumentoSalario(5); 
        f3.AumentoSalario(7.5); 

        Console.WriteLine("Funcionário 1: código " + f1.Codigo + ", nome " + f1.Nome + ", salário " + f1.Salario);
        Console.WriteLine("Funcionário 2: código " + f2.Codigo + ", nome " + f2.Nome + ", salário " + f2.Salario);
        Console.WriteLine("Funcionário 3: código " + f3.Codigo + ", nome " + f3.Nome + ", salário " + f3.Salario);

