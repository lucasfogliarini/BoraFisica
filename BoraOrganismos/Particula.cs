namespace BoraOrganismos
{
    public record Particula(TipoParticula Tipo, double Carga, double Massa, double Spin)
    {
        public const double MASSA_PROTON = 1.007;// Massa aproximada do próton em unidades de massa atômica (u)
        public const double CARGA_PROTON = +1.0;// Carga elétrica do próton (positiva)
        public static Particula CriarProton() => new(TipoParticula.Proton, CARGA_PROTON, MASSA_PROTON, SPIN_MEIO);

        public const double MASSA_NEUTRON = 1.009;// Massa aproximada do nêutron em unidades de massa atômica (u)
        public static Particula CriarNeutron() => new(TipoParticula.Neutron, CARGA_NULA, MASSA_NEUTRON, SPIN_MEIO);

        public const double MASSA_ELETRON = 0.0005;// Massa aproximada do elétron em unidades de massa atômica (u)
        public const double CARGA_ELETRON = -1.0;// Carga elétrica do elétron (negativa)
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