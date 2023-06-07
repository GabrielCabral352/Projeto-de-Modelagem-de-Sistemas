namespace Domain.Entities;

public class CriancaRecompensa : Entity
{

    public Crianca IdCrianca { get; set; }
    public Recompensa IdRecompensa { get; set; }
    public string DataResgate { get; set; }

    public CriancaRecompensa(Crianca idCrianca, Recompensa idRecompensa, string dataResgate)
    {
        IdCrianca = idCrianca;
        IdRecompensa = idRecompensa;
        DataResgate = dataResgate;
    }
}
