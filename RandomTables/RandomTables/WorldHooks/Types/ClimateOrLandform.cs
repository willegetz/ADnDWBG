using DiceTypes;
using DiceTypes.Interfaces;
using RandomTables.Interfaces.WorldHooks;

namespace RandomTables.WorldHooks.Types
{
    public class ClimateOrLandform : IWorldHookSubtype
    {
        public string HookType { get { return "Climate or Landform"; } }
        private ClimateOrLandformSubtype _subtype;

        // TODO: 1. If this took a seeding factory of sorts...
        public ClimateOrLandform(int d8Seed, int d6Seed)
        {
            // TODO: 2. Then this can also take the seeding factory...
            _subtype = new ClimateOrLandformSubtype(d8Seed, d6Seed);
        }

        public ClimateOrLandform(ISeedGenerator seedGenerator)
        {
            _subtype = new ClimateOrLandformSubtype(seedGenerator);
        }

        public string GetHook()
        {
            // need to override the roll result when roll die is called
            var subtype = _subtype.GetCharacteristicSubtype();

            return $@"Characteristic: {HookType}
Subtype: {subtype}";
        }
    }
}
