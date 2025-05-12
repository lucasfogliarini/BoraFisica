namespace BoraOrganismos.Tests
{
    public class SistemaAtomicoTests
    {
        [Fact]
        public void CriarH2O_DeveRetornarMoleculaDeAguaCorreta()
        {
            // Act
            var agua = SistemaAtomico.CriarH2O();

            // Assert
            Assert.Equal(3, agua.QuantidadeTotalDeAtomos);

            Assert.Equal(2, agua.ComposicaoPorElemento[Elemento.H]);
            Assert.Equal(1, agua.ComposicaoPorElemento[Elemento.O]);

            Assert.Equal("H2O", agua.Nome); // Nome baseado no enum

            Assert.True(agua.MassaTotal > 0); // Massa deve ser positiva
        }

        [Fact]
        public void CriarCO2_DeveRetornarMoleculaDeDioxidoDeCarbonoCorreta()
        {
            // Act
            var co2 = SistemaAtomico.CriarCO2();

            // Assert
            Assert.Equal(3, co2.QuantidadeTotalDeAtomos);

            Assert.Equal(1, co2.ComposicaoPorElemento[Elemento.C]);
            Assert.Equal(2, co2.ComposicaoPorElemento[Elemento.O]);

            Assert.Equal("CO2", co2.Nome);

            Assert.True(co2.MassaTotal > 0);
        }

        [Fact]
        public void CriarUreia_DeveRetornarMoleculaDeUreiaCorreta()
        {
            // Act
            var ureia = SistemaAtomico.CriarUreia();

            // Assert
            Assert.Equal(8, ureia.QuantidadeTotalDeAtomos);

            Assert.Equal(1, ureia.ComposicaoPorElemento[Elemento.C]);
            Assert.Equal(4, ureia.ComposicaoPorElemento[Elemento.H]);
            Assert.Equal(2, ureia.ComposicaoPorElemento[Elemento.N]);
            Assert.Equal(1, ureia.ComposicaoPorElemento[Elemento.O]);

            Assert.Equal("CH4N2O", ureia.Nome);
            Assert.True(ureia.MassaTotal > 0);
        }

    }
}
