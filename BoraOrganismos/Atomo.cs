namespace BoraOrganismos
{
    public record Atomo(Elemento Elemento, IReadOnlyList<Particula> Nucleons, IReadOnlyList<Particula> Eletrons)
    {
        /// <summary>
        /// Massa total do átomo, considerando os nêutrons e prótons (nucleons).
        /// </summary>
        public double Massa { get { return Nucleons.Sum(e => e.Massa); } }

        /// <summary>
        /// Número atômico do elemento químico.
        /// </summary>
        public int NumeroAtomico => Nucleons.Count(p => p.Tipo == TipoParticula.Proton);

        public static Atomo Criar(Elemento elemento)
        {
            int numeroAtomico = (int)elemento;

            List<Particula> nucleons = [];
            List<Particula> eletrons = [];
            for (int i = 0; i < numeroAtomico; i++)
            {
                nucleons.Add(Particula.CriarProton());
                nucleons.Add(Particula.CriarNeutron());
            }

            // Adiciona elétrons (átomo neutro)
            for (int i = 0; i < numeroAtomico; i++)
            {
                eletrons.Add(Particula.CriarEletron());
            }

            return new Atomo(elemento, nucleons, eletrons);
        }
    }

    public enum Elemento
    {
        Hidrogenio = 1,
        Helio = 2,
        Litio = 3,
        Berilio = 4,
        Boro = 5,
        Carbono = 6,
        Nitrogenio = 7,
        Oxigenio = 8,
        Fluor = 9,
        Neon = 10,
        Sodio = 11,
        Magnesio = 12,
        Aluminio = 13,
        Silicio = 14,
        Fosforo = 15,
        Enxofre = 16,
        Cloro = 17,
        Argonio = 18,
        Potassio = 19,
        Calcio = 20,
        Escandio = 21,
        Titanio = 22,
        Vanadio = 23,
        Cromo = 24,
        Manganes = 25,
        Ferro = 26,
        Cobalto = 27,
        Niquel = 28,
        Cobre = 29,
        Zinco = 30,
        Galio = 31,
        Germanio = 32,
        Arsenio = 33,
        Selenio = 34,
        Bromo = 35,
        Kriptonio = 36,
        Rubidio = 37,
        Estroncio = 38,
        Itrio = 39,
        Zircônio = 40,
        NioBio = 41,
        Molibdenio = 42,
        Tecnecio = 43,
        Rutenio = 44,
        Rodio = 45,
        Paladio = 46,
        Prata = 47,
        Cadmio = 48,
        Indio = 49,
        Estanho = 50,
        Antimonio = 51,
        Telurio = 52,
        Iodo = 53,
        Xenonio = 54,
        Cesio = 55,
        Bario = 56,
        Lantanio = 57,
        Cerio = 58,
        Praseodimio = 59,
        Neodimio = 60,
        Promecio = 61,
        Samario = 62,
        Europio = 63,
        Gadolinio = 64,
        Terbio = 65,
        Disprosio = 66,
        Holmio = 67,
        Erbio = 68,
        Tulio = 69,
        Iterbio = 70,
        Lutecio = 71,
        Hafnio = 72,
        Tantalo = 73,
        Tungstenio = 74,
        Renio = 75,
        Osmio = 76,
        Iridio = 77,
        Platina = 78,
        Ouro = 79,
        Mercurio = 80,
        Talio = 81,
        Chumbo = 82,
        Bismuto = 83,
        Polonio = 84,
        Astato = 85,
        Radonio = 86,
        Francio = 87,
        Radio = 88,
        Actinio = 89,
        Torio = 90,
        Proctinio = 91,
        Uranio = 92,
        Netunio = 93,
        Plutonio = 94,
        Americio = 95,
        Cúrio = 96,
        Berquélio = 97,
        Californio = 98,
        Einstênio = 99,
        Fermio = 100,
        Mendelévio = 101,
        Nobelio = 102,
        Laurencio = 103,
        Rutherforcio = 104,
        Dubnio = 105,
        Seaborgio = 106,
        Bohrio = 107,
        Hássio = 108,
        Meitnerio = 109,
        Darmstadio = 110,
        Roentgenio = 111,
        Copernicio = 112,
        Nihonio = 113,
        Flerovio = 114,
        Moscovio = 115,
        Livermorio = 116,
        Tenessino = 117,
        Oganesson = 118
    }
}