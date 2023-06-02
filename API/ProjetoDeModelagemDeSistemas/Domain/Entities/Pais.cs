namespace Domain.Entities;

public class Pais : Entity
{
    public string NomeCompleto { get; private set; }
    public string Cpf { get; private set; }
    public string UserName { get; set; }
    public string Senha { get; private set; }
    public string Email { get; set; }
    public string Telefone { get; set; }

    public Pais(string nomeCompleto, string cpf, string userName, string senha, string email, string telefone)
    {
        NomeCompleto = nomeCompleto;
        Cpf = cpf;
        UserName = userName;
        Senha = senha;
        Email = email;
        Telefone = telefone;
    }
}
