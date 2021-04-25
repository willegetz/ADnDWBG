using RandomTables.Interfaces.WorldHooks;

namespace RandomTables.WorldHooks.Types
{
    public class ClimateOrLandform : IWorldHookSubtype
    {
        public string HookType { get { return "Climate or Landform"; } }
        private ClimateOrLandformSubtype _subtype;

        public ClimateOrLandform(int d8Seed, int d6Seed)
        {
            _subtype = new ClimateOrLandformSubtype(d8Seed, d6Seed);
        }

        public string GetHook()
        {
            var subtype = _subtype.GetCharacteristicSubtype();

            return $@"Characteristic: {HookType}
Subtype: {subtype}";
        }
    }
}
