namespace BoraOrganismos.Tests
{
    public class MolTests
    {
        [Theory]
        [InlineData(Elemento.H, 1.00)]
        [InlineData(Elemento.He, 4.00)]
        [InlineData(Elemento.Li, 7.00)]
        [InlineData(Elemento.Be, 9.00)]
        [InlineData(Elemento.B, 11.00)]
        [InlineData(Elemento.C, 12.000)]
        [InlineData(Elemento.N, 14.00)]
        [InlineData(Elemento.O, 15.999)]
        [InlineData(Elemento.Au, 197.04)]
        public void CriarElemento_DeveRetornarMoleculaCorreta(Elemento elemento, double massaAtomicaEsperada)
        {
            // Arrange
            var mol = MolFactory.Criar(elemento);

            double quantidadeEmMolsEsperado = mol.QuantidadeDeAtomos / Mol.Avogadro;
            double massaEmGramasEsperado = mol.Massa * Mol.UnidadeMassaAtomicaEmGramas;

            // Assert
            Assert.Equal(massaAtomicaEsperada, mol.Massa, precision: 2);
            Assert.Equal(massaEmGramasEsperado, mol.MassaEmGramas, precision: 5);
            Assert.Equal(quantidadeEmMolsEsperado, mol.QuantidadeEmMols, precision: 6);
        }

        [Fact]
        public void CriarH2O_DeveRetornarMoleculaDeAguaCorreta()
        {
            // Arrange
            var h2o = MolFactory.CriarH2O();
            double massaEsperadaEmU = h2o.Massa;
            double massaEsperadaEmGramas = massaEsperadaEmU * Mol.UnidadeMassaAtomicaEmGramas;
            double quantidadeEsperadaDeMol = h2o.QuantidadeDeAtomos / Mol.Avogadro;

            // Assert
            Assert.Equal(3, h2o.QuantidadeDeAtomos);
            Assert.Equal(massaEsperadaEmU, h2o.Massa, precision: 2);
            Assert.Equal(massaEsperadaEmGramas, h2o.MassaEmGramas, precision: 5);
            Assert.Equal(quantidadeEsperadaDeMol, h2o.QuantidadeEmMols, precision: 6);
        }


        [Fact]
        public void CriarCO2_DeveRetornarMoleculaDeDioxidoDeCarbonoCorreta()
        {
            // Act
            var co2 = MolFactory.CriarCO2();

            // Assert
            Assert.Equal(3, co2.QuantidadeDeAtomos);

            Assert.Equal(1, co2.ComposicaoPorElemento[Elemento.C]);
            Assert.Equal(2, co2.ComposicaoPorElemento[Elemento.O]);

            Assert.Equal("CO2", co2.Nome);

            Assert.True(co2.Massa > 0);
        }

    }
}
