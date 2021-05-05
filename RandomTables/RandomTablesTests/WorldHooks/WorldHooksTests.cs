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
            var d10TensSeed = 14;
            var d10OnesSeed = 18;
            var d8Seed = 1;
            var d6Seed = 0;

            var seeds = new[] { d10TensSeed, d10OnesSeed, d8Seed, d6Seed };
            var mockCharacteristicSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockCharacteristicSeedGenerator.Object);
            var hookFactory = characteristics.SpikeGetWorldHook();

            var hook = hookFactory.GetHook();

            var expectedHook = @"Characteristic: Climate or Landform
Subtype: Plains/steppes";

            Assert.AreEqual(expectedHook, hook);
        }

        [TestMethod]
        public void GetFullWorldHookDescription_SitesOfInterest_Dungeons()
        {
            var d10TensSeed = 5;
            var d10OnesSeed = 14;
            var d8Seed = 3;

            var seeds = new[] { d10TensSeed, d10OnesSeed, d8Seed };
            var mockCharacteristicSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockCharacteristicSeedGenerator.Object);
            var hookFactory = characteristics.SpikeGetWorldHook();

            var hook = hookFactory.GetHook();

            var expectedHook = @"Characteristic: Sites of Interest
Subtype: Dungeons";

            Assert.AreEqual(expectedHook, hook);
        }
    }
}
