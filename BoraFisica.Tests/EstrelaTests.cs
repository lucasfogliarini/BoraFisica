namespace BoraOrganismos.Tests
{
    public class EstrelaTests
    {
        [Fact]
        public void FundirCadeiaPP_DeveGerarHe4EConservarParticulas()
        {
            // Arrange
            var estrela = new Estrela(30);//cuidado com esse número, pois cria duas listas de protons e elétrons
            double estrelaMassaInicial = estrela.Massa;
            int protonsIniciais = estrela.ProtonsLivres.Count;
            int eletronsIniciais = estrela.EletronsLivres.Count;

            // Act
            estrela.FundirCadeiaPP();

            // Assert: Produziu pelo menos um He⁴
            Assert.True(estrela.HeliosFormados.Count > 0, "A fusão nuclear não produziu He⁴.");

            // Assert: Todos os átomos formados são He⁴ com 4 nucleons
            Assert.All(estrela.HeliosFormados, he =>
            {
                Assert.Equal(Elemento.He, he.Elemento);
                Assert.Equal(4, he.Nucleons.Count);
                Assert.Equal(2, he.NumeroAtomico);
                Assert.Equal(2, he.NumeroDeNeutrons);
            });
            var nucleonsHe4 = estrela.HeliosFormados.Sum(he => he.Nucleons.Count);
            var protonsFinais = estrela.ProtonsLivres.Count + nucleonsHe4;
            Assert.Equal(protonsIniciais, protonsFinais);
            
            var eletronsHe4 = estrela.HeliosFormados.Sum(he => he.Eletrons.Count);
            var eletronsFinais = estrela.EletronsLivres.Count + eletronsHe4;
            Assert.Equal(eletronsIniciais, eletronsFinais);

            Assert.Equal(estrelaMassaInicial, estrela.Massa, precision: 2);//Lei de conservação de massa (Lavoisier)
        }
    }
}
