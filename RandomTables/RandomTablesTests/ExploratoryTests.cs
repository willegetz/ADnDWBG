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
