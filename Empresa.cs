public class Empresa
{
    public List<Funcionario> Funcionarios { get; private set; } = new List<Funcionario>();

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }

    public void RemoverFuncionario(int matricula)
    {
        var funcionario = Funcionarios.SingleOrDefault(f => f.Matricula == matricula);
        if (funcionario != null)
        {
            Funcionarios.Remove(funcionario);
        }
    }

    public void ExibirFuncionarios()
    {
        foreach (var funcionario in Funcionarios)
        {
            funcionario.ExibirInformacoes();
        }
    }
}
