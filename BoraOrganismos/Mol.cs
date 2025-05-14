namespace BoraOrganismos;

public record Mol(IReadOnlyList<Atomo> Atomos) : IMassivo
{
    /// <summary>
    /// Constante de Avogadro: número de entidades (átomos ou moléculas) por mol.
    /// </summary>
    public const double Avogadro = 6.02214076e23;

    /// <summary>
    /// Conversão de unidade de massa atômica (u) para gramas.
    /// 1 u ≈ 1.66053906660 × 10⁻²⁴ g
    /// </summary>
    public const double UnidadeMassaAtomicaEmGramas = 1.66053906660e-24;

    /// <summary>
    /// Nome gerado automaticamente com base na composição do mol.
    /// </summary>
    public string Nome => string.Join("", ComposicaoPorElemento.Select(kvp => $"{kvp.Key}{(kvp.Value > 1 ? kvp.Value : "")}"));

    /// <summary>
    /// Massa de todos os átomos do sistema (em unidades de massa atômica).
    /// </summary>
    public double Massa => Atomos.Sum(atomo => atomo.Massa);

    /// <summary>
    /// Massa atômica convertida para gramas.
    /// </summary>
    public double MassaEmGramas => Massa * UnidadeMassaAtomicaEmGramas;

    /// <summary>
    /// Número total de átomos presentes no sistema.
    /// </summary>
    public int QuantidadeDeAtomos => Atomos.Count;

    /// <summary>
    /// Quantidade de mols representada por esse conjunto de átomos.
    /// </summary>
    public double QuantidadeEmMols => QuantidadeDeAtomos / Avogadro;

    /// <summary>
    /// Dicionário com a contagem de cada elemento presente no sistema.
    /// </summary>
    public Dictionary<Elemento, int> ComposicaoPorElemento =>
        Atomos.GroupBy(a => a.Elemento)
              .ToDictionary(g => g.Key, g => g.Count());
}