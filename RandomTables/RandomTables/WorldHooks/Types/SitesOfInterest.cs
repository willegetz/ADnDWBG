using DiceTypes.Interfaces;
using RandomTables.Interfaces.WorldHooks;
using RandomTables.WorldHooks.Subtypes;

namespace RandomTables.WorldHooks.Types
{
    public class SitesOfInterest : BaseCharacteristicType, IWorldHook
    {
        public string CharacteristicType { get { return "Sites of Interest"; } }

        public string Subtype { get { return _subtype.GetCharacteristicSubtype(); } }

        private SitesOfInterestSubtype _subtype;

        public SitesOfInterest() : base("Sites of Interest", new SitesOfInterestSubtype())
        {
            _subtype = new SitesOfInterestSubtype();
        }

        public SitesOfInterest(ISeedGenerator seedGenerator): base("Sites of Interest", new SitesOfInterestSubtype(seedGenerator))
        {
            _subtype = new SitesOfInterestSubtype(seedGenerator);
        }

        public string GetHook()
        {
            var subtype = _subtype.GetCharacteristicSubtype();

            return $@"Characteristic: {CharacteristicType}
Subtype: {subtype}";
        }
    }
}
