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
        /// <summary>Hidrogênio</summary>
        H = 1,
        /// <summary>Hélio</summary>
        He = 2,
        /// <summary>Lítio</summary>
        Li = 3,
        /// <summary>Berílio</summary>
        Be = 4,
        /// <summary>Boro</summary>
        B = 5,
        /// <summary>Carbono</summary>
        C = 6,
        /// <summary>Nitrogênio</summary>
        N = 7,
        /// <summary>Oxigênio</summary>
        O = 8,
        /// <summary>Flúor</summary>
        F = 9,
        /// <summary>Neônio</summary>
        Ne = 10,
        /// <summary>Sódio</summary>
        Na = 11,
        /// <summary>Magnésio</summary>
        Mg = 12,
        /// <summary>Alumínio</summary>
        Al = 13,
        /// <summary>Silício</summary>
        Si = 14,
        /// <summary>Fósforo</summary>
        P = 15,
        /// <summary>Enxofre</summary>
        S = 16,
        /// <summary>Cloro</summary>
        Cl = 17,
        /// <summary>Argônio</summary>
        Ar = 18,
        /// <summary>Potássio</summary>
        K = 19,
        /// <summary>Cálcio</summary>
        Ca = 20,
        /// <summary>Escândio</summary>
        Sc = 21,
        /// <summary>Titânio</summary>
        Ti = 22,
        /// <summary>Vanádio</summary>
        V = 23,
        /// <summary>Cromo</summary>
        Cr = 24,
        /// <summary>Manganês</summary>
        Mn = 25,
        /// <summary>Ferro</summary>
        Fe = 26,
        /// <summary>Cobalto</summary>
        Co = 27,
        /// <summary>Níquel</summary>
        Ni = 28,
        /// <summary>Cobre</summary>
        Cu = 29,
        /// <summary>Zinco</summary>
        Zn = 30,
        /// <summary>Gálio</summary>
        Ga = 31,
        /// <summary>Germânio</summary>
        Ge = 32,
        /// <summary>Arsênio</summary>
        As = 33,
        /// <summary>Selênio</summary>
        Se = 34,
        /// <summary>Bromo</summary>
        Br = 35,
        /// <summary>Criptônio</summary>
        Kr = 36,
        /// <summary>Rubídio</summary>
        Rb = 37,
        /// <summary>Estrôncio</summary>
        Sr = 38,
        /// <summary>Ítrio</summary>
        Y = 39,
        /// <summary>Zircônio</summary>
        Zr = 40,
        /// <summary>Nióbio</summary>
        Nb = 41,
        /// <summary>Molibdênio</summary>
        Mo = 42,
        /// <summary>Tecnécio</summary>
        Tc = 43,
        /// <summary>Rutênio</summary>
        Ru = 44,
        /// <summary>Ródio</summary>
        Rh = 45,
        /// <summary>Paládio</summary>
        Pd = 46,
        /// <summary>Prata</summary>
        Ag = 47,
        /// <summary>Cádmio</summary>
        Cd = 48,
        /// <summary>Índio</summary>
        In = 49,
        /// <summary>Estanho</summary>
        Sn = 50,
        /// <summary>Antimônio</summary>
        Sb = 51,
        /// <summary>Telúrio</summary>
        Te = 52,
        /// <summary>Iodo</summary>
        I = 53,
        /// <summary>Xenônio</summary>
        Xe = 54,
        /// <summary>Césio</summary>
        Cs = 55,
        /// <summary>Bário</summary>
        Ba = 56,
        /// <summary>Lantânio</summary>
        La = 57,
        /// <summary>Cério</summary>
        Ce = 58,
        /// <summary>Praseodímio</summary>
        Pr = 59,
        /// <summary>Neodímio</summary>
        Nd = 60,
        /// <summary>Promécio</summary>
        Pm = 61,
        /// <summary>Samário</summary>
        Sm = 62,
        /// <summary>Európio</summary>
        Eu = 63,
        /// <summary>Gadolínio</summary>
        Gd = 64,
        /// <summary>Térbio</summary>
        Tb = 65,
        /// <summary>Disprósio</summary>
        Dy = 66,
        /// <summary>Hólmio</summary>
        Ho = 67,
        /// <summary>Érbio</summary>
        Er = 68,
        /// <summary>Túlio</summary>
        Tm = 69,
        /// <summary>Itérbio</summary>
        Yb = 70,
        /// <summary>Lutécio</summary>
        Lu = 71,
        /// <summary>Háfnio</summary>
        Hf = 72,
        /// <summary>Tântalo</summary>
        Ta = 73,
        /// <summary>Tungstênio</summary>
        W = 74,
        /// <summary>Rênio</summary>
        Re = 75,
        /// <summary>Ósmio</summary>
        Os = 76,
        /// <summary>Irídio</summary>
        Ir = 77,
        /// <summary>Platina</summary>
        Pt = 78,
        /// <summary>Ouro</summary>
        Au = 79,
        /// <summary>Mercúrio</summary>
        Hg = 80,
        /// <summary>Tálio</summary>
        Tl = 81,
        /// <summary>Chumbo</summary>
        Pb = 82,
        /// <summary>Bismuto</summary>
        Bi = 83,
        /// <summary>Polônio</summary>
        Po = 84,
        /// <summary>Ástato</summary>
        At = 85,
        /// <summary>Radônio</summary>
        Rn = 86,
        /// <summary>Frâncio</summary>
        Fr = 87,
        /// <summary>Rádio</summary>
        Ra = 88,
        /// <summary>Actínio</summary>
        Ac = 89,
        /// <summary>Tório</summary>
        Th = 90,
        /// <summary>Protactínio</summary>
        Pa = 91,
        /// <summary>Urânio</summary>
        U = 92,
        /// <summary>Netúnio</summary>
        Np = 93,
        /// <summary>Plutônio</summary>
        Pu = 94,
        /// <summary>Amerício</summary>
        Am = 95,
        /// <summary>Cúrio</summary>
        Cm = 96,
        /// <summary>Berquélio</summary>
        Bk = 97,
        /// <summary>Califórnio</summary>
        Cf = 98,
        /// <summary>Einsteinio</summary>
        Es = 99,
        /// <summary>Férmio</summary>
        Fm = 100,
        /// <summary>Mendelévio</summary>
        Md = 101,
        /// <summary>Nobélio</summary>
        No = 102,
        /// <summary>Laurêncio</summary>
        Lr = 103,
        /// <summary>Rutherfórdio</summary>
        Rf = 104,
        /// <summary>Dúbnio</summary>
        Db = 105,
        /// <summary>Seabórgio</summary>
        Sg = 106,
        /// <summary>Bóhrio</summary>
        Bh = 107,
        /// <summary>Hássio</summary>
        Hs = 108,
        /// <summary>Meitnério</summary>
        Mt = 109,
        /// <summary>Darmstádio</summary>
        Ds = 110,
        /// <summary>Roentgênio</summary>
        Rg = 111,
        /// <summary>Copernício</summary>
        Cn = 112,
        /// <summary>Nihônio</summary>
        Nh = 113,
        /// <summary>Fleróvio</summary>
        Fl = 114,
        /// <summary>Moscóvio</summary>
        Mc = 115,
        /// <summary>Livermório</summary>
        Lv = 116,
        /// <summary>Tenessino</summary>
        Ts = 117,
        /// <summary>Oganessônio</summary>
        Og = 118
    }

}