using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTables.KingdomsAndSociety;
using RandomTables.TestHelpers;

namespace RandomTablesTests.KingdomsAndSociety
{
    [TestClass]
    public class KingdomClimateTests
    {
        private const int d10Returns0 = 14;
        private const int d10Returns1 = 18;
        private const int d10Returns2 = 1;
        private const int d10Returns5 = 13;
        private const int d10Returns6 = 17;
        private const int d10Returns7 = 0;
        private const int d10Returns8 = 4;
        private const int d10Returns9 = 8;

        [TestMethod]
        public void SuperArcticWhen01IsRolled()
        {
            var tensSeed = d10Returns0;
            var onesSeed = d10Returns1;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var kingdomClimate = new KingdomClimate(mockSeedGenerator.Object);
            var kingdomClimateResult = kingdomClimate.GetRandomTableResult();

            var expectedKingdomClimateResult = "Super-arctic";

            Assert.AreEqual(expectedKingdomClimateResult, kingdomClimateResult);
        }

        [TestMethod]
        public void ArcticWhen02IsRolled()
        {
            var tensSeed = d10Returns0;
            var onesSeed = d10Returns2;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var kingdomClimate = new KingdomClimate(mockSeedGenerator.Object);
            var kingdomClimateResult = kingdomClimate.GetRandomTableResult();

            var expectedKingdomClimateResult = "Arctic";

            Assert.AreEqual(expectedKingdomClimateResult, kingdomClimateResult);
        }

        [TestMethod]
        public void ArcticWhen06IsRolled()
        {
            var tensSeed = d10Returns0;
            var onesSeed = d10Returns6;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var kingdomClimate = new KingdomClimate(mockSeedGenerator.Object);
            var kingdomClimateResult = kingdomClimate.GetRandomTableResult();

            var expectedKingdomClimateResult = "Arctic";

            Assert.AreEqual(expectedKingdomClimateResult, kingdomClimateResult);
        }

        [TestMethod]
        public void SubArcticWhen07IsRolled()
        {
            var tensSeed = d10Returns0;
            var onesSeed = d10Returns7;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var kingdomClimate = new KingdomClimate(mockSeedGenerator.Object);
            var kingdomClimateResult = kingdomClimate.GetRandomTableResult();

            var expectedKingdomClimateResult = "Sub-arctic";

            Assert.AreEqual(expectedKingdomClimateResult, kingdomClimateResult);
        }

        [TestMethod]
        public void SubArcticWhen25IsRolled()
        {
            var tensSeed = d10Returns2;
            var onesSeed = d10Returns5;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var kingdomClimate = new KingdomClimate(mockSeedGenerator.Object);
            var kingdomClimateResult = kingdomClimate.GetRandomTableResult();

            var expectedKingdomClimateResult = "Sub-arctic";

            Assert.AreEqual(expectedKingdomClimateResult, kingdomClimateResult);
        }

        [TestMethod]
        public void TemperateWhen26IsRolled()
        {
            var tensSeed = d10Returns2;
            var onesSeed = d10Returns6;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var kingdomClimate = new KingdomClimate(mockSeedGenerator.Object);
            var kingdomClimateResult = kingdomClimate.GetRandomTableResult();

            var expectedKingdomClimateResult = "Temperate";

            Assert.AreEqual(expectedKingdomClimateResult, kingdomClimateResult);
        }

        [TestMethod]
        public void TemperateWhen60IsRolled()
        {
            var tensSeed = d10Returns6;
            var onesSeed = d10Returns0;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var kingdomClimate = new KingdomClimate(mockSeedGenerator.Object);
            var kingdomClimateResult = kingdomClimate.GetRandomTableResult();

            var expectedKingdomClimateResult = "Temperate";

            Assert.AreEqual(expectedKingdomClimateResult, kingdomClimateResult);
        }

        [TestMethod]
        public void SubTropicalWhen61IsRolled()
        {
            var tensSeed = d10Returns6;
            var onesSeed = d10Returns1;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var kingdomClimate = new KingdomClimate(mockSeedGenerator.Object);
            var kingdomClimateResult = kingdomClimate.GetRandomTableResult();

            var expectedKingdomClimateResult = "Sub-tropical";

            Assert.AreEqual(expectedKingdomClimateResult, kingdomClimateResult);
        }

        [TestMethod]
        public void SubTropicalWhen80IsRolled()
        {
            var tensSeed = d10Returns8;
            var onesSeed = d10Returns0;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var kingdomClimate = new KingdomClimate(mockSeedGenerator.Object);
            var kingdomClimateResult = kingdomClimate.GetRandomTableResult();

            var expectedKingdomClimateResult = "Sub-tropical";

            Assert.AreEqual(expectedKingdomClimateResult, kingdomClimateResult);
        }

        [TestMethod]
        public void TropicalWhen81IsRolled()
        {
            var tensSeed = d10Returns8;
            var onesSeed = d10Returns1;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var kingdomClimate = new KingdomClimate(mockSeedGenerator.Object);
            var kingdomClimateResult = kingdomClimate.GetRandomTableResult();

            var expectedKingdomClimateResult = "Tropical";

            Assert.AreEqual(expectedKingdomClimateResult, kingdomClimateResult);
        }

        [TestMethod]
        public void TropicalWhen97IsRolled()
        {
            var tensSeed = d10Returns9;
            var onesSeed = d10Returns7;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var kingdomClimate = new KingdomClimate(mockSeedGenerator.Object);
            var kingdomClimateResult = kingdomClimate.GetRandomTableResult();

            var expectedKingdomClimateResult = "Tropical";

            Assert.AreEqual(expectedKingdomClimateResult, kingdomClimateResult);
        }

        [TestMethod]
        public void SuperTropicalWhen98IsRolled()
        {
            var tensSeed = d10Returns9;
            var onesSeed = d10Returns8;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var kingdomClimate = new KingdomClimate(mockSeedGenerator.Object);
            var kingdomClimateResult = kingdomClimate.GetRandomTableResult();

            var expectedKingdomClimateResult = "Super-tropical";

            Assert.AreEqual(expectedKingdomClimateResult, kingdomClimateResult);
        }

        [TestMethod]
        public void SuperTropicalWhen99IsRolled()
        {
            var tensSeed = d10Returns9;
            var onesSeed = d10Returns9;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var kingdomClimate = new KingdomClimate(mockSeedGenerator.Object);
            var kingdomClimateResult = kingdomClimate.GetRandomTableResult();

            var expectedKingdomClimateResult = "Super-tropical";

            Assert.AreEqual(expectedKingdomClimateResult, kingdomClimateResult);
        }

        [TestMethod]
        public void SuperTropicalWhen00IsRolled()
        {
            var tensSeed = d10Returns0;
            var onesSeed = d10Returns0;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var kingdomClimate = new KingdomClimate(mockSeedGenerator.Object);
            var kingdomClimateResult = kingdomClimate.GetRandomTableResult();

            var expectedKingdomClimateResult = "Super-tropical";

            Assert.AreEqual(expectedKingdomClimateResult, kingdomClimateResult);
        }
    }
}
