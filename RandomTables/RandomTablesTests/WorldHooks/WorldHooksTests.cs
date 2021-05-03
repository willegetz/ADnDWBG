using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTables.TestHelpers;
using RandomTables.WorldHooks;

namespace RandomTablesTests.WorldHooks
{
    [TestClass]
    public class WorldHooksTests
    {

        [TestMethod]
        public void GetFullWorldHookDescription_ClimateOrLandform_PlainsOrSteppes()
        {
            var seeds = new[] { 14, 18, 1, 0 };
            var mockCharacteristicSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockCharacteristicSeedGenerator.Object);
            var hookFactory = characteristics.SpikeGetWorldHook();

            var hook = hookFactory.GetHook();

            var expectedHook = @"Characteristic: Climate or Landform
Subtype: Plains/steppes";

            Assert.AreEqual(expectedHook, hook);
        }
    }
}
