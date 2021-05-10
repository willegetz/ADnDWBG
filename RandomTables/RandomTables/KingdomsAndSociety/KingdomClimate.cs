using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using IntervalTree;
using RandomTables.BaseClasses;

namespace RandomTables.KingdomsAndSociety
{
    public class KingdomClimate : BaseRandomTable
    {
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

        public KingdomClimate() : base(new PercentileDice0and0())
        {
            base.RandomTable = kingdomClimateLookup;
        }

        public KingdomClimate(ISeedGenerator seedGenerator) : base(new PercentileDice0and0(seedGenerator))
        {
            base.RandomTable = kingdomClimateLookup;
        }
    }
}
