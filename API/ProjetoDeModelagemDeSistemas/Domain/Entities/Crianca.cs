namespace Domain.Entities;

public class Crianca : Entity
{
    public string NomeCompleto { get; private set; }
    public string Cpf { get; private set; }
    public string UserName { get; set; }
    public Pais idPais { get; set; }
    public string dataNascimento { get; set; }
    public int pontuacao { get; set; }

    public Crianca(string NomeCompleto,string Cpf, string UserName, Pais idPais, string dataNascimento, int pontuacao)
    {
        NomeCompleto = NomeCompleto
        Cpf = Cpf
        UserName = UserName
        idPais = idPais
        dataNascimento = dataNascimento
        pontuacao = pontuacao
    }
}
