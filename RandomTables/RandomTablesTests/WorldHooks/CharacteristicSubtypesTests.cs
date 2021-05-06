using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTables.TestHelpers;
using RandomTables.WorldHooks.Subtypes;

namespace RandomTablesTests.WorldHooks
{
    [TestClass]
    public class CharacteristicSubtypesTests
    {
        private const int d8Returns2 = 1;
        private const int d8Returns3 = 3;
        private const int d8Returns5 = 13;
        private const int d8Returns6 = 0;

        private const int d6Returns1 = 14;

        private const int d12Returns12 = 10;

        [TestMethod]
        public void ReturnsForestWhenRolled()
        {
            var d8Seed = d8Returns5;
            var d6Seed = d6Returns1;

            var seeds = new[] { d8Seed, d6Seed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var climateOrLandformSubtype = new ClimateOrLandformSubtype(mockSeedGenerator.Object);
            var subtype = climateOrLandformSubtype.GetCharacteristicSubtype();

            var expectedSubtype = "Forest";
            Assert.AreEqual(expectedSubtype, subtype);
        }

        [TestMethod]
        public void ReturnsRuinsWhenRolled()
        {
            var d8Seed = d8Returns6;

            var seeds = new[] { d8Seed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var sitesOfInterestSubtype = new SitesOfInterestSubtype(mockSeedGenerator.Object);
            var subtype = sitesOfInterestSubtype.GetCharacteristicSubtype();

            var expectedSubtype = "Ruins";
            Assert.AreEqual(expectedSubtype, subtype);
        }

        [TestMethod]
        public void ReturnsSeafaringWhenRolled()
        {
            var d12Seed = d12Returns12;

            var seeds = new[] { d12Seed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var cultureSubtype = new CulturesSubtype(mockSeedGenerator.Object);
            var subtype = cultureSubtype.GetCharacteristicSubtype();

            var expectedSubtype = "Seafaring";
            Assert.AreEqual(expectedSubtype, subtype);
        }

        [TestMethod]
        public void ReturnsPsionicsWhenRolled()
        {
            var d8Seed = d8Returns3;
            var d6Seed = d8Returns5;

            var seeds = new[] { d8Seed, d6Seed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var situationsSubtype = new SituationsSubtype(mockSeedGenerator.Object);
            var subtype = situationsSubtype.GetCharacteristicSubtype();

            var expectedSubtype = "Psionics";
            Assert.AreEqual(expectedSubtype, subtype);
        }

        [TestMethod]
        public void ReturnsArtifactWhenRolled()
        {
            var d8Seed = d8Returns2;

            var seeds = new[] { d8Seed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var historicalSubtype = new HistoricalSubtype(mockSeedGenerator.Object);
            var subtype = historicalSubtype.GetCharacteristicSubtype();

            var expectedSubtype = "Artifact";
            Assert.AreEqual(expectedSubtype, subtype);
        }
    }
}
