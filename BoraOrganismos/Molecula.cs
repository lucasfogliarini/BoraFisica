namespace BoraOrganismos
{
    public record Molecula(string FormulaQuimica)
    {
        public List<Atomo> Componentes { get; set; } = [];
    }
}