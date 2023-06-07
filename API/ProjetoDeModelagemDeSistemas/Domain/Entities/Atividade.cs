namespace Domain.Entities;

public class Atividade : Entity
{
    public string NomeAtividade { get; private set; }
    public string Descricao { get; private set; }
    public int Pontos { get; set; }

    public Atividade(string nomeAtividade, string descricao, int pontos)
    {
        NomeAtividade = nomeAtividade;
        Descricao = descricao;
        Pontos = pontos;
    }
}
