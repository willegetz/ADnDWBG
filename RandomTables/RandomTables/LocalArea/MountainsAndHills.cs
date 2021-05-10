using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using IntervalTree;
using RandomTables.BaseClasses;

namespace RandomTables.LocalArea
{
    public class MountainsAndHills : BaseRandomTable
    {
        public IntervalTree<int, string> mountainsAndHillsLookup = new IntervalTree<int, string>()
        {
            {1, 8, "Very Mountainous" },
            {9, 22, "Mountainous" },
            {23, 37, "Rugged Hills" },
            {37, 69, "Gentle Hills" },
            {70, 76, "Tablelands" },
            {77, 99, "Plains" },
            {0, 0, "Plains" }
        };

        public MountainsAndHills() : base(new PercentileDice0and0())
        {
            base.RandomTable = mountainsAndHillsLookup;
        }

        public MountainsAndHills(ISeedGenerator seedGenerator) : base(new PercentileDice0and0(seedGenerator))
        {
            base.RandomTable = mountainsAndHillsLookup;
        }
    }
}
