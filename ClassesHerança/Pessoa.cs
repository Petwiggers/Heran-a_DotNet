namespace ClassesHerança;
//Peterson Wiggers
public class Pessoa
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public Endereco Logradouro { get; set; }
    public Pessoa(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null)
    {
        Nome = nome;
        Cpf = cpf;
        Rg = rg;
        Logradouro = logradouro ?? new Endereco();
    }
    
}