using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTables.TestHelpers;
using RandomTables.WorldHooks;

namespace RandomTablesTests.WorldHooks
{
    [TestClass]
    public class WorldHooksTests
    {
        private const int d10Returns0 = 14;
        private const int d10Returns1 = 18;
        private const int d10Returns3 = 5;
        private const int d10Returns4 = 9;
        private const int d10Returns5 = 13;
        private const int d10Returns7 = 0;
        private const int d10Returns8 = 4;
        private const int d10Returns9 = 8;

        private const int d8Returns2 = 1;
        private const int d8Returns3 = 3;
        private const int d8Returns6 = 0;
        private const int d8Returns8 = 8;

        private const int d6Returns4 = 4;
        private const int d6Returns5 = 0;

        [TestMethod]
        public void GetFullWorldHookDescription_ClimateOrLandform_PlainsOrSteppes()
        {
            var d10TensSeed = d10Returns0;
            var d10OnesSeed = d10Returns1;
            var d8Seed = d8Returns2;
            var d6Seed = d6Returns5;

            var seeds = new[] { d10TensSeed, d10OnesSeed, d8Seed, d6Seed };
            var mockCharacteristicSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockCharacteristicSeedGenerator.Object);
            var hookFactory = characteristics.GetWorldHook();

            var hook = hookFactory.GetHook();

            var expectedHook = @"Characteristic: Climate or Landform
Subtype: Plains/steppes";

            Assert.AreEqual(expectedHook, hook);
        }

        [TestMethod]
        public void GetFullWorldHookDescription_SitesOfInterest_Dungeons()
        {
            var d10TensSeed = d10Returns3;
            var d10OnesSeed = d10Returns0;
            var d8Seed = d8Returns3;

            var seeds = new[] { d10TensSeed, d10OnesSeed, d8Seed };
            var mockCharacteristicSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockCharacteristicSeedGenerator.Object);
            var hookFactory = characteristics.GetWorldHook();

            var hook = hookFactory.GetHook();

            var expectedHook = @"Characteristic: Sites of Interest
Subtype: Dungeons";

            Assert.AreEqual(expectedHook, hook);
        }

        [TestMethod]
        public void GetFullWorldHookDescription_Cultures_Feudal()
        {
            var d10TensSeed = d10Returns5;
            var d10OnesSeed = d10Returns4;
            var d12Seed = 5;

            var seeds = new[] { d10TensSeed, d10OnesSeed, d12Seed };
            var mockCharacteristicSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockCharacteristicSeedGenerator.Object);
            var hookFactory = characteristics.GetWorldHook();

            var hook = hookFactory.GetHook();

            var expectedHook = @"Characteristic: Cultures
Subtype: Feudal";

            Assert.AreEqual(expectedHook, hook);
        }

        [TestMethod]
        public void GetFullWorldHookDescription_Situations_Warfare()
        {
            var d10TensSeed = d10Returns7;
            var d10OnesSeed = d10Returns8;
            var d8Seed = d8Returns8;
            var d6Seed = d6Returns4;

            var seeds = new[] { d10TensSeed, d10OnesSeed, d8Seed, d6Seed };
            var mockCharacteristicSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockCharacteristicSeedGenerator.Object);
            var hookFactory = characteristics.GetWorldHook();

            var hook = hookFactory.GetHook();

            var expectedHook = @"Characteristic: Situation
Subtype: Warfare";

            Assert.AreEqual(expectedHook, hook);
        }

        [TestMethod]
        public void GetFullWorldHookDescription_Historical_Insurrection()
        {
            var d10TensSeed = d10Returns9;
            var d10OnesSeed = d10Returns7;
            var d8Seed = d8Returns6;

            var seeds = new[] { d10TensSeed, d10OnesSeed, d8Seed };
            var mockCharacteristicSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockCharacteristicSeedGenerator.Object);
            var hookFactory = characteristics.GetWorldHook();

            var hook = hookFactory.GetHook();

            var expectedHook = @"Characteristic: Historical
Subtype: Insurrection";

            Assert.AreEqual(expectedHook, hook);
        }
    }
}
