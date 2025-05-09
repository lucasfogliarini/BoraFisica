using BoraOrganismos;

public record Atomo(string Elemento, int NumeroAtomico, int MassaAtomica)
{
    public List<Particula> Nucleo { get; set; } = [];
    public List<Particula> CamadaEletronica { get; set; } = [];
}