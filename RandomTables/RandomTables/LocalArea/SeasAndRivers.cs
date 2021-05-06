using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using IntervalTree;
using System.Linq;

namespace RandomTables.LocalArea
{
    public class SeasAndRivers
    {
        private PercentileDice0and0 _percentileDice;

        public IntervalTree<int, string> seasAndRiversLookup = new IntervalTree<int, string>()
        {
            {1, 10, "Island" },
            {11, 19, "Coastal or Penninsula" },
            {20, 29, "Major Lake" }
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
