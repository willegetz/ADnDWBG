﻿using DiceTypes.DieTypes.Complex;
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

        private IntervalTree<int, string> characteristicsTable = new IntervalTree<int, string>()
            {
                {1, 24, "Climate or Landform" },
                {25, 34, "Sites of Interest" },
                {35, 60, "Cultures" },
                {61, 85, "Situation" },
                {86, 99, "Historical" },
                {0, 0, "Historical" }
            };

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

        public int RollDice()
        {
            return _percentileDice.RollDie();
        }

        public string LookupType(int rollResult)
        {
            var characteristic = characteristicsTable.Query(rollResult)
                                            .ToList()
                                            .Select(x => x)
                                            .FirstOrDefault();
            return characteristic;
        }

        public Func<IWorldHook> GetSubtype(int rollResult)
        {
            var subtype = worldHookTable.Query(rollResult)
                                        .ToList()
                                        .Select(x => x)
                                        .FirstOrDefault();

            return subtype;
        }

        public string GetCharacteristic()
        {
            var rollResult = RollDice();
            var characteristic = LookupType(rollResult);

            return characteristic;
        }

        public IWorldHook GetWorldHook()
        {
            var rollResult = RollDice();
            var worldHook = GetSubtype(rollResult);

            return worldHook();
        }
    }
}
