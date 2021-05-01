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

        private IntervalTree<int, Func<IWorldHook>> worldHookTable = new IntervalTree<int, Func<IWorldHook>>()
        {
            {1, 24, ClimateOrLandformFactory.Get },
            {25, 34, SitesOfInterestFactory.Get },
            {35, 60, CulturesFactory.Get },
            {61, 85, SituationsFactory.Get },
            {86, 99, HistoricalFactory.Get },
            {0, 0, HistoricalFactory.Get }
        };

        public Characteristics()
        {
            _percentileDice = new PercentileDice0and0();
        }

        public Characteristics(ISeedGenerator seedGenerator)
        {
            _percentileDice = new PercentileDice0and0(seedGenerator);
        }

        public Func<IWorldHook> WorldHookLookup(int rollResult)
        {
            var subtype = worldHookTable.Query(rollResult)
                                        .ToList()
                                        .Select(x => x)
                                        .FirstOrDefault();

            return subtype;
        }

        public IWorldHook GetWorldHook()
        {
            var rollResult = _percentileDice.RollDie();
            var worldHook = WorldHookLookup(rollResult);

            return worldHook();
        }
    }
}
