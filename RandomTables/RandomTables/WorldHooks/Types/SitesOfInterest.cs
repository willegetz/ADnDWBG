using RandomTables.Interfaces.WorldHooks;

namespace RandomTables.WorldHooks.Types
{
    public class SitesOfInterest : IWorldHookSubtype
    {
        public string HookType { get { return "Sites of Interest"; } }

        private SitesOfInterestSubtype _subtype;

        public SitesOfInterest(int d8Seed)
        {
            _subtype = new SitesOfInterestSubtype(d8Seed);
        }

        public string GetHook()
        {
            var subtype = _subtype.GetCharacteristicSubtype();

            return $@"Characteristic: {HookType}
Subtype: {subtype}";
        }
    }
}
