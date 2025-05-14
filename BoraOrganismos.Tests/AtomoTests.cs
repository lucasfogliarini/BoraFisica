namespace BoraOrganismos.Tests
{
    public class AtomoTests
    {
        [Theory]
        [InlineData(1, 0, 1)]// Hidrogênio |  H¹     | Átomo neutro
        [InlineData(1, 1, 1)]// Deutério   | ²H ou D | Isótopo do hidrogênio
        [InlineData(1, 2, 1)]// Trítio     | ³H ou T | Radioativo, também H isótopo
        public void CriarHidrogenio(int protonsEsperados, int neutronsEsperados, int eletronsEsperados)
        {
            // Act
            var atomoFundido = Atomo.Criar(Elemento.H, neutronsEsperados);

            // Assert
            Assert.Equal(Elemento.H, atomoFundido.Elemento);
            Assert.Equal(protonsEsperados, atomoFundido.Nucleons.Count(p => p.Tipo == TipoParticula.Proton));
            Assert.Equal(neutronsEsperados, atomoFundido.Nucleons.Count(p => p.Tipo == TipoParticula.Neutron));
            Assert.Equal(eletronsEsperados, atomoFundido.Eletrons.Count);
        }

        [Theory]
        [InlineData(Elemento.H, Elemento.H, Elemento.He)] // H¹ + H¹ → He²
        [InlineData(Elemento.He, Elemento.H, Elemento.Li)] // He² + H¹ → Li³
        [InlineData(Elemento.He, Elemento.He, Elemento.Be)] // He² + He² → Be⁴
        [InlineData(Elemento.Li, Elemento.He, Elemento.B)] // Li³ + He² → B⁵
        [InlineData(Elemento.H, Elemento.B, Elemento.C)]    // H¹ + B⁵ → C⁶
        [InlineData(Elemento.He, Elemento.Be, Elemento.C)]  // He² + Be⁴ → C⁶
        [InlineData(Elemento.Li, Elemento.Li, Elemento.C)]  // Li³ + Li³ → C⁶
        [InlineData(Elemento.B, Elemento.He, Elemento.N)] // B⁵ + He² → N⁷
        [InlineData(Elemento.Be, Elemento.Be, Elemento.O)] // Be⁴ + Be⁴ → O⁸
        [InlineData(Elemento.B, Elemento.Li, Elemento.O)] // B⁵ + Li³ → O⁸
        [InlineData(Elemento.C, Elemento.He, Elemento.O)] // C⁶ + He² → O⁸
        [InlineData(Elemento.N, Elemento.H, Elemento.O)]  // N⁷ + H¹ → O⁸
        [InlineData(Elemento.Li, Elemento.B, Elemento.O)] // Li³ + B⁵ → O⁸
        [InlineData(Elemento.N, Elemento.He, Elemento.F)] // N⁷ + He² → F⁹
        [InlineData(Elemento.O, Elemento.He, Elemento.Ne)] // O⁸ + He² → Ne¹⁰
        [InlineData(Elemento.Ne, Elemento.H, Elemento.Na)] // Ne¹⁰ + H¹ → Na¹¹
        [InlineData(Elemento.C, Elemento.C, Elemento.Mg)] // C⁶ + C⁶ → Mg¹²
        public void Fundir_DoisTiposDeAtomos(Elemento elementoAtomo1, Elemento elementoAtomo2, Elemento elementoAtomoFundido)
        {
            // Arrange
            var atomo1 = Atomo.Criar(elementoAtomo1);
            var atomo2 = Atomo.Criar(elementoAtomo2);
            var atomoFundidoEsperado = Atomo.Criar(elementoAtomoFundido);

            //Act
            var atomoFundido = Atomo.Fundir(atomo1, atomo2);

            // Assert
            Assert.Equal(atomoFundidoEsperado.NumeroAtomico, atomoFundido.NumeroAtomico);
            Assert.Equal(atomoFundidoEsperado.Elemento, atomoFundido.Elemento);
            Assert.Equal(atomoFundidoEsperado.Eletrons, atomoFundido.Eletrons);
            Assert.Equal(atomoFundidoEsperado.Massa, atomoFundido.Massa, precision: 5);
            Assert.Equal(atomoFundidoEsperado.NumeroDeNeutrons, atomoFundido.NumeroDeNeutrons);
        }
    }
}
