using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTables.LocalArea;
using RandomTables.TestHelpers;
using System;

namespace RandomTablesTests.LocalArea
{
    [TestClass]
    public class MountainsAndHillsTests
    {
        private const int d10Returns0 = 14;
        private const int d10Returns1 = 18;
        private const int d10Returns2 = 1;
        private const int d10Returns3 = 5;
        private const int d10Returns6 = 17;
        private const int d10Returns7 = 0;
        private const int d10Returns8 = 4;
        private const int d10Returns9 = 8;

        [TestMethod]
        public void VeryMountainousWhen01IsRolled()
        {
            var tensSeed = d10Returns0;
            var onesSeed = d10Returns1;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var mountainsAndHills = new MountainsAndHills(mockSeedGenerator.Object);
            var mountainsAndHillsResult = mountainsAndHills.GetLocalAreaDetail();

            var expectedMountainsAndHillsResult = "Very Mountainous";

            Assert.AreEqual(expectedMountainsAndHillsResult, mountainsAndHillsResult);
        }

        [TestMethod]
        public void VeryMountainousWhen08IsRolled()
        {
            var tensSeed = d10Returns0;
            var onesSeed = d10Returns8;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var mountainsAndHills = new MountainsAndHills(mockSeedGenerator.Object);
            var mountainsAndHillsResult = mountainsAndHills.GetLocalAreaDetail();

            var expectedMountainsAndHillsResult = "Very Mountainous";

            Assert.AreEqual(expectedMountainsAndHillsResult, mountainsAndHillsResult);
        }

        [TestMethod]
        public void MountainousWhen09IsRolled()
        {
            var tensSeed = d10Returns0;
            var onesSeed = d10Returns9;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var mountainsAndHills = new MountainsAndHills(mockSeedGenerator.Object);
            var mountainsAndHillsResult = mountainsAndHills.GetLocalAreaDetail();

            var expectedMountainsAndHillsResult = "Mountainous";

            Assert.AreEqual(expectedMountainsAndHillsResult, mountainsAndHillsResult);
        }

        [TestMethod]
        public void MountainousWhen22IsRolled()
        {
            var tensSeed = d10Returns2;
            var onesSeed = d10Returns2;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var mountainsAndHills = new MountainsAndHills(mockSeedGenerator.Object);
            var mountainsAndHillsResult = mountainsAndHills.GetLocalAreaDetail();

            var expectedMountainsAndHillsResult = "Mountainous";

            Assert.AreEqual(expectedMountainsAndHillsResult, mountainsAndHillsResult);
        }

        [TestMethod]
        public void RuggedHillsWhen23IsRolled()
        {
            var tensSeed = d10Returns2;
            var onesSeed = d10Returns3;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var mountainsAndHills = new MountainsAndHills(mockSeedGenerator.Object);
            var mountainsAndHillsResult = mountainsAndHills.GetLocalAreaDetail();

            var expectedMountainsAndHillsResult = "Rugged Hills";

            Assert.AreEqual(expectedMountainsAndHillsResult, mountainsAndHillsResult);
        }

        [TestMethod]
        public void RuggedHillsWhen37IsRolled()
        {
            var tensSeed = d10Returns3;
            var onesSeed = d10Returns7;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var mountainsAndHills = new MountainsAndHills(mockSeedGenerator.Object);
            var mountainsAndHillsResult = mountainsAndHills.GetLocalAreaDetail();

            var expectedMountainsAndHillsResult = "Rugged Hills";

            Assert.AreEqual(expectedMountainsAndHillsResult, mountainsAndHillsResult);
        }

        [TestMethod]
        public void GentleHillsWhen38IsRolled()
        {
            var tensSeed = d10Returns3;
            var onesSeed = d10Returns8;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var mountainsAndHills = new MountainsAndHills(mockSeedGenerator.Object);
            var mountainsAndHillsResult = mountainsAndHills.GetLocalAreaDetail();

            var expectedMountainsAndHillsResult = "Gentle Hills";

            Assert.AreEqual(expectedMountainsAndHillsResult, mountainsAndHillsResult);
        }

        [TestMethod]
        public void GentleHillsWhen69IsRolled()
        {
            var tensSeed = d10Returns6;
            var onesSeed = d10Returns9;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var mountainsAndHills = new MountainsAndHills(mockSeedGenerator.Object);
            var mountainsAndHillsResult = mountainsAndHills.GetLocalAreaDetail();

            var expectedMountainsAndHillsResult = "Gentle Hills";

            Assert.AreEqual(expectedMountainsAndHillsResult, mountainsAndHillsResult);
        }
    }
}
