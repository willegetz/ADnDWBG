using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTables.TestHelpers;
using RandomTables.WorldHooks;

namespace RandomTablesTests.WorldHooks
{
    [TestClass]
    public class CharacteristicsTests
    {
        private const int d10Returns0 = 14;
        private const int d10Returns1 = 18;
        private const int d10Returns2 = 1;
        private const int d10Returns3 = 5;
        private const int d10Returns4 = 9;
        private const int d10Returns5 = 13;
        private const int d10Returns6 = 17;
        private const int d10Returns8 = 4;

        [TestMethod]
        public void ClimateOrLandformWhen01IsRolled()
        {
            var tensSeed = d10Returns0;
            var onesSeed = d10Returns1;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Climate or Landform";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void ClimateOrLandformWhen24IsRolled()
        {
            var tensSeed = d10Returns2;
            var onesSeed = d10Returns4;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Climate or Landform";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SitesOfInterestWhen25IsRolled()
        {
            var tensSeed = d10Returns2;
            var onesSeed = d10Returns5;

            var seeds = new[] { tensSeed, onesSeed };
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Sites of Interest";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SitesOfInterestWhen34IsRolled()
        {
            var tensSeed = d10Returns3;
            var onesSeed = d10Returns4;

            var seeds = new[] { tensSeed, onesSeed};
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Sites of Interest";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void CulturesWhen35IsRolled()
        {
            var tensSeed = d10Returns3;
            var onesSeed = d10Returns5;

            var seeds = new[] { tensSeed, onesSeed};
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Cultures";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void CulturesWhen60IsRolled()
        {
            var tensSeed = d10Returns6;
            var onesSeed = d10Returns0;

            var seeds = new[] { tensSeed, onesSeed};
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Cultures";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SituationWhen61IsRolled()
        {
            var tensSeed = d10Returns6;
            var onesSeed = d10Returns1;

            var seeds = new[] { tensSeed, onesSeed};
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Situation";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SituationWhen85IsRolled()
        {
            var tensSeed = d10Returns8;
            var onesSeed = d10Returns5;

            var seeds = new[] { tensSeed, onesSeed};
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Situation";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void HistoricalWhen86IsRolled()
        {
            var tensSeed = d10Returns8;
            var onesSeed = d10Returns6;

            var seeds = new[] { tensSeed, onesSeed};
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Historical";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void HistoricalWhen00IsRolled()
        {
            var tensSeed = d10Returns0;
            var onesSeed = d10Returns0;

            var seeds = new[] { tensSeed, onesSeed};
            var mockSeedGenerator = SeedHelper.GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Historical";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }
    }
}
