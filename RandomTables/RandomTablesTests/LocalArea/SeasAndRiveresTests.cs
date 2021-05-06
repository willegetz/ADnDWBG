using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTables.LocalArea;
using RandomTables.TestHelpers;

namespace RandomTablesTests.LocalArea
{
    [TestClass]
    public class SeasAndRiveresTests
    {
        private const int d10Returns0 = 14;
        private const int d10Returns1 = 18;
        private const int d10Returns2 = 1;
        private const int d10Returns3 = 5;
        private const int d10Returns4 = 9;
        private const int d10Returns5 = 13;
        private const int d10Returns6 = 17;
        private const int d10Returns7 = 0;
        private const int d10Returns9 = 8;

        [TestMethod]
        public void IslandWhen01IsRolled()
        {
            // Using two d10s each with face numbers 0-9, assign one as the "tens" value
            // Roll them and consult the "seas and rivers" table
            // A roll of "01" will result in an Island
            // An island is typically 20 to 40 miles across and could also contain
            // minor lakes, streams, or other small bodies of water

            // For this test, we are more interested in ensuring the table being
            // built will give us back the appropriate result
            // Any additional details will be implemented later

            var tensSeed = d10Returns0;
            var onesSeed = d10Returns1;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var seasAndRivers = new SeasAndRivers(mockSeedGenerator.Object);
            var seaAndRiverResult = seasAndRivers.GetLocalAreaDetail();

            var expectedseaAndRiverResult = "Island";

            Assert.AreEqual(expectedseaAndRiverResult, seaAndRiverResult);
        }

        [TestMethod]
        public void IslandWhen10IsRolled()
        {
            var tensSeed = d10Returns1;
            var onesSeed = d10Returns0;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var seasAndRivers = new SeasAndRivers(mockSeedGenerator.Object);
            var seaAndRiverResult = seasAndRivers.GetLocalAreaDetail();

            var expectedseaAndRiverResult = "Island";

            Assert.AreEqual(expectedseaAndRiverResult, seaAndRiverResult);
        }

        [TestMethod]
        public void CoastalOrPenninsulaWhen11IsRolled()
        {
            var tensSeed = d10Returns1;
            var onesSeed = d10Returns1;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var seasAndRivers = new SeasAndRivers(mockSeedGenerator.Object);
            var seaAndRiverResult = seasAndRivers.GetLocalAreaDetail();

            var expectedseaAndRiverResult = "Coastal or Penninsula";

            Assert.AreEqual(expectedseaAndRiverResult, seaAndRiverResult);
        }

        [TestMethod]
        public void CoastalOrPenninsulaWhen19IsRolled()
        {
            var tensSeed = d10Returns1;
            var onesSeed = d10Returns9;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var seasAndRivers = new SeasAndRivers(mockSeedGenerator.Object);
            var seaAndRiverResult = seasAndRivers.GetLocalAreaDetail();

            var expectedseaAndRiverResult = "Coastal or Penninsula";

            Assert.AreEqual(expectedseaAndRiverResult, seaAndRiverResult);
        }

        [TestMethod]
        public void MajorLakeWhen20IsRolled()
        {
            var tensSeed = d10Returns2;
            var onesSeed = d10Returns0;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var seasAndRivers = new SeasAndRivers(mockSeedGenerator.Object);
            var seaAndRiverResult = seasAndRivers.GetLocalAreaDetail();

            var expectedseaAndRiverResult = "Major Lake";

            Assert.AreEqual(expectedseaAndRiverResult, seaAndRiverResult);
        }

        [TestMethod]
        public void MajorLakeWhen29IsRolled()
        {
            var tensSeed = d10Returns2;
            var onesSeed = d10Returns9;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var seasAndRivers = new SeasAndRivers(mockSeedGenerator.Object);
            var seaAndRiverResult = seasAndRivers.GetLocalAreaDetail();

            var expectedseaAndRiverResult = "Major Lake";

            Assert.AreEqual(expectedseaAndRiverResult, seaAndRiverResult);
        }

        [TestMethod]
        public void MajorRiverWhen30IsRolled()
        {
            var tensSeed = d10Returns3;
            var onesSeed = d10Returns0;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var seasAndRivers = new SeasAndRivers(mockSeedGenerator.Object);
            var seaAndRiverResult = seasAndRivers.GetLocalAreaDetail();

            var expectedseaAndRiverResult = "Major River";

            Assert.AreEqual(expectedseaAndRiverResult, seaAndRiverResult);
        }

        [TestMethod]
        public void MajorRiverWhen45IsRolled()
        {
            var tensSeed = d10Returns4;
            var onesSeed = d10Returns5;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var seasAndRivers = new SeasAndRivers(mockSeedGenerator.Object);
            var seaAndRiverResult = seasAndRivers.GetLocalAreaDetail();

            var expectedseaAndRiverResult = "Major River";

            Assert.AreEqual(expectedseaAndRiverResult, seaAndRiverResult);
        }

        [TestMethod]
        public void MinorLakesAndRiversWhen46IsRolled()
        {
            var tensSeed = d10Returns4;
            var onesSeed = d10Returns6;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var seasAndRivers = new SeasAndRivers(mockSeedGenerator.Object);
            var seaAndRiverResult = seasAndRivers.GetLocalAreaDetail();

            var expectedseaAndRiverResult = "Minor Lakes and Rivers";

            Assert.AreEqual(expectedseaAndRiverResult, seaAndRiverResult);
        }

        [TestMethod]
        public void MinorLakesAndRiversWhen70IsRolled()
        {
            var tensSeed = d10Returns7;
            var onesSeed = d10Returns0;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var seasAndRivers = new SeasAndRivers(mockSeedGenerator.Object);
            var seaAndRiverResult = seasAndRivers.GetLocalAreaDetail();

            var expectedseaAndRiverResult = "Minor Lakes and Rivers";

            Assert.AreEqual(expectedseaAndRiverResult, seaAndRiverResult);
        }

        [TestMethod]
        public void NoSignificantWaterWhen71IsRolled()
        {
            var tensSeed = d10Returns7;
            var onesSeed = d10Returns1;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var seasAndRivers = new SeasAndRivers(mockSeedGenerator.Object);
            var seaAndRiverResult = seasAndRivers.GetLocalAreaDetail();

            var expectedseaAndRiverResult = "No Significant Water";

            Assert.AreEqual(expectedseaAndRiverResult, seaAndRiverResult);
        }

        [TestMethod]
        public void NoSignificantWaterWhen99IsRolled()
        {
            var tensSeed = d10Returns9;
            var onesSeed = d10Returns9;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var seasAndRivers = new SeasAndRivers(mockSeedGenerator.Object);
            var seaAndRiverResult = seasAndRivers.GetLocalAreaDetail();

            var expectedseaAndRiverResult = "No Significant Water";

            Assert.AreEqual(expectedseaAndRiverResult, seaAndRiverResult);
        }
    }
}
