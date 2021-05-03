using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RandomTables.WorldHooks;

namespace RandomTablesTests.WorldHooks
{
    [TestClass]
    public class WorldHooksTests
    {
        [TestMethod]
        public void GetFullWorldHookDescription_ClimateOrLandform_PlainsOrSteppes()
        {
            var mockCharacteristicSeedGenerator = new Mock<ISeedGenerator>();
            mockCharacteristicSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                                           .Returns(14)  // Tens result first
                                           .Returns(18) // Tens result second
                                           .Returns(1)  // D8 result first
                                           .Returns(0); // D6 result second

            var characteristics = new Characteristics(mockCharacteristicSeedGenerator.Object);
            var hookFactory = characteristics.SpikeGetWorldHook();

            var hook = hookFactory.GetHook();

            var expectedHook = @"Characteristic: Climate or Landform
Subtype: Plains/steppes";

            Assert.AreEqual(expectedHook, hook);
        }
    }
}
