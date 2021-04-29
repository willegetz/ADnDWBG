using DiceTypes.DieTypes.Complex;
using IntervalTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTables.Interfaces;
using RandomTables.Interfaces.WorldHooks;
using RandomTables.WorldHooks;
using RandomTables.WorldHooks.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomTablesTests
{
    [TestClass]
    public class ExploratoryTests
    {
        // We are interested in the results of our random table lookup, not necessarily
        // in how the dice generate their results.
        // Right now we have set the seed values of the dice in order to produce the correct
        // result used to lookup the values on the random table. This depends on the dice
        // rolls, so we have to control the dice.
        // However, the dice have been tested in their own solution

        private const int _d10SeedGenerates0 = 14;
        private const int _d10SeedGenerates1 = 18;
        private const int _d10SeedGenerates2 = 1;
        private const int _d10SeedGenerates3 = 5;
        private const int _d10SeedGenerates4 = 9;
        private const int _d10SeedGenerates5 = 13;
        private const int _d10SeedGenerates6 = 17;
        private const int _d10SeedGenerates8 = 4;

        private IntervalTree<int, Func<string>> simpleFuncTable;
        private IntervalTree<int, Func<IWorldHookSubtypes>> factoryTable;

        [TestInitialize]
        public void BuildTables()
        {
            simpleFuncTable = new IntervalTree<int, Func<string>>()
            {
                {1, 24, GetClimateOrLandform },
            };

            factoryTable = new IntervalTree<int, Func<IWorldHookSubtypes>>()
            {
                {1, 24, ClimateOrLandformsFactory.Get },
            };
        }

        private IntervalTree<int, IFactory> worldHookFactoryTable = new IntervalTree<int, IFactory>()
        {
            {1, 24, new SpikeClimateOrLandformFactory() },
            {25, 34, new SpikeSitesOfInterestFactory() }
        };

        private IntervalTree<int, IWorldHook> worldHookSubtypesTable = new IntervalTree<int, IWorldHook>()
        {
            {1, 24, new SpikeClimateOrLandformFactory().Get() },
            {25, 34, new SpikeSitesOfInterestFactory().Get() }
        };

        public int GetResult()
        {
            int seed = Guid.NewGuid().GetHashCode();
            Random random = new Random(seed);
            int randomValue = random.Next(1, 35);

            return randomValue;
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

        [TestMethod]
        [Ignore("Part of exploratory testing")]
        public void GetWorldHookTest()
        {
            var tableResult = simpleFuncTable.Query(1).FirstOrDefault();
            var worldHook = tableResult();

            var expectedHook = @"Characteristic: Climate or Landform
Subtype: Forest";
            Assert.AreEqual(expectedHook, tableResult);
        }

        [TestMethod]
        [Ignore("Part of exploratory testing")]
        public void ClimateOrLandformsFactoryTest()
        {
            var tableResult = factoryTable.Query(1).FirstOrDefault();
            var hookResult = tableResult().GetCharacteristicSubtype();

            Assert.AreEqual("Forest", hookResult);
        }

        public string GetWorldHook()
        {
            var d10SeedGenerates0 = 14;
            var d10SeedGenerates1 = 18;
            var d8SeedGenerates5 = 13;
            var d6SeedGenerates1 = 14;

            // Providing a function in place of a string would mean I could
            // get away with having the characteristic as a string.
            // The characteristic class would become what? A lookup?
            // What is the nature of a World Hook Characteristic?
            // It provides a subtype based on a range of values.

            var characteristics = new Characteristics();
            var characteristic = characteristics.GetCharacteristic();

            // Forest needs to be 5
            var climateOrLandforms = new ClimateOrLandformSubtype();
            var characteristicSubtype = climateOrLandforms.GetCharacteristicSubtype();

            var worldHook = $@"Characteristic: {characteristic}
Subtype: {characteristicSubtype}";

            return worldHook;
        }

        public string GetClimateOrLandform()
        {
            var d8SeedGenerates5 = 13;
            var d6SeedGenerates1 = 14;

            var climateOrLandforms = new ClimateOrLandformSubtype();
            var characteristicSubtype = climateOrLandforms.GetCharacteristicSubtype();

            var worldHook = $@"Characteristic: Climate or Landform
Subtype: {characteristicSubtype}";

            return worldHook;
        }
    }

    public class SpikeClimateOrLandformFactory : IFactory
    {
        public IWorldHook Get()
        {
            var d8Seed = Guid.NewGuid().GetHashCode();
            var d6Seed = Guid.NewGuid().GetHashCode();

            return new ClimateOrLandform();
        }
    }

    public class SpikeSitesOfInterestFactory : IFactory
    {
        public IWorldHook Get()
        {
            var d8Seed = Guid.NewGuid().GetHashCode();

            return new SitesOfInterest(d8Seed);
        }
    }

    class ClimateOrLandformsFactory
    {
        public static IWorldHookSubtypes Get()
        {
            var d8SeedGenerates5 = 13;
            var d6SeedGenerates1 = 14;

            return new SpikeClimateOrLandforms(d8SeedGenerates5, d6SeedGenerates1);
        }
    }

    interface IWorldHookSubtypes
    {
        int RollDie();
        string LookupSubtype(int rollResult);
        string GetCharacteristicSubtype();
    }

    public class SpikeClimateOrLandforms : IWorldHookSubtypes
    {
        private D16 _d16;

        private Dictionary<int, string> climateOrLandforms = new Dictionary<int, string>()
        {
            {1, "Aerial" },
            {2, "Archipelago" },
            {3, "Arctic" },
            {4, "Desert" },
            {5, "Forest" },
            {6, "Inland sea/lake" },
            {7, "Jungle" },
            {8, "Mountain" },
            {9, "Oceanic" },
            {10, "Plains/steppes" },
            {11, "Subterranean" },
            {12, "Swamp" },
            {13, "Uninhabitable" },
            {14, "Unstable/formless" },
            {15, "Volcanic" },
            {16, "Weather" }
        };

        public SpikeClimateOrLandforms(int d8seed, int d6seed)
        {
            _d16 = new D16(d8seed, d6seed);
        }

        public int RollDie()
        {
            return _d16.RollDie();
        }

        public string LookupSubtype(int rollResult)
        {
            return climateOrLandforms[rollResult];
        }

        public string GetCharacteristicSubtype()
        {
            var rollResult = RollDie();
            var subtype = LookupSubtype(rollResult);

            return subtype;
        }
    }
}
