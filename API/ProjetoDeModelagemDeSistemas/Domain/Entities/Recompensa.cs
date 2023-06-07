namespace Domain.Entities;

public class Recompensa : Entity
{
    public string NomeRecompensa { get; private set; }
    public string Descricao { get; private set; }
    public int RecompensaPontos { get; set; }

    public Recompensa(string nomeRecompensa, string descricao, int recompensaPontos)
    {
        NomeRecompensa = nomeRecompensa;
        Descricao = descricao;
        RecompensaPontos = recompensaPontos;
    }
}
