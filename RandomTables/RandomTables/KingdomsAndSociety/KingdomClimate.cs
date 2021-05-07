using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using IntervalTree;
using System.Linq;

namespace RandomTables.KingdomsAndSociety
{
    public class KingdomClimate
    {
        private PercentileDice0and0 _percentileDice;

        public IntervalTree<int, string> kingdomClimateLookup = new IntervalTree<int, string>()
        {
            {1, 1, "Super-arctic" },
            {2, 6, "Arctic" },
            {7, 25, "Sub-arctic" },
            {26, 60, "Temperate" },
            {61, 80, "Sub-tropical" },
            {81, 97, "Tropical" },
            {98, 99, "Super-tropical" },
            {0, 0, "Super-tropical" }
        };

        public KingdomClimate()
        {
            _percentileDice = new PercentileDice0and0();
        }

        public KingdomClimate(ISeedGenerator seedGenerator)
        {
            _percentileDice = new PercentileDice0and0(seedGenerator);
        }

        public string GetLocalAreaDetail()
        {
            var rollResult = _percentileDice.RollDie();
            var result = kingdomClimateLookup.Query(rollResult)
                                                .ToList()
                                                .Select(x => x)
                                                .FirstOrDefault();
            return result;
        }
    }
}
