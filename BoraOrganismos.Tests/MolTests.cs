namespace BoraOrganismos.Tests
{
    public class MolTests
    {
        [Theory]
        //[InlineData(Elemento.H, 1.007)]
        [InlineData(Elemento.O, 15.999)]
        [InlineData(Elemento.Au, 196.98)]
        public void CriarElemento_DeveRetornarMoleculaCorreta(
                Elemento elemento,
                double massaAtomicaEsperada)
        {
            // Arrange
            var mol = MolFactory.Criar(elemento);

            double quantidadeEmMolsEsperado = mol.QuantidadeTotalDeAtomos / Mol.Avogadro;
            double massaEmGramasEsperado = mol.MassaAtomica * Mol.UnidadeMassaAtomicaEmGramas;

            // Assert
            Assert.Equal(massaAtomicaEsperada, mol.MassaAtomica, precision: 2);
            Assert.Equal(massaEmGramasEsperado, mol.MassaEmGramas, precision: 5);
            Assert.Equal(quantidadeEmMolsEsperado, mol.QuantidadeEmMols, precision: 6);
        }

        [Fact]
        public void CriarH2O_DeveRetornarMoleculaDeAguaCorreta()
        {
            // Arrange
            var h2o = MolFactory.CriarH2O();
            double massaEsperadaEmU = h2o.MassaAtomica;
            double massaEsperadaEmGramas = massaEsperadaEmU * Mol.UnidadeMassaAtomicaEmGramas;
            double quantidadeEsperadaDeMol = h2o.QuantidadeTotalDeAtomos / Mol.Avogadro;

            // Assert
            Assert.Equal(3, h2o.QuantidadeTotalDeAtomos);
            Assert.Equal(massaEsperadaEmU, h2o.MassaAtomica, precision: 2);
            Assert.Equal(massaEsperadaEmGramas, h2o.MassaEmGramas, precision: 5);
            Assert.Equal(quantidadeEsperadaDeMol, h2o.QuantidadeEmMols, precision: 6);
        }


        [Fact]
        public void CriarCO2_DeveRetornarMoleculaDeDioxidoDeCarbonoCorreta()
        {
            // Act
            var co2 = MolFactory.CriarCO2();

            // Assert
            Assert.Equal(3, co2.QuantidadeTotalDeAtomos);

            Assert.Equal(1, co2.ComposicaoPorElemento[Elemento.C]);
            Assert.Equal(2, co2.ComposicaoPorElemento[Elemento.O]);

            Assert.Equal("CO2", co2.Nome);

            Assert.True(co2.MassaAtomica > 0);
        }

    }
}
