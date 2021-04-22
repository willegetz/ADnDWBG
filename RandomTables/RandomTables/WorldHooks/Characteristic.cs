using DiceTypes.DieTypes;
using IntervalTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTables.TestHelpers;
using System;
using System.Linq;

namespace RandomTables.WorldHooks
{

    // The characteristics are in a collection assigned to a range of numbers.
    // If the percentile dice 0 and 0 return a result between the upper and lower
    // bounds of the range, inclusive, then that characteristic is chosen.
    // The full range goes from 01 to 00.

    // Climate or landform is chosen when the result is 01 to 24.
    // Random seed: Guid.NewGuid().GetHashCode();

    [TestClass]
    public class Characteristic
    {
        private const int _seedGenerates0 = 14;
        private const int _seedGenerates1 = 18;
        private const int _seedGenerates2 = 1;
        private const int _seedGenerates3 = 5;
        private const int _seedGenerates4 = 9;
        private const int _seedGenerates5 = 13;
        private const int _seedGenerates6 = 17;
        private const int _seedGenerates8 = 4;

        private IntervalTree<int, string> characteristicsTable;

        [TestInitialize]
        public void SeedIntervalTree()
        {
            characteristicsTable = new IntervalTree<int, string>()
            {
                {1, 24, "Climate or Landform" },
                {25, 34, "Sites of Interest" },
                {35, 60, "Cultures" },
                {61, 85, "Situation" }
            };
        }

        [TestMethod]
        public void ClimateOrLandformWhen01IsRolled()
        {
            var percentile = new PercentileDice0and0(_seedGenerates0, _seedGenerates1);
            var rollResult = percentile.RollDice();

            var characteristic = characteristicsTable.Query(rollResult)
                                            .ToList()
                                            .Select(x => x)
                                            .FirstOrDefault();

            var expectedRollResult = 1;
            var expectedCharacteristic = "Climate or Landform";

            Assert.AreEqual(expectedRollResult, rollResult);
            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void ClimateOrLandformWhen24IsRolled()
        {
            var percentile = new PercentileDice0and0(_seedGenerates2, _seedGenerates4);
            var rollResult = percentile.RollDice();

            var characteristic = characteristicsTable.Query(rollResult)
                                            .ToList()
                                            .Select(x => x)
                                            .FirstOrDefault();

            var expectedRollResult = 24;
            var expectedCharacteristic = "Climate or Landform";

            Assert.AreEqual(expectedRollResult, rollResult);
            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SitesOfInterestWhen25IsRolled()
        {
            var percentile = new PercentileDice0and0(_seedGenerates2, _seedGenerates5);
            var rollResult = percentile.RollDice();

            var characteristic = characteristicsTable.Query(rollResult)
                                            .ToList()
                                            .Select(x => x)
                                            .FirstOrDefault();

            var expectedRollResult = 25;
            var expectedCharacteristic = "Sites of Interest";

            Assert.AreEqual(expectedRollResult, rollResult);
            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SitesOfInterestWhen34IsRolled()
        {
            var percentile = new PercentileDice0and0(_seedGenerates3, _seedGenerates4);
            var rollResult = percentile.RollDice();

            var characteristic = characteristicsTable.Query(rollResult)
                                            .ToList()
                                            .Select(x => x)
                                            .FirstOrDefault();

            var expectedRollResult = 34;
            var expectedCharacteristic = "Sites of Interest";

            Assert.AreEqual(expectedRollResult, rollResult);
            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void CulturesWhen35IsRolled()
        {
            var percentile = new PercentileDice0and0(_seedGenerates3, _seedGenerates5);
            var rollResult = percentile.RollDice();

            var characteristic = characteristicsTable.Query(rollResult)
                                            .ToList()
                                            .Select(x => x)
                                            .FirstOrDefault();

            var expectedRollResult = 35;
            var expectedCharacteristic = "Cultures";

            Assert.AreEqual(expectedRollResult, rollResult);
            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void CulturesWhen60IsRolled()
        {
            var percentile = new PercentileDice0and0(_seedGenerates6, _seedGenerates0);
            var rollResult = percentile.RollDice();

            var characteristic = characteristicsTable.Query(rollResult)
                                            .ToList()
                                            .Select(x => x)
                                            .FirstOrDefault();

            var expectedRollResult = 60;
            var expectedCharacteristic = "Cultures";

            Assert.AreEqual(expectedRollResult, rollResult);
            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SituationWhen61IsRolled()
        {
            var percentile = new PercentileDice0and0(_seedGenerates6, _seedGenerates1);
            var rollResult = percentile.RollDice();

            var characteristic = characteristicsTable.Query(rollResult)
                                            .ToList()
                                            .Select(x => x)
                                            .FirstOrDefault();

            var expectedRollResult = 61;
            var expectedCharacteristic = "Situation";

            Assert.AreEqual(expectedRollResult, rollResult);
            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SituationWhen85IsRolled()
        {
            var percentile = new PercentileDice0and0(_seedGenerates8, _seedGenerates5);
            var rollResult = percentile.RollDice();

            var characteristic = characteristicsTable.Query(rollResult)
                                            .ToList()
                                            .Select(x => x)
                                            .FirstOrDefault();

            var expectedRollResult = 85;
            var expectedCharacteristic = "Situation";

            Assert.AreEqual(expectedRollResult, rollResult);
            Assert.AreEqual(expectedCharacteristic, characteristic);
        }
    }
}
