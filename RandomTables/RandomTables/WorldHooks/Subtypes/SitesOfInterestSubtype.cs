using DiceTypes.DieTypes.Basic;
using DiceTypes.Interfaces;
using System.Collections.Generic;

namespace RandomTables.WorldHooks
{
    public class SitesOfInterestSubtype
    {
        private IDie _d8;

        private Dictionary<int, string> sitesOfInterest = new Dictionary<int, string>()
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

        public SitesOfInterestSubtype()
        {
            _d8 = new D8();
        }

        public SitesOfInterestSubtype(ISeedGenerator seedGenerator)
        {
            _d8 = new D8(seedGenerator);
        }

        public int RollDie()
        {
            return _d8.RollDie();
        }

        public string GetCharacteristicSubtype()
        {
            var rollResult = RollDie();
            var subtype = sitesOfInterest[rollResult];

            return subtype;
        }
    }
}
