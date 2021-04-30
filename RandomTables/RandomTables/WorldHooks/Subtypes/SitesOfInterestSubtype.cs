using DiceTypes.DieTypes.Basic;
using DiceTypes.Interfaces;
using System.Collections.Generic;

namespace RandomTables.WorldHooks.Subtypes
{
    public class SitesOfInterestSubtype : BaseSubtype
    {
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

        public SitesOfInterestSubtype() : base(new D8())
        {
            base.SubtypeLookup = sitesOfInterest;
        }

        public SitesOfInterestSubtype(ISeedGenerator seedGenerator) : base(new D8(seedGenerator))
        {
            base.SubtypeLookup = sitesOfInterest;
        }
    }
}
