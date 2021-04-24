using DiceTypes.DieTypes;
using IntervalTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTables.WorldHooks;
using RandomTables.WorldHooks.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomTablesTests.FactoryTests
{
    [TestClass]
    public class WorldHookFactoryTests
    {
        private IntervalTree<int, string> characteristicsTable;
        private IntervalTree<int, Func<string>> simpleFuncTable;
        private IntervalTree<int, Func<IWorldHookSubtypes>> factoryTable;

        private const int _d10SeedGenerates0 = 14;
        private const int _d10SeedGenerates1 = 18;
        private const int _d10SeedGenerates2 = 1;
        private const int _d10SeedGenerates3 = 5;
        private const int _d10SeedGenerates4 = 9;
        private const int _d10SeedGenerates5 = 13;
        private const int _d10SeedGenerates6 = 17;
        private const int _d10SeedGenerates8 = 4;

        [TestInitialize]
        public void PopulateTable()
        {
            characteristicsTable = new IntervalTree<int, string>()
            {
                {1, 24, "Climate or Landform" },
                {25, 34, "Sites of Interest" },
                {35, 60, "Cultures" },
                {61, 85, "Situation" },
                {86, 99, "Historical" },
                {0, 0, "Historical" }
            };

            simpleFuncTable = new IntervalTree<int, Func<string>>()
            {
                {1, 24, GetClimateOrLandform },
            };

            factoryTable = new IntervalTree<int, Func<IWorldHookSubtypes>>()
            {
                {1, 24, ClimateOrLandformsFactory.Get },
            };
        }

        [TestMethod]
        public void ReturnsForestWhenRun()
        {
            var d8SeedGenerates5 = 13;
            var d6SeedGenerates1 = 14;
            
            var climateOrLandform = new ClimateOrLandform(d8SeedGenerates5, d6SeedGenerates1);
            var worldHook = climateOrLandform.GetHook();

            var expectedHook = @"Characteristic: Climate or Landform
Subtype: Forest";
            Assert.AreEqual(expectedHook, worldHook);
        }

        [TestMethod]
        public void GetWorldHookTest()
        {
            Func<string> tableResult = simpleFuncTable.Query(1).FirstOrDefault();
            var worldHook = tableResult();

            var expectedHook = @"Characteristic: Climate or Landform
Subtype: Forest";
            Assert.AreEqual(expectedHook, worldHook);
        }

        [TestMethod]
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

            var characteristics = new Characteristics(d10SeedGenerates0, d10SeedGenerates1);
            var characteristic = characteristics.GetCharacteristic();

            // Forest needs to be 5
            var climateOrLandforms = new ClimateOrLandformsSubType(d8SeedGenerates5, d6SeedGenerates1);
            var characteristicSubtype = climateOrLandforms.GetCharacteristicSubtype();

            var worldHook = $@"Characteristic: {characteristic}
Subtype: {characteristicSubtype}";

            return worldHook;
        }

        public string GetClimateOrLandform()
        {
            var d8SeedGenerates5 = 13;
            var d6SeedGenerates1 = 14;

            var climateOrLandforms = new ClimateOrLandformsSubType(d8SeedGenerates5, d6SeedGenerates1);
            var characteristicSubtype = climateOrLandforms.GetCharacteristicSubtype();

            var worldHook = $@"Characteristic: Climate or Landform
Subtype: {characteristicSubtype}";

            return worldHook;
        }

        // Landforms factory
        //  A Func in the tree which has a getter
        //  Getter returns an instantiated client or landforms
        //  Instantiated object can call the functions
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

    public class SpikeClimateOrLandforms: IWorldHookSubtypes
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
