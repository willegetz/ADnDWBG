using RandomTables.Interfaces.WorldHooks;

namespace RandomTables.WorldHooks.Types
{
    public class SitesOfInterest : IWorldHook
    {
        public string CharacteristicType { get { return "Sites of Interest"; } }

        private SitesOfInterestSubtype _subtype;

        public SitesOfInterest(int d8Seed)
        {
            _subtype = new SitesOfInterestSubtype(d8Seed);
        }

        public string GetHook()
        {
            var subtype = _subtype.GetCharacteristicSubtype();

            return $@"Characteristic: {CharacteristicType}
Subtype: {subtype}";
        }
    }
}
