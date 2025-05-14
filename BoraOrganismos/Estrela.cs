namespace BoraOrganismos;

public class Estrela(int protons) : IMassivo
{
    public double Massa => ProtonsLivres.Sum(p => p.Massa) +
                            EletronsLivres.Sum(e => e.Massa) +
                            HeliosFormados.Sum(he => he.Massa);
    public Queue<Particula> ProtonsLivres { get; init; } = new(Enumerable.Range(0, protons).Select(_ => Particula.CriarProton()));
    public Queue<Particula> EletronsLivres { get; init; } = new(Enumerable.Range(0, protons).Select(_ => Particula.CriarEletron()));
    public Queue<Atomo> HeliosFormados { get; init; } = new();

    /// <summary>
    /// Fusão nuclear completa: 4H¹ → He⁴
    /// https://chatgpt.com/share/6824ec17-543c-8013-b49d-f79c19045d58
    /// </summary>
    public void FundirCadeiaPP()
    {
        var deuterio1 = FundirDeuterio(); // D²
        var deuterio2 = FundirDeuterio(); // D²
        var he3a = FundirHelio3(deuterio1); // He³
        var he3b = FundirHelio3(deuterio2); // He³
        var he4 = FundirHelio4(he3a, he3b); // He⁴ final
        HeliosFormados.Enqueue(he4); // Armazena o He⁴ resultante
    }

    /// <summary>
    /// Etapa 1: H¹ + H¹ → D² + positron + neutrino (simulada como D² apenas)
    /// </summary>
    Atomo FundirDeuterio()
    {
        if (ProtonsLivres.Count < 2)
            throw new InvalidOperationException("Quantidade insuficiente de prótons livres.");

        if (EletronsLivres.Count < 1)
            throw new InvalidOperationException("Quantidade insuficiente de elétrons livres.");

        // Simula decaimento beta⁺: um dos prótons vira nêutron
        ProtonsLivres.Dequeue();
        var neutron = Particula.CriarNeutron();

        // Monta o átomo de deutério (²H)
        var nucleons = new List<Particula> { ProtonsLivres.Dequeue(), neutron };
        var eletrons = new List<Particula> { EletronsLivres.Dequeue() };
        var deuterio = new Atomo(Elemento.H, nucleons, eletrons);

        return deuterio;
    }

    /// <summary>
    /// Etapa 2: D² + H¹ → He³ + fóton
    /// </summary>
    Atomo FundirHelio3(Atomo deuterio)
    {
        if (ProtonsLivres.Count < 1)
            throw new InvalidOperationException("Sem prótons suficientes para fusão com deutério.");

        // Retira um próton livre
        var proton = ProtonsLivres.Dequeue();

        // Libera os elétrons que estavam no deuterio
        foreach (var eletron in deuterio.Eletrons)
            EletronsLivres.Enqueue(eletron);

        // Coleta os nucleons do deutério (¹p + ¹n) e adiciona mais um próton: total 2 prótons + 1 nêutron = ³He        
        var nucleons = deuterio.Nucleons.Append(proton).ToList();

        // Elétron não participa dessa fusão nuclear (³He ainda é um núcleo nu)
        var helio3 = new Atomo(Elemento.He, nucleons, []);

        // Emite um fóton simbólico como energia liberada
        var foton = Particula.CriarFoton();

        return helio3;
    }

    /// <summary>
    /// Etapa 3: He³ + He³ → He⁴ + 2H¹
    /// </summary>
    Atomo FundirHelio4(Atomo he3a, Atomo he3b)
    {
        // Verifica que ambos são de fato ³He com 3 nucleons
        if (he3a.Nucleons.Count != 3 || he3b.Nucleons.Count != 3)
            throw new ArgumentException("Ambos os átomos devem ser ³He (2p + 1n)");

        // Junta todos os nucleons (total: 4 prótons, 2 nêutrons)
        var nucleons = he3a.Nucleons.Concat(he3b.Nucleons).ToList();

        // Seleciona 2 prótons para liberar
        var protonsParaLibertar = nucleons
                                .Where(p => p.Tipo == TipoParticula.Proton)
                                .Take(2)
                                .ToList();

        foreach (var p in protonsParaLibertar)
            nucleons.Remove(p); // Remove do núcleo

        // Resultado: 2 prótons e 4 nucleons restantes (2p + 2n) → ⁴He
        var helio4 = new Atomo(Elemento.He, nucleons, []);

        // Libera fótons como energia da fusão
        var fotons = new[]
        {
            Particula.CriarFoton(),
            Particula.CriarFoton()
        };

        // Reenfileira os prótons resultantes como prótons livres
        foreach (var proton in protonsParaLibertar)
            ProtonsLivres.Enqueue(proton);

        return helio4;
    }
}