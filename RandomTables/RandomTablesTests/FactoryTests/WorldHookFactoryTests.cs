using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RandomTables.WorldHooks.Types;

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
