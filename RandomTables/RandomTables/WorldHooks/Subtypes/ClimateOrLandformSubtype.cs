using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using System.Collections.Generic;

namespace RandomTables.WorldHooks.Subtypes
{
    public class ClimateOrLandformSubtype : BaseSubtype
    {
        private IDie _d16;

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
            _d16 = new D16();
        }

        public ClimateOrLandformSubtype(ISeedGenerator seedGenerator) : base(new D16(seedGenerator))
        {
            _d16 = new D16(seedGenerator);
        }

        public int RollDie()
        {
            return base.RollDie();
        }

        public string GetCharacteristicSubtype()
        {
            var rollResult = RollDie();
            var subtype = climateOrLandforms[rollResult];

            return subtype;
        }
    }
}
