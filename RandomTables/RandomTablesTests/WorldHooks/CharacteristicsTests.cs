﻿using IntervalTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTables.Interfaces;
using RandomTables.Interfaces.WorldHooks;
using RandomTables.WorldHooks;
using RandomTables.WorldHooks.Types;
using System;
using System.Linq;

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
            var characteristics = new Characteristics(_seedGenerates0, _seedGenerates1);
            var getSubtypeFunction = characteristics.GetSubtype(1);

            var subtypeHook = getSubtypeFunction().HookType;

            var expectedCharacteristic = "Climate or Landform";

            Assert.AreEqual(expectedCharacteristic, subtypeHook);
        }

        [TestMethod]
        public void ClimateOrLandformWhen24IsRolled()
        {
            var characteristics = new Characteristics(_seedGenerates2, _seedGenerates4);
            var characteristic = characteristics.GetCharacteristic();

            var expectedCharacteristic = "Climate or Landform";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SitesOfInterestWhen25IsRolled()
        {
            var characteristics = new Characteristics(_seedGenerates2, _seedGenerates5);
            var characteristic = characteristics.GetCharacteristic();

            var expectedCharacteristic = "Sites of Interest";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SitesOfInterestWhen34IsRolled()
        {
            var characteristics = new Characteristics(_seedGenerates3, _seedGenerates4);
            var characteristic = characteristics.GetCharacteristic();

            var expectedCharacteristic = "Sites of Interest";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void CulturesWhen35IsRolled()
        {
            var characteristics = new Characteristics(_seedGenerates3, _seedGenerates5);
            var characteristic = characteristics.GetCharacteristic();

            var expectedCharacteristic = "Cultures";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void CulturesWhen60IsRolled()
        {
            var characteristics = new Characteristics(_seedGenerates6, _seedGenerates0);
            var characteristic = characteristics.GetCharacteristic();

            var expectedCharacteristic = "Cultures";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SituationWhen61IsRolled()
        {
            var characteristics = new Characteristics(_seedGenerates6, _seedGenerates1);
            var characteristic = characteristics.GetCharacteristic();

            var expectedCharacteristic = "Situation";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void SituationWhen85IsRolled()
        {
            var characteristics = new Characteristics(_seedGenerates8, _seedGenerates5);
            var characteristic = characteristics.GetCharacteristic();

            var expectedCharacteristic = "Situation";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void HistoricalWhen86IsRolled()
        {
            var characteristics = new Characteristics(_seedGenerates8, _seedGenerates6);
            var characteristic = characteristics.GetCharacteristic();

            var expectedCharacteristic = "Historical";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }

        [TestMethod]
        public void HistoricalWhen00IsRolled()
        {
            var characteristics = new Characteristics(_seedGenerates0, _seedGenerates0);
            var characteristic = characteristics.GetCharacteristic();

            var expectedCharacteristic = "Historical";

            Assert.AreEqual(expectedCharacteristic, characteristic);
        }


        private IntervalTree<int, IFactory> worldHookFactoryTable = new IntervalTree<int, IFactory>()
        {
            {1, 24, new SpikeClimateOrLandformFactory() },
            {25, 34, new SpikeSitesOfInterestFactory() }
        };

        private IntervalTree<int, IWorldHookSubtype> worldHookSubtypesTable = new IntervalTree<int, IWorldHookSubtype>()
        {
            {1, 24, new SpikeClimateOrLandformFactory().Get() },
            {25, 34, new SpikeSitesOfInterestFactory().Get() }
        };

        public int GetResult()
        {
            var seed = Guid.NewGuid().GetHashCode();
            return new Random(seed).Next(1, 35);
        }

        [TestMethod]
        [Ignore("Experimenting with factory")]
        public void AUseFactoryTable()
        {
            var result = GetResult();

            var worldHookFactory = worldHookFactoryTable.Query(result).ToList().FirstOrDefault();
            var hookSubtype = worldHookFactory.Get();
            var hookType = hookSubtype.GetHook();

            Assert.AreEqual(hookType, "");
        }

        [TestMethod]
        [Ignore("Experimenting with factory")]
        public void AUseSubtypeTable()
        {
            var result = GetResult();

            var worldHooks = worldHookSubtypesTable.Query(result).ToList().FirstOrDefault();
            var hookType = worldHooks.GetHook();

            Assert.AreEqual(hookType, "");
        }
    }

    public class SpikeClimateOrLandformFactory : IFactory
    {
        public IWorldHookSubtype Get()
        {
            var d8Seed = Guid.NewGuid().GetHashCode();
            var d6Seed = Guid.NewGuid().GetHashCode();

            return new ClimateOrLandform(d8Seed, d6Seed);
        }
    }

    public class SpikeSitesOfInterestFactory : IFactory
    {
        public IWorldHookSubtype Get()
        {
            var d8Seed = Guid.NewGuid().GetHashCode();

            return new SitesOfInterest(d8Seed);
        }
    }
}
