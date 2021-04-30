using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RandomTables.WorldHooks;

namespace RandomTablesTests.WorldHooks
{

    // The characteristics are in a collection assigned to a range of numbers.
    // If the percentile dice 0 and 0 return a result between the upper and lower
    // bounds of the range, inclusive, then that characteristic is chosen.
    // The full range goes from 01 to 00.

    // Climate or landform is chosen when the result is 01 to 24.
    // Random seed: Guid.NewGuid().GetHashCode();

    [TestClass]
    public class CharacteristicsTests
    {
        private const int _seedGenerates0 = 14;
        private const int _seedGenerates1 = 18;
        private const int _seedGenerates2 = 1;
        private const int _seedGenerates3 = 5;
        private const int _seedGenerates4 = 9;
        private const int _seedGenerates5 = 13;
        private const int _seedGenerates6 = 17;
        private const int _seedGenerates8 = 4;

        [TestMethod]
        public void ClimateOrLandformWhen01IsRolled()
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                          .Returns(_seedGenerates0)
                          .Returns(_seedGenerates1);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Climate or Landform";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void ClimateOrLandformWhen24IsRolled()
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                          .Returns(_seedGenerates2)
                          .Returns(_seedGenerates4);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Climate or Landform";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SitesOfInterestWhen25IsRolled()
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                          .Returns(_seedGenerates2)
                          .Returns(_seedGenerates5);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Sites of Interest";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SitesOfInterestWhen34IsRolled()
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                          .Returns(_seedGenerates3)
                          .Returns(_seedGenerates4);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Sites of Interest";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void CulturesWhen35IsRolled()
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                          .Returns(_seedGenerates3)
                          .Returns(_seedGenerates5);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Cultures";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void CulturesWhen60IsRolled()
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                          .Returns(_seedGenerates6)
                          .Returns(_seedGenerates0);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Cultures";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SituationWhen61IsRolled()
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                          .Returns(_seedGenerates6)
                          .Returns(_seedGenerates1);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Situation";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SituationWhen85IsRolled()
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                          .Returns(_seedGenerates8)
                          .Returns(_seedGenerates5);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Situation";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void HistoricalWhen86IsRolled()
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                          .Returns(_seedGenerates8)
                          .Returns(_seedGenerates6);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Historical";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void HistoricalWhen00IsRolled()
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                          .Returns(_seedGenerates0)
                          .Returns(_seedGenerates0);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Historical";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }
    }
}
