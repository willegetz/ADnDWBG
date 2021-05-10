using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using IntervalTree;
using RandomTables.BaseClasses;
using System.Linq;

namespace RandomTables.LocalArea
{
    public class SeasAndRivers : BaseRandomTable
    {
        public IntervalTree<int, string> seasAndRiversLookup = new IntervalTree<int, string>()
        {
            {1, 10, "Island" },
            {11, 19, "Coastal or Penninsula" },
            {20, 29, "Major Lake" },
            {30, 45, "Major River" },
            {46, 70, "Minor Lakes and Rivers" },
            {71, 99, "No Significant Water" },
            {0, 0, "No Significant Water" }
        };

        public SeasAndRivers() : base(new PercentileDice0and0())
        {
            base.RandomTable = seasAndRiversLookup;
        }

        public SeasAndRivers(ISeedGenerator seedGenerator) : base(new PercentileDice0and0(seedGenerator))
        {
            base.RandomTable = seasAndRiversLookup;
        }
    }
}
