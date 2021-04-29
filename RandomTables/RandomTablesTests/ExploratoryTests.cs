using IntervalTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomTables.Interfaces;
using RandomTables.Interfaces.WorldHooks;
using RandomTables.WorldHooks.Types;
using System;
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
    }

    public class SpikeClimateOrLandformFactory : IFactory
    {
        public IWorldHookSubtype Get()
        {
            var d8Seed = Guid.NewGuid().GetHashCode();
            var d6Seed = Guid.NewGuid().GetHashCode();

            return new ClimateOrLandform();
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
