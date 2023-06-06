namespace Domain.Entities;

public class Crianca_Atividade : Entity
{

    public Crianca idCrianca { get; set; }
    public Atividade idAtividade { get; set; }
    public bool realizado { get; set; }

    public CriancAtividade(Crianca idCrianca,Atividade idAtividade, bool realizado)
    {
        idCrianca = idCrianca
        idAtividade= idAtividade
        realizado= realizado
    }
}
