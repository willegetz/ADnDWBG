using IntervalTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTables.WorldHooks;
using System;

namespace RandomTablesTests.FactoryTests
{
    [TestClass]
    public class WorldHookFactoryTests
    {
        private IntervalTree<int, string> characteristicsTable;

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
        }

        [TestMethod]
        public void ReturnsForestWhenRun()
        {
            // Can the interval tree return a type of string, func?

            // var characteristic = characteristicsTable.Query(1);

            var characteristics = new Characteristics(_d10SeedGenerates0, _d10SeedGenerates1);
            var characteristic = characteristics.GetCharacteristic();

            // Forest needs to be 5
            var d8SeedGenerates5 = 13;
            var d6SeedGenerates1 = 14;
            var climateOrLandforms = new ClimateOrLandforms(d8SeedGenerates5, d6SeedGenerates1);
            var characteristicSubtype = climateOrLandforms.GetCharacteristicSubtype();


            Assert.AreEqual("Climate or Landform", characteristic);
            Assert.AreEqual("Forest", characteristicSubtype);
        }

        [TestMethod]
        public void GetWorldHookTest()
        {
            var worldHook = GetWorldHook();

            var expectedHook = @"Characteristic: Climate or Landform
Subtype: Forest";
            Assert.AreEqual(expectedHook, worldHook);
        }

        public string GetWorldHook()
        {
            var d10SeedGenerates0 = 14;
            var d10SeedGenerates1 = 18;
            var d8SeedGenerates5 = 13;
            var d6SeedGenerates1 = 14;

            var characteristics = new Characteristics(d10SeedGenerates0, d10SeedGenerates1);
            var characteristic = characteristics.GetCharacteristic();

            // Forest needs to be 5
            var climateOrLandforms = new ClimateOrLandforms(d8SeedGenerates5, d6SeedGenerates1);
            var characteristicSubtype = climateOrLandforms.GetCharacteristicSubtype();

            var worldHook = $@"Characteristic: {characteristic}
Subtype: {characteristicSubtype}";

            return worldHook;
        }
    }
}
