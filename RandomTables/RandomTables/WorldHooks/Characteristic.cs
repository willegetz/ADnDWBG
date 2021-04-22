using DiceTypes.DieTypes;
using IntervalTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace RandomTables.WorldHooks
{
    [TestClass]
    public class Characteristic
    {

        // The characteristics are in a collection assigned to a range of numbers.
        // If the percentile dice 0 and 0 return a result between the upper and lower
        // bounds of the range, inclusive, then that characteristic is chosen.
        // The full range goes from 01 to 00.

        // Climate or landform is chosen when the result is 01 to 24.
        // Random seed: Guid.NewGuid().GetHashCode();

        private IntervalTree<int, string> characteristicsTable;

        [TestInitialize]
        public void SeedIntervalTree()
        {
            characteristicsTable = new IntervalTree<int, string>()
            {
                {1, 24, "Climate or Landform" }
            };
        }

        [TestMethod]
        public void ClimateOrLandformWhen01IsRolled()
        {
            var seedGenerates0 = 14;
            var seedGenerates1 = 18;

            var percentile = new PercentileDice0and0(seedGenerates0, seedGenerates1);
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
            var seedGenerates2 = 1;
            var seedGenerates4 = 9;

            var percentile = new PercentileDice0and0(seedGenerates2, seedGenerates4);
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
    }
}
