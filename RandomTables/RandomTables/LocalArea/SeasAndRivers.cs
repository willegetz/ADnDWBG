using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using IntervalTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTables.LocalArea
{
    public class SeasAndRivers
    {
        private PercentileDice0and0 _percentileDice;

        public IntervalTree<int, string> seasAndRiversLookup = new IntervalTree<int, string>()
        {
            {1, 10, "Island" }
        };

        public SeasAndRivers(ISeedGenerator seedGenerator)
        {
            _percentileDice = new PercentileDice0and0(seedGenerator);
        }

        public string GetLocalAreaDetail()
        {
            var rollResult = _percentileDice.RollDie();
            var result = seasAndRiversLookup.Query(rollResult)
                                            .ToList()
                                            .Select(x => x)
                                            .FirstOrDefault();
            return result;
        }
    }
}
