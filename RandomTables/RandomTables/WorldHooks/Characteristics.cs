using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using IntervalTree;
using RandomTables.Factories.WorldHooks;
using RandomTables.Interfaces.WorldHooks;
using System;
using System.Linq;

namespace RandomTables.WorldHooks
{
    public class Characteristics
    {
        private PercentileDice0and0 _percentileDice;
        private ISeedGenerator _seedGenerator;

        public IntervalTree<int, Func<IWorldHookFactory>> worldHookFactories = new IntervalTree<int, Func<IWorldHookFactory>>()
        {
            {1, 24, ClimateOrLandformFactory.GetFactory },
            {25, 34, SitesOfInterestFactory.GetFactory },
            {35, 60, CulturesFactory.GetFactory },
            {61, 85, SituationsFactory.GetFactory },
            {86, 99, HistoricalFactory.GetFactory },
            {0, 0, HistoricalFactory.GetFactory }
        };

        public Characteristics()
        {
            _percentileDice = new PercentileDice0and0();
        }

        public Characteristics(ISeedGenerator seedGenerator)
        {
            _seedGenerator = seedGenerator;
            _percentileDice = new PercentileDice0and0(seedGenerator);
        }

        public IWorldHookFactory GetWorldHookFactory()
        {
            var rollResult = _percentileDice.RollDie();

            var hookFactory = worldHookFactories.Query(rollResult)
                                                .ToList()
                                                .Select(x => x)
                                                .FirstOrDefault();

            return hookFactory();
        }

        public IWorldHook GetWorldHook()
        {
            var hookFactory = GetWorldHookFactory();

            return hookFactory.GetWorldHook(_seedGenerator);
        }
    }
}
