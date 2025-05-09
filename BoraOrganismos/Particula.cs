namespace BoraOrganismos
{
    public record Particula(TipoParticula Tipo, double Carga, double Massa, double Spin);

    public enum TipoParticula
    {
        Proton,
        Neutron,
        Eletron,
        Foton
    }
}