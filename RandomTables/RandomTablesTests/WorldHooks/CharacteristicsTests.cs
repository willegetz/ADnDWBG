using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RandomTables.WorldHooks;
using System.Collections.Generic;

namespace RandomTablesTests.WorldHooks
{
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

        public Mock<ISeedGenerator> GetMockSeedGenerator(int firstSeed, int secondSeed)
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                          .Returns(firstSeed)
                          .Returns(secondSeed);

            mockSeedGenerator.Setup(x => x.GetRandomSeed())
                             .Returns(new Queue<int>(new[] { firstSeed, secondSeed }).Dequeue);

            return mockSeedGenerator;
        }

        public Mock<ISeedGenerator> GetMockSeedGenerator(int[] seeds)
        {
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed())
                             .Returns(new Queue<int>(seeds).Dequeue);

            return mockSeedGenerator;
        }

        [TestMethod]
        public void ClimateOrLandformWhen01IsRolled()
        {
            var seeds = new[] { _seedGenerates0, _seedGenerates1 };
            var mockSeedGenerator = GetMockSeedGenerator(seeds);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Climate or Landform";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void ClimateOrLandformWhen24IsRolled()
        {
            var mockSeedGenerator = GetMockSeedGenerator(_seedGenerates2, _seedGenerates4);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Climate or Landform";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SitesOfInterestWhen25IsRolled()
        {
            var mockSeedGenerator = GetMockSeedGenerator(_seedGenerates2, _seedGenerates5);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Sites of Interest";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SitesOfInterestWhen34IsRolled()
        {
            var mockSeedGenerator = GetMockSeedGenerator(_seedGenerates3, _seedGenerates4);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Sites of Interest";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void CulturesWhen35IsRolled()
        {
            var mockSeedGenerator = GetMockSeedGenerator(_seedGenerates3, _seedGenerates5);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Cultures";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void CulturesWhen60IsRolled()
        {
            var mockSeedGenerator = GetMockSeedGenerator(_seedGenerates6, _seedGenerates0);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Cultures";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SituationWhen61IsRolled()
        {
            var mockSeedGenerator = GetMockSeedGenerator(_seedGenerates6, _seedGenerates1);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Situation";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SituationWhen85IsRolled()
        {
            var mockSeedGenerator = GetMockSeedGenerator(_seedGenerates8, _seedGenerates5);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Situation";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void HistoricalWhen86IsRolled()
        {
            var mockSeedGenerator = GetMockSeedGenerator(_seedGenerates8, _seedGenerates6);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Historical";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void HistoricalWhen00IsRolled()
        {
            var mockSeedGenerator = GetMockSeedGenerator(_seedGenerates0, _seedGenerates0);

            var characteristics = new Characteristics(mockSeedGenerator.Object);
            var characteristic = characteristics.GetWorldHook().CharacteristicType;

            var expectedCharacteristic = "Historical";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }
    }
}
