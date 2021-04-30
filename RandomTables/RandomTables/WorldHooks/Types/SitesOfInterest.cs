using DiceTypes.Interfaces;
using RandomTables.WorldHooks.Subtypes;

namespace RandomTables.WorldHooks.Types
{
    public class SitesOfInterest : BaseCharacteristicType
    {
        public SitesOfInterest() : base("Sites of Interest", new SitesOfInterestSubtype())
        {
        }

        public SitesOfInterest(ISeedGenerator seedGenerator): base("Sites of Interest", new SitesOfInterestSubtype(seedGenerator))
        {
        }
    }
}
