namespace BoraOrganismos
{
    /// <summary>
    /// Representa um conjunto arbitrário de átomos, como uma molécula, um elemento puro ou uma substância composta.
    /// </summary>
    public record SistemaAtomico(IReadOnlyList<Atomo> Atomos)
    {
        /// <summary>
        /// Nome gerado automaticamente com base na composição do sistema.
        /// </summary>
        public string Nome => string.Join("", ComposicaoPorElemento.Select(kvp => $"{kvp.Key}{(kvp.Value > 1 ? kvp.Value : "")}"));

        /// <summary>
        /// Massa total do sistema atômico (soma das massas de todos os átomos).
        /// </summary>
        public double MassaTotal => Atomos.Sum(atomo => atomo.Massa);

        /// <summary>
        /// Número total de átomos presentes no sistema.
        /// </summary>
        public int QuantidadeTotalDeAtomos => Atomos.Count;

        /// <summary>
        /// Dicionário com a contagem de cada elemento presente no sistema.
        /// </summary>
        public Dictionary<Elemento, int> ComposicaoPorElemento =>
            Atomos.GroupBy(a => a.Elemento)
                  .ToDictionary(g => g.Key, g => g.Count());

        /// <summary>
        /// Cria uma molécula de água (H₂O).
        /// </summary>
        public static SistemaAtomico CriarH2O()
        {
            var hidrogenio1 = Atomo.Criar(Elemento.H);
            var hidrogenio2 = Atomo.Criar(Elemento.H);
            var oxigenio = Atomo.Criar(Elemento.O);

            return new SistemaAtomico([hidrogenio1, hidrogenio2, oxigenio]);
        }

        /// <summary>
        /// Cria uma molécula de dióxido de carbono (CO₂).
        /// </summary>
        public static SistemaAtomico CriarCO2()
        {
            var carbono = Atomo.Criar(Elemento.C);
            var oxigenio1 = Atomo.Criar(Elemento.O);
            var oxigenio2 = Atomo.Criar(Elemento.O);

            return new SistemaAtomico([carbono, oxigenio1, oxigenio2]);
        }

        /// <summary>
        /// Cria uma molécula de oxigênio (O₂).
        /// </summary>
        public static SistemaAtomico CriarO2()
        {
            return new SistemaAtomico([
                Atomo.Criar(Elemento.O),
        Atomo.Criar(Elemento.O)
            ]);
        }

        /// <summary>
        /// Cria uma molécula de ozônio (O₃).
        /// </summary>
        public static SistemaAtomico CriarO3()
        {
            return new SistemaAtomico([
                Atomo.Criar(Elemento.O),
        Atomo.Criar(Elemento.O),
        Atomo.Criar(Elemento.O)
            ]);
        }

        /// <summary>
        /// Cria uma molécula de nitrogênio (N₂).
        /// </summary>
        public static SistemaAtomico CriarN2()
        {
            return new SistemaAtomico([
                Atomo.Criar(Elemento.N),
        Atomo.Criar(Elemento.N)
            ]);
        }

        /// <summary>
        /// Cria uma molécula de gás de hidrogênio (H₂).
        /// </summary>
        public static SistemaAtomico CriarH2()
        {
            var hidrogenio1 = Atomo.Criar(Elemento.H);
            var hidrogenio2 = Atomo.Criar(Elemento.H);

            return new SistemaAtomico([hidrogenio1, hidrogenio2]);
        }

        /// <summary>
        /// Cria uma molécula de amônia (NH₃).
        /// </summary>
        public static SistemaAtomico CriarAmonia()
        {
            return new SistemaAtomico([
                Atomo.Criar(Elemento.N),
        Atomo.Criar(Elemento.H),
        Atomo.Criar(Elemento.H),
        Atomo.Criar(Elemento.H)
            ]);
        }

        /// <summary>
        /// Cria uma molécula de metano (CH₄).
        /// </summary>
        public static SistemaAtomico CriarMetano()
        {
            return new SistemaAtomico([
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
        public static SistemaAtomico CriarGlicose()
        {
            var atomos = new List<Atomo>();

            atomos.AddRange(Enumerable.Range(0, 6).Select(_ => Atomo.Criar(Elemento.C)));
            atomos.AddRange(Enumerable.Range(0, 12).Select(_ => Atomo.Criar(Elemento.H)));
            atomos.AddRange(Enumerable.Range(0, 6).Select(_ => Atomo.Criar(Elemento.O)));

            return new SistemaAtomico(atomos);
        }

        /// <summary>
        /// Cria uma molécula de ácido acético (CH₃COOH).
        /// </summary>
        public static SistemaAtomico CriarAcidoAcetico()
        {
            var atomos = new List<Atomo>();

            atomos.AddRange(Enumerable.Range(0, 2).Select(_ => Atomo.Criar(Elemento.C)));
            atomos.AddRange(Enumerable.Range(0, 4).Select(_ => Atomo.Criar(Elemento.H)));
            atomos.AddRange(Enumerable.Range(0, 2).Select(_ => Atomo.Criar(Elemento.O)));

            return new SistemaAtomico(atomos);
        }

        /// <summary>
        /// Cria uma molécula de ureia ((NH₂)₂CO).
        /// </summary>
        public static SistemaAtomico CriarUreia()
        {
            var atomos = new List<Atomo>
            {
                Atomo.Criar(Elemento.C)
            };
            atomos.AddRange(Enumerable.Range(0, 4).Select(_ => Atomo.Criar(Elemento.H)));
            atomos.AddRange(Enumerable.Range(0, 2).Select(_ => Atomo.Criar(Elemento.N)));
            atomos.Add(Atomo.Criar(Elemento.O));

            return new SistemaAtomico(atomos);
        }

        /// <summary>
        /// Cria uma molécula de ácido lático (C₃H₆O₃).
        /// </summary>
        public static SistemaAtomico CriarAcidoLatico()
        {
            var atomos = new List<Atomo>();

            atomos.AddRange(Enumerable.Range(0, 3).Select(_ => Atomo.Criar(Elemento.C)));
            atomos.AddRange(Enumerable.Range(0, 6).Select(_ => Atomo.Criar(Elemento.H)));
            atomos.AddRange(Enumerable.Range(0, 3).Select(_ => Atomo.Criar(Elemento.O)));

            return new SistemaAtomico(atomos);
        }

        /// <summary>
        /// Cria uma molécula de ácido carbônico (H₂CO₃).
        /// </summary>
        public static SistemaAtomico CriarAcidoCarbonico()
        {
            return new SistemaAtomico([
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
        public static SistemaAtomico CriarSal()
        {
            return new SistemaAtomico([
                Atomo.Criar(Elemento.Na),
                Atomo.Criar(Elemento.Cl)
            ]);
        }

        /// <summary>
        /// Cria uma unidade base de dióxido de silício (SiO₂), presente em silicatos.
        /// </summary>
        public static SistemaAtomico CriarDioxidoDeSilicio()
        {
            return new SistemaAtomico([
                Atomo.Criar(Elemento.Si),
                Atomo.Criar(Elemento.O),
                Atomo.Criar(Elemento.O)
            ]);
        }

        /// <summary>
        /// Cria uma molécula de carbonato de cálcio (CaCO₃).
        /// </summary>
        public static SistemaAtomico CriarCarbonatoDeCalcio()
        {
            return new SistemaAtomico([
                Atomo.Criar(Elemento.Ca),
                Atomo.Criar(Elemento.C),
                Atomo.Criar(Elemento.O),
                Atomo.Criar(Elemento.O),
                Atomo.Criar(Elemento.O)
            ]);
        }
    }
}
