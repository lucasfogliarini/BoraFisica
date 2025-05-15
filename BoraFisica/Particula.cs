namespace BoraOrganismos
{
    public record Particula(TipoParticula Tipo, double Carga, double Massa, double Spin) : IMassivo
    {
        public const double MASSA_PROTON = 0.9999; // Massa efetiva média do próton ligado (u)
        public const double MASSA_PROTON_LIVRE = 1.007276;  // Massa do próton livre (u)
        public const double CARGA_PROTON = +1.0;// Carga elétrica do próton (positiva)
        /// <summary>
        /// Cria um próton com massa efetiva ligada no núcleo atômico.
        /// </summary>
        public static Particula CriarProton() => new(TipoParticula.Proton, CARGA_PROTON, MASSA_PROTON, SPIN_MEIO);

        public const double MASSA_NEUTRON = 1; // Massa efetiva média do neutron ligado (u)
        public const double MASSA_NEUTRON_LIVRE = 1.008665;  // Massa do neutron livre (u)
        /// <summary>
        /// Cria um neutron com massa efetiva ligada no núcleo atômico.
        /// </summary>
        public static Particula CriarNeutron() => new(TipoParticula.Neutron, CARGA_NULA, MASSA_NEUTRON, SPIN_MEIO);

        public const double MASSA_ELETRON = 0.0005483;// Massa efetiva média do elétron ligado (u)
        public const double CARGA_ELETRON = -1.0;// Carga elétrica do elétron (negativa)
        /// <summary>
        /// Cria um elétron com massa efetiva ligada no núcleo atômico.
        /// </summary>
        public static Particula CriarEletron()=> new(TipoParticula.Eletron, CARGA_ELETRON, MASSA_ELETRON, SPIN_MEIO);

        public static Particula CriarFoton() => new(TipoParticula.Foton, MASSA_NULA, MASSA_NULA, SPIN_INTEIRO);
        public static Particula CriarGluon() => new(TipoParticula.Gluon, CARGA_NULA, MASSA_NULA, SPIN_INTEIRO);

        public const double MASSA_NULA = 0.0;// Massa do fóton (nula, pois ele não tem massa de repouso)
        public const double CARGA_NULA = 0.0;// Carga do fóton (neutra)
        public const double SPIN_MEIO = 0.5;// Spin dos férmions (próton, nêutron, elétron): 1/2        
        public const double SPIN_INTEIRO = 1.0;// Spin do bóson fóton: 1
    }

    public enum TipoParticula
    {
        //Férmions
        Proton,
        Neutron,
        Eletron,

        //Bósons
        Foton,//força eletromagnética
        Gluon//força nuclear forte
    }
}