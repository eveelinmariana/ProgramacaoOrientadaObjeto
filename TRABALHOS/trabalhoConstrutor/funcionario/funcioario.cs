public class Funcionario {
    private static int codigoInicial = 100;
    public int Codigo { get; }
    public string Nome { get; set; }
    public double Salario { get; set; }

    public Funcionario(string nome, double salario) {
        Codigo = ++codigoInicial;
        Nome = nome;
        Salario = salario;
    }

    public void AumentoSalario(double percentual) {
        Salario *= 1 + percentual / 100;
    }
}