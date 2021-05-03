using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTables.TestHelpers;
using RandomTables.WorldHooks.Types;

namespace RandomTablesTests.WorldHooks
{
    [TestClass]
    public class CharacteristicSubtypesTests
    {
        [TestMethod]
        public void ReturnsForestWhenRolled()
        {
            var seeds = new[] { 13, 14 };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var climateOrLandform = new ClimateOrLandform(mockSeedGenerator.Object);
            var subtype = climateOrLandform.Subtype;

            var expectedSubtype = "Forest";
            Assert.AreEqual(expectedSubtype, subtype);
        }

        [TestMethod]
        public void ReturnsRuinsWhenRolled()
        {
            var seeds = new[] { 0 };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var sitesOfInterest = new SitesOfInterest(mockSeedGenerator.Object);
            var subtype = sitesOfInterest.Subtype;

            var expectedSubtype = "Ruins";
            Assert.AreEqual(expectedSubtype, subtype);
        }

        [TestMethod]
        public void ReturnsSeafaringWhenRolled()
        {
            var seeds = new[] { 10 };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var cultures = new Cultures(mockSeedGenerator.Object);
            var subtype = cultures.Subtype;

            var expectedSubtype = "Seafaring";
            Assert.AreEqual(expectedSubtype, subtype);
        }

        [TestMethod]
        public void ReturnsPsionicsWhenRolled()
        {
            var seeds = new[] { 3, 0 };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var situations = new Situations(mockSeedGenerator.Object);
            var subtype = situations.Subtype;

            var expectedSubtype = "Psionics";
            Assert.AreEqual(expectedSubtype, subtype);
        }

        [TestMethod]
        public void ReturnsArtifactWhenRolled()
        {
            var seeds = new[] { 1 };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var historical = new Historical(mockSeedGenerator.Object);
            var subtype = historical.Subtype;

            var expectedSubtype = "Artifact";
            Assert.AreEqual(expectedSubtype, subtype);
        }
    }
}
