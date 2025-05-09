public record SubstanciaInorganica(string Nome)
{
    public List<Molecula> MoleculasSimples { get; set; } = new();
}