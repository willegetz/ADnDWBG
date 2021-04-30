using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RandomTables.TestHelpers;
using RandomTables.WorldHooks.Types;

namespace RandomTablesTests.WorldHooks
{
    [TestClass]
    public class CharacteristicSubtypesTests
    {
        [TestMethod]
        public void ReturnsForestWhenRun()
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                          .Returns(13)
                          .Returns(14);

            var climateOrLandform = new ClimateOrLandform(mockSeedGenerator.Object);
            var subtype = climateOrLandform.Subtype;

            var expectedSubtype = "Forest";
            Assert.AreEqual(expectedSubtype, subtype);
        }

        [TestMethod]
        public void ReturnsRuinsWhenRun()
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed())
                          .Returns(0);

            var sitesOfInterest = new SitesOfInterest(mockSeedGenerator.Object);
            var subtype = sitesOfInterest.Subtype;

            var expectedSubtype = "Ruins";
            Assert.AreEqual(expectedSubtype, subtype);
        }

        [TestMethod]
        public void ReturnsSeafaringWhenRun()
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed())
                          .Returns(10);

            var cultures = new Cultures(mockSeedGenerator.Object);
            var subtype = cultures.Subtype;

            var expectedSubtype = "Seafaring";
            Assert.AreEqual(expectedSubtype, subtype);
        }
    }
}
