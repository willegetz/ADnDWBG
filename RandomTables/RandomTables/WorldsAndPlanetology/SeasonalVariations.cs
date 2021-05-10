using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using IntervalTree;
using RandomTables.BaseClasses;

namespace RandomTables.WorldsAndPlanetology
{
    public class SeasonalVariations : BaseRandomTable
    {
        public IntervalTree<int, string> seasonalVariationsLookup = new IntervalTree<int, string>()
        {
            {1, 10, "None" },
            {11, 30, "Mild" },
            {31, 75, "Moderate" },
            {76, 90, "Severe" },
            {91, 99, "Exteme" },
            {0, 0, "Extreme" }
        };

        public SeasonalVariations(): base(new PercentileDice0and0())
        {
            base.RandomTable = seasonalVariationsLookup;
        }

        public SeasonalVariations(ISeedGenerator seedGenerator) : base(new PercentileDice0and0(seedGenerator))
        {
            base.RandomTable = seasonalVariationsLookup;
        }
    }
}
