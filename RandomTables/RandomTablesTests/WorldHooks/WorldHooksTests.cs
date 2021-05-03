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
        public Mock<ISeedGenerator> GetMockSeedGenerator(int[] seeds)
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed())
                             .Returns(new Queue<int>(seeds).Dequeue);

            return mockSeedGenerator;
        }

        [TestMethod]
        public void GetFullWorldHookDescription_ClimateOrLandform_PlainsOrSteppes()
        {
            var seeds = new[] { 14, 18, 1, 0 };
            var mockCharacteristicSeedGenerator = GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockCharacteristicSeedGenerator.Object);
            var hookFactory = characteristics.SpikeGetWorldHook();

            var hook = hookFactory.GetHook();

            var expectedHook = @"Characteristic: Climate or Landform
Subtype: Plains/steppes";

            Assert.AreEqual(expectedHook, hook);
        }
    }
}
