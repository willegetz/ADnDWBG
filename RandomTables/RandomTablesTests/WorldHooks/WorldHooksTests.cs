using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RandomTables.WorldHooks;
using System.Collections.Generic;

namespace RandomTablesTests.WorldHooks
{
    [TestClass]
    public class WorldHooksTests
    {
        [TestMethod]
        public void GetFullWorldHookDescription_ClimateOrLandform_PlainsOrSteppes()
        {
            var mockCharacteristicSeedGenerator = new Mock<ISeedGenerator>();
            mockCharacteristicSeedGenerator.Setup(x => x.GetRandomSeed())
                    .Returns(new Queue<int>(new[] { 14, 18, 1, 0 }).Dequeue);

            var characteristics = new Characteristics(mockCharacteristicSeedGenerator.Object);
            var hookFactory = characteristics.SpikeGetWorldHook();

            var hook = hookFactory.GetHook();

            var expectedHook = @"Characteristic: Climate or Landform
Subtype: Plains/steppes";

            Assert.AreEqual(expectedHook, hook);
        }
    }
}
