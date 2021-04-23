﻿using DiceTypes.DieTypes;
using System.Collections.Generic;

namespace RandomTables.WorldHooks
{
    public class ClimateOrLandformsTypes
    {
        private D16 _d16;

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

        public ClimateOrLandformsTypes(int d8seed, int d6seed)
        {
            _d16 = new D16(d8seed, d6seed);
        }

        public int RollDie()
        {
            return _d16.RollDie();
        }

        public string LookupSubtype(int rollResult)
        {
            return climateOrLandforms[rollResult];
        }
    }
}
