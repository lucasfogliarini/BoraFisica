namespace BoraFisica;
public static class MolFactory
{
    /// <summary>
    /// Cria uma molécula de um elemento.
    /// </summary>
    public static Mol Criar(Elemento elemento)
    {
        return new Mol([Atomo.CriarIsotopoAbundante(elemento)]);
    }
    /// <summary>
    /// Cria uma molécula de água (H₂O).
    /// </summary>
    public static Mol CriarH2O()
    {
        var hidrogenio1 = Atomo.Criar(Elemento.H);
        var hidrogenio2 = Atomo.Criar(Elemento.H);
        var oxigenio = Atomo.Criar(Elemento.O);

        return new Mol([hidrogenio1, hidrogenio2, oxigenio]);
    }

    /// <summary>
    /// Cria uma molécula de dióxido de carbono (CO₂).
    /// </summary>
    public static Mol CriarCO2()
    {
        var carbono = Atomo.Criar(Elemento.C);
        var oxigenio1 = Atomo.Criar(Elemento.O);
        var oxigenio2 = Atomo.Criar(Elemento.O);

        return new Mol([carbono, oxigenio1, oxigenio2]);
    }

    /// <summary>
    /// Cria uma molécula de oxigênio (O₂).
    /// </summary>
    public static Mol CriarO2()
    {
        return new Mol([
            Atomo.Criar(Elemento.O),
    Atomo.Criar(Elemento.O)
        ]);
    }

    /// <summary>
    /// Cria uma molécula de ozônio (O₃).
    /// </summary>
    public static Mol CriarO3()
    {
        return new Mol([
            Atomo.Criar(Elemento.O),
            Atomo.Criar(Elemento.O),
            Atomo.Criar(Elemento.O)
        ]);
    }

    /// <summary>
    /// Cria uma molécula de nitrogênio (N₂).
    /// </summary>
    public static Mol CriarN2()
    {
        return new Mol([
            Atomo.Criar(Elemento.N),
            Atomo.Criar(Elemento.N)
        ]);
    }

    /// <summary>
    /// Cria uma molécula de gás de hidrogênio (H₂).
    /// </summary>
    public static Mol CriarH2()
    {
        var hidrogenio1 = Atomo.Criar(Elemento.H);
        var hidrogenio2 = Atomo.Criar(Elemento.H);

        return new Mol([hidrogenio1, hidrogenio2]);
    }

    /// <summary>
    /// Cria uma molécula de amônia (NH₃).
    /// </summary>
    public static Mol CriarAmonia()
    {
        return new Mol([
            Atomo.Criar(Elemento.N),
            Atomo.Criar(Elemento.H),
            Atomo.Criar(Elemento.H),
            Atomo.Criar(Elemento.H)
        ]);
    }

    /// <summary>
    /// Cria uma molécula de metano (CH₄).
    /// </summary>
    public static Mol CriarMetano()
    {
        return new Mol([
            Atomo.Criar(Elemento.C),
            Atomo.Criar(Elemento.H),
            Atomo.Criar(Elemento.H),
            Atomo.Criar(Elemento.H),
            Atomo.Criar(Elemento.H)
        ]);
    }

    /// <summary>
    /// Cria uma molécula de glicose (C₆H₁₂O₆).
    /// </summary>
    public static Mol CriarGlicose()
    {
        var atomos = new List<Atomo>();

        atomos.AddRange(Enumerable.Range(0, 6).Select(_ => Atomo.Criar(Elemento.C)));
        atomos.AddRange(Enumerable.Range(0, 12).Select(_ => Atomo.Criar(Elemento.H)));
        atomos.AddRange(Enumerable.Range(0, 6).Select(_ => Atomo.Criar(Elemento.O)));

        return new Mol(atomos);
    }

    /// <summary>
    /// Cria uma molécula de ácido acético (CH₃COOH).
    /// </summary>
    public static Mol CriarAcidoAcetico()
    {
        var atomos = new List<Atomo>();

        atomos.AddRange(Enumerable.Range(0, 2).Select(_ => Atomo.Criar(Elemento.C)));
        atomos.AddRange(Enumerable.Range(0, 4).Select(_ => Atomo.Criar(Elemento.H)));
        atomos.AddRange(Enumerable.Range(0, 2).Select(_ => Atomo.Criar(Elemento.O)));

        return new Mol(atomos);
    }

    /// <summary>
    /// Cria uma molécula de ureia ((NH₂)₂CO).
    /// </summary>
    public static Mol CriarUreia()
    {
        var atomos = new List<Atomo>
        {
            Atomo.Criar(Elemento.C)
        };
        atomos.AddRange(Enumerable.Range(0, 4).Select(_ => Atomo.Criar(Elemento.H)));
        atomos.AddRange(Enumerable.Range(0, 2).Select(_ => Atomo.Criar(Elemento.N)));
        atomos.Add(Atomo.Criar(Elemento.O));

        return new Mol(atomos);
    }

    /// <summary>
    /// Cria uma molécula de ácido lático (C₃H₆O₃).
    /// </summary>
    public static Mol CriarAcidoLatico()
    {
        var atomos = new List<Atomo>();

        atomos.AddRange(Enumerable.Range(0, 3).Select(_ => Atomo.Criar(Elemento.C)));
        atomos.AddRange(Enumerable.Range(0, 6).Select(_ => Atomo.Criar(Elemento.H)));
        atomos.AddRange(Enumerable.Range(0, 3).Select(_ => Atomo.Criar(Elemento.O)));

        return new Mol(atomos);
    }

    /// <summary>
    /// Cria uma molécula de ácido carbônico (H₂CO₃).
    /// </summary>
    public static Mol CriarAcidoCarbonico()
    {
        return new Mol([
            Atomo.Criar(Elemento.H),
            Atomo.Criar(Elemento.H),
            Atomo.Criar(Elemento.C),
            Atomo.Criar(Elemento.O),
            Atomo.Criar(Elemento.O),
            Atomo.Criar(Elemento.O)
        ]);
    }

    /// <summary>
    /// Cria um modelo simplificado de sal de cozinha (NaCl).
    /// </summary>
    public static Mol CriarSal()
    {
        return new Mol([
            Atomo.Criar(Elemento.Na),
            Atomo.Criar(Elemento.Cl)
        ]);
    }

    /// <summary>
    /// Cria uma unidade base de dióxido de silício (SiO₂), presente em silicatos.
    /// </summary>
    public static Mol CriarDioxidoDeSilicio()
    {
        return new Mol([
            Atomo.Criar(Elemento.Si),
            Atomo.Criar(Elemento.O),
            Atomo.Criar(Elemento.O)
        ]);
    }

    /// <summary>
    /// Cria uma molécula de carbonato de cálcio (CaCO₃).
    /// </summary>
    public static Mol CriarCarbonatoDeCalcio()
    {
        return new Mol([
            Atomo.Criar(Elemento.Ca),
            Atomo.Criar(Elemento.C),
            Atomo.Criar(Elemento.O),
            Atomo.Criar(Elemento.O),
            Atomo.Criar(Elemento.O)
        ]);
    }
}
