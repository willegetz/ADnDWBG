using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using RandomTables.BaseClasses.WorldHooks;
using System.Collections.Generic;

namespace RandomTables.WorldHooks.Subtypes
{
    public class ClimateOrLandformSubtype : BaseLookupTable
    {
        private Dictionary<int, string> climateOrLandforms = new Dictionary<int, string>()
        {
            {1, "Aerial" },
            {2, "Archipelago" },
            {3, "Arctic" },
            {4, "Desert" },
            {5, "Forest" },
            {6, "Inland sea/lake" },
            {7, "Jungle" },
            {8, "Mountain" },
            {9, "Oceanic" },
            {10, "Plains/steppes" },
            {11, "Subterranean" },
            {12, "Swamp" },
            {13, "Uninhabitable" },
            {14, "Unstable/formless" },
            {15, "Volcanic" },
            {16, "Weather" }
        };

        public ClimateOrLandformSubtype() : base(new D16())
        {
            base.LookupTable = climateOrLandforms;
        }

        public ClimateOrLandformSubtype(ISeedGenerator seedGenerator) : base(new D16(seedGenerator))
        {
            base.LookupTable = climateOrLandforms;
        }
    }
}
