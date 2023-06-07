namespace Domain.Entities;

public class CriancaAtividade : Entity
{

    public Crianca IdCrianca { get; set; }
    public Atividade IdAtividade { get; set; }
    public bool Realizado { get; set; }

    public CriancaAtividade(int idCrianca, Atividade idAtividade, bool realizado)
    {
        IdCrianca.Id = idCrianca;
        IdAtividade = idAtividade;
        Realizado = realizado;
    }
}
