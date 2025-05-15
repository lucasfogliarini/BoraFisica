namespace BoraOrganismos.Tests
{
    public class ParticulaTests
    {
        [Theory]
        [InlineData(TipoParticula.Proton, Particula.CARGA_PROTON, Particula.MASSA_PROTON, Particula.SPIN_MEIO)]
        [InlineData(TipoParticula.Eletron, Particula.CARGA_ELETRON, Particula.MASSA_ELETRON, Particula.SPIN_MEIO)]
        [InlineData(TipoParticula.Neutron, Particula.CARGA_NULA, Particula.MASSA_NEUTRON, Particula.SPIN_MEIO)]
        [InlineData(TipoParticula.Foton, Particula.CARGA_NULA, Particula.MASSA_NULA, Particula.SPIN_INTEIRO)]
        [InlineData(TipoParticula.Gluon, Particula.CARGA_NULA, Particula.MASSA_NULA, Particula.SPIN_INTEIRO)]
        public void CriarParticula(TipoParticula tipo, double carga, double massa, double spin)
        {
            var particula = new Particula(tipo, carga, massa, spin);

            Assert.Equal(tipo, particula.Tipo);
            Assert.Equal(carga, particula.Carga, 3);
            Assert.Equal(massa, particula.Massa, 3);
            Assert.Equal(spin, particula.Spin, 3);
        }
    }
}