using DiceTypes;
using System.Collections.Generic;

namespace RandomTables.WorldHooks
{
    public class SitesOfInterest
    {
        private Die _d8;

        private Dictionary<int, string> climateOrLandforms = new Dictionary<int, string>()
        {
            {1, "Caverns" },
            {2, "Cities" },
            {3, "Dungeons" },
            {4, "Extraplanar" },
            {5, "Fortress/strongholds" },
            {6, "Ruins" },
            {7, "Shrines" },
            {8, "Wilderness" }
        };

        public SitesOfInterest(int d8seed)
        {
            _d8 = new Die(8, d8seed);
        }

        public int RollDie()
        {
            return _d8.RollDie();
        }

        public string LookupSubtype(int rollResult)
        {
            return climateOrLandforms[rollResult];
        }
    }
}
