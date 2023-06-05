namespace Domain.Entities;

public class Atividade : Entity
{
    public string nomeAtividade { get; private set; }
    public string descricao { get; private set; }
    public int pontos { get; set; }

    public Atividade(string nomeAtividade,string descricao, int pontos)
    {
        nomeAtividade = nomeAtividade
        descricao = descricao
        pontos = pontos
    }
}
