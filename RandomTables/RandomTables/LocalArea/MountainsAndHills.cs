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
    public class MountainsAndHills
    {
        private PercentileDice0and0 _percentileDice;

        public IntervalTree<int, string> mountainsAndHillsLookup = new IntervalTree<int, string>()
        {
            {1, 8, "Very Mountainous" },
            {9, 22, "Mountainous" }
        };

        public MountainsAndHills()
        {
            _percentileDice = new PercentileDice0and0();
        }

        public MountainsAndHills(ISeedGenerator seedGenerator)
        {
            _percentileDice = new PercentileDice0and0(seedGenerator);
        }

        public string GetLocalAreaDetail()
        {
            var rollResult = _percentileDice.RollDie();
            var result = mountainsAndHillsLookup.Query(rollResult)
                                                .ToList()
                                                .Select(x => x)
                                                .FirstOrDefault();
            return result;
        }
    }
}
