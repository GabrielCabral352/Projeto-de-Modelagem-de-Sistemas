namespace Domain.Entities;

public class Crianca_Recompensa : Entity
{

    public Crianca idCrianca { get; set; }
    public Recompensa idRecompensa { get; set; }
    public string dataResgate { get; set; }

    public CriancRecompensa(Crianca idCrianca,Recompensa idRecompensa, string dataResgate)
    {
        idCrianca = idCrianca
        idRecompensa= idRecompensa
        dataResgate= dataResgate
    }
}
