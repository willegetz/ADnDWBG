using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using IntervalTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RandomTables.WorldHooks;
using RandomTables.WorldHooks.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomTablesTests.FactoryTests
{
    [TestClass]
    public class WorldHookFactoryTests
    {
        [TestMethod]
        public void ReturnsForestWhenRun()
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                          .Returns(13)
                          .Returns(14);

            var climateOrLandform = new ClimateOrLandform(mockSeedGenerator.Object);
            var worldHook = climateOrLandform.GetHook();

            var expectedHook = @"Characteristic: Climate or Landform
Subtype: Forest";
            Assert.AreEqual(expectedHook, worldHook);
        }
    }
}
