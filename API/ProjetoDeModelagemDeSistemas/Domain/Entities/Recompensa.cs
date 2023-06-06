namespace Domain.Entities;

public class Recompensa : Entity
{
    public string nomeRecompensa { get; private set; }
    public string descricao { get; private set; }
    public int recompensaPontos { get; set; }

    public Recompensa(string nomeRecompensa,string descricao, int recompensaPontos)
    {
        nomeRecompensa = nomeRecompensa
        descricao = descricao
        recompensaPontos = recompensaPontos
    }
}
