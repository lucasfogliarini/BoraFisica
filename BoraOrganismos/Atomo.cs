namespace BoraOrganismos
{
    public record Atomo(Elemento Elemento, IReadOnlyList<Particula> Nucleons, IReadOnlyList<Particula> Eletrons)
    {
        /// <summary>
        /// Massa total do �tomo, considerando os n�utrons e pr�tons (nucleons).
        /// </summary>
        public double Massa { get { return Nucleons.Sum(e => e.Massa); } }

        /// <summary>
        /// N�mero at�mico do elemento qu�mico.
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

            // Adiciona el�trons (�tomo neutro)
            for (int i = 0; i < numeroAtomico; i++)
            {
                eletrons.Add(Particula.CriarEletron());
            }

            return new Atomo(elemento, nucleons, eletrons);
        }
    }

    public enum Elemento
    {
        /// <summary>Hidrog�nio</summary>
        H = 1,
        /// <summary>H�lio</summary>
        He = 2,
        /// <summary>L�tio</summary>
        Li = 3,
        /// <summary>Ber�lio</summary>
        Be = 4,
        /// <summary>Boro</summary>
        B = 5,
        /// <summary>Carbono</summary>
        C = 6,
        /// <summary>Nitrog�nio</summary>
        N = 7,
        /// <summary>Oxig�nio</summary>
        O = 8,
        /// <summary>Fl�or</summary>
        F = 9,
        /// <summary>Ne�nio</summary>
        Ne = 10,
        /// <summary>S�dio</summary>
        Na = 11,
        /// <summary>Magn�sio</summary>
        Mg = 12,
        /// <summary>Alum�nio</summary>
        Al = 13,
        /// <summary>Sil�cio</summary>
        Si = 14,
        /// <summary>F�sforo</summary>
        P = 15,
        /// <summary>Enxofre</summary>
        S = 16,
        /// <summary>Cloro</summary>
        Cl = 17,
        /// <summary>Arg�nio</summary>
        Ar = 18,
        /// <summary>Pot�ssio</summary>
        K = 19,
        /// <summary>C�lcio</summary>
        Ca = 20,
        /// <summary>Esc�ndio</summary>
        Sc = 21,
        /// <summary>Tit�nio</summary>
        Ti = 22,
        /// <summary>Van�dio</summary>
        V = 23,
        /// <summary>Cromo</summary>
        Cr = 24,
        /// <summary>Mangan�s</summary>
        Mn = 25,
        /// <summary>Ferro</summary>
        Fe = 26,
        /// <summary>Cobalto</summary>
        Co = 27,
        /// <summary>N�quel</summary>
        Ni = 28,
        /// <summary>Cobre</summary>
        Cu = 29,
        /// <summary>Zinco</summary>
        Zn = 30,
        /// <summary>G�lio</summary>
        Ga = 31,
        /// <summary>Germ�nio</summary>
        Ge = 32,
        /// <summary>Ars�nio</summary>
        As = 33,
        /// <summary>Sel�nio</summary>
        Se = 34,
        /// <summary>Bromo</summary>
        Br = 35,
        /// <summary>Cript�nio</summary>
        Kr = 36,
        /// <summary>Rub�dio</summary>
        Rb = 37,
        /// <summary>Estr�ncio</summary>
        Sr = 38,
        /// <summary>�trio</summary>
        Y = 39,
        /// <summary>Zirc�nio</summary>
        Zr = 40,
        /// <summary>Ni�bio</summary>
        Nb = 41,
        /// <summary>Molibd�nio</summary>
        Mo = 42,
        /// <summary>Tecn�cio</summary>
        Tc = 43,
        /// <summary>Rut�nio</summary>
        Ru = 44,
        /// <summary>R�dio</summary>
        Rh = 45,
        /// <summary>Pal�dio</summary>
        Pd = 46,
        /// <summary>Prata</summary>
        Ag = 47,
        /// <summary>C�dmio</summary>
        Cd = 48,
        /// <summary>�ndio</summary>
        In = 49,
        /// <summary>Estanho</summary>
        Sn = 50,
        /// <summary>Antim�nio</summary>
        Sb = 51,
        /// <summary>Tel�rio</summary>
        Te = 52,
        /// <summary>Iodo</summary>
        I = 53,
        /// <summary>Xen�nio</summary>
        Xe = 54,
        /// <summary>C�sio</summary>
        Cs = 55,
        /// <summary>B�rio</summary>
        Ba = 56,
        /// <summary>Lant�nio</summary>
        La = 57,
        /// <summary>C�rio</summary>
        Ce = 58,
        /// <summary>Praseod�mio</summary>
        Pr = 59,
        /// <summary>Neod�mio</summary>
        Nd = 60,
        /// <summary>Prom�cio</summary>
        Pm = 61,
        /// <summary>Sam�rio</summary>
        Sm = 62,
        /// <summary>Eur�pio</summary>
        Eu = 63,
        /// <summary>Gadol�nio</summary>
        Gd = 64,
        /// <summary>T�rbio</summary>
        Tb = 65,
        /// <summary>Dispr�sio</summary>
        Dy = 66,
        /// <summary>H�lmio</summary>
        Ho = 67,
        /// <summary>�rbio</summary>
        Er = 68,
        /// <summary>T�lio</summary>
        Tm = 69,
        /// <summary>It�rbio</summary>
        Yb = 70,
        /// <summary>Lut�cio</summary>
        Lu = 71,
        /// <summary>H�fnio</summary>
        Hf = 72,
        /// <summary>T�ntalo</summary>
        Ta = 73,
        /// <summary>Tungst�nio</summary>
        W = 74,
        /// <summary>R�nio</summary>
        Re = 75,
        /// <summary>�smio</summary>
        Os = 76,
        /// <summary>Ir�dio</summary>
        Ir = 77,
        /// <summary>Platina</summary>
        Pt = 78,
        /// <summary>Ouro</summary>
        Au = 79,
        /// <summary>Merc�rio</summary>
        Hg = 80,
        /// <summary>T�lio</summary>
        Tl = 81,
        /// <summary>Chumbo</summary>
        Pb = 82,
        /// <summary>Bismuto</summary>
        Bi = 83,
        /// <summary>Pol�nio</summary>
        Po = 84,
        /// <summary>�stato</summary>
        At = 85,
        /// <summary>Rad�nio</summary>
        Rn = 86,
        /// <summary>Fr�ncio</summary>
        Fr = 87,
        /// <summary>R�dio</summary>
        Ra = 88,
        /// <summary>Act�nio</summary>
        Ac = 89,
        /// <summary>T�rio</summary>
        Th = 90,
        /// <summary>Protact�nio</summary>
        Pa = 91,
        /// <summary>Ur�nio</summary>
        U = 92,
        /// <summary>Net�nio</summary>
        Np = 93,
        /// <summary>Plut�nio</summary>
        Pu = 94,
        /// <summary>Amer�cio</summary>
        Am = 95,
        /// <summary>C�rio</summary>
        Cm = 96,
        /// <summary>Berqu�lio</summary>
        Bk = 97,
        /// <summary>Calif�rnio</summary>
        Cf = 98,
        /// <summary>Einsteinio</summary>
        Es = 99,
        /// <summary>F�rmio</summary>
        Fm = 100,
        /// <summary>Mendel�vio</summary>
        Md = 101,
        /// <summary>Nob�lio</summary>
        No = 102,
        /// <summary>Laur�ncio</summary>
        Lr = 103,
        /// <summary>Rutherf�rdio</summary>
        Rf = 104,
        /// <summary>D�bnio</summary>
        Db = 105,
        /// <summary>Seab�rgio</summary>
        Sg = 106,
        /// <summary>B�hrio</summary>
        Bh = 107,
        /// <summary>H�ssio</summary>
        Hs = 108,
        /// <summary>Meitn�rio</summary>
        Mt = 109,
        /// <summary>Darmst�dio</summary>
        Ds = 110,
        /// <summary>Roentg�nio</summary>
        Rg = 111,
        /// <summary>Copern�cio</summary>
        Cn = 112,
        /// <summary>Nih�nio</summary>
        Nh = 113,
        /// <summary>Fler�vio</summary>
        Fl = 114,
        /// <summary>Mosc�vio</summary>
        Mc = 115,
        /// <summary>Liverm�rio</summary>
        Lv = 116,
        /// <summary>Tenessino</summary>
        Ts = 117,
        /// <summary>Oganess�nio</summary>
        Og = 118
    }

}