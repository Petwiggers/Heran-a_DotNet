namespace ClassesHerança;
//Peterson Wiggers

public class Coordenador : Funcionario
{
    public string SenhaAlarme { get; set; }

    public Coordenador(string senha_alarme = "", string nome = "", string cpf = "", string rg = "",
         Endereco? logradouro = null, string matricula = "", decimal salario = 0)  : base(nome, cpf, rg, logradouro, matricula, salario) 
    {
        SenhaAlarme = senha_alarme;
    }

    public Coordenador(Funcionario funcionario, string senha_alarme) : base(funcionario.Nome, funcionario.Cpf, funcionario.Rg, funcionario.Logradouro, funcionario.Matricula, funcionario.Salario)
    {
        SenhaAlarme = senha_alarme;
    }
}