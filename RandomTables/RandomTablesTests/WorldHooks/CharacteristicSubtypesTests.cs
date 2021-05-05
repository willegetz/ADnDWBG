using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTables.TestHelpers;
using RandomTables.WorldHooks.Types;

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

            var climateOrLandform = new ClimateOrLandform(mockSeedGenerator.Object);
            var subtype = climateOrLandform.Subtype;

            var expectedSubtype = "Forest";
            Assert.AreEqual(expectedSubtype, subtype);
        }

        [TestMethod]
        public void ReturnsRuinsWhenRolled()
        {
            var d8Seed = d8Returns6;

            var seeds = new[] { d8Seed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var sitesOfInterest = new SitesOfInterest(mockSeedGenerator.Object);
            var subtype = sitesOfInterest.Subtype;

            var expectedSubtype = "Ruins";
            Assert.AreEqual(expectedSubtype, subtype);
        }

        [TestMethod]
        public void ReturnsSeafaringWhenRolled()
        {
            var d12Seed = d12Returns12;

            var seeds = new[] { d12Seed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var cultures = new Cultures(mockSeedGenerator.Object);
            var subtype = cultures.Subtype;

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

            var situations = new Situations(mockSeedGenerator.Object);
            var subtype = situations.Subtype;

            var expectedSubtype = "Psionics";
            Assert.AreEqual(expectedSubtype, subtype);
        }

        [TestMethod]
        public void ReturnsArtifactWhenRolled()
        {
            var d8Seed = d8Returns2;

            var seeds = new[] { d8Seed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var historical = new Historical(mockSeedGenerator.Object);
            var subtype = historical.Subtype;

            var expectedSubtype = "Artifact";
            Assert.AreEqual(expectedSubtype, subtype);
        }
    }
}
