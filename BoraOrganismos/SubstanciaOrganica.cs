namespace BoraOrganismos
{
    public record SubstanciaOrganica(string Nome)
    {
        public List<Molecula> MoleculasComplexas { get; set; } = new();
    }
}