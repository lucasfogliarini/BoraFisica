namespace BoraOrganismos
{
    public record Particula(TipoParticula Tipo, double Carga, double Massa, double Spin) : IMassivo
    {
        public const double MASSA_PROTON = 0.9999; // Massa efetiva m�dia do pr�ton ligado (u)
        public const double MASSA_PROTON_LIVRE = 1.007276;  // Massa do pr�ton livre (u)
        public const double CARGA_PROTON = +1.0;// Carga el�trica do pr�ton (positiva)
        /// <summary>
        /// Cria um pr�ton com massa efetiva ligada no n�cleo at�mico.
        /// </summary>
        public static Particula CriarProton() => new(TipoParticula.Proton, CARGA_PROTON, MASSA_PROTON, SPIN_MEIO);

        public const double MASSA_NEUTRON = 1; // Massa efetiva m�dia do neutron ligado (u)
        public const double MASSA_NEUTRON_LIVRE = 1.008665;  // Massa do neutron livre (u)
        /// <summary>
        /// Cria um neutron com massa efetiva ligada no n�cleo at�mico.
        /// </summary>
        public static Particula CriarNeutron() => new(TipoParticula.Neutron, CARGA_NULA, MASSA_NEUTRON, SPIN_MEIO);

        public const double MASSA_ELETRON = 0.0005483;// Massa efetiva m�dia do el�tron ligado (u)
        public const double CARGA_ELETRON = -1.0;// Carga el�trica do el�tron (negativa)
        /// <summary>
        /// Cria um el�tron com massa efetiva ligada no n�cleo at�mico.
        /// </summary>
        public static Particula CriarEletron()=> new(TipoParticula.Eletron, CARGA_ELETRON, MASSA_ELETRON, SPIN_MEIO);

        public static Particula CriarFoton() => new(TipoParticula.Foton, MASSA_NULA, MASSA_NULA, SPIN_INTEIRO);
        public static Particula CriarGluon() => new(TipoParticula.Gluon, CARGA_NULA, MASSA_NULA, SPIN_INTEIRO);

        public const double MASSA_NULA = 0.0;// Massa do f�ton (nula, pois ele n�o tem massa de repouso)
        public const double CARGA_NULA = 0.0;// Carga do f�ton (neutra)
        public const double SPIN_MEIO = 0.5;// Spin dos f�rmions (pr�ton, n�utron, el�tron): 1/2        
        public const double SPIN_INTEIRO = 1.0;// Spin do b�son f�ton: 1
    }

    public enum TipoParticula
    {
        //F�rmions
        Proton,
        Neutron,
        Eletron,

        //B�sons
        Foton,//for�a eletromagn�tica
        Gluon//for�a nuclear forte
    }
}