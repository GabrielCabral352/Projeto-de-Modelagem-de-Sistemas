namespace Domain.Entities;

public class Crianca : Entity
{
    public string NomeCompleto { get; private set; }
    public string Cpf { get; private set; }
    public string UserName { get; set; }
    public Pais IdPais { get; set; }
    public string DataNascimento { get; set; }
    public int Pontuacao { get; set; }

    public Crianca(string nomeCompleto, string cpf, string userName, Pais idPais, string dataNascimento, int pontuacao)
    {
        NomeCompleto = nomeCompleto;
        Cpf = cpf;
        UserName = userName;
        IdPais = idPais;
        DataNascimento = dataNascimento;
        Pontuacao = pontuacao;
    }
}
