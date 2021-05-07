﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        private const int d10Returns8 = 4;

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
    }
}
