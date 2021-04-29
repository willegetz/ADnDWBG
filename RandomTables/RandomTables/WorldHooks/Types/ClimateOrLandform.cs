using DiceTypes.Interfaces;
using RandomTables.Interfaces.WorldHooks;

namespace RandomTables.WorldHooks.Types
{
    public class ClimateOrLandform : IWorldHookSubtype
    {
        public string CharacteristicType { get { return "Climate or Landform"; } }

        private ClimateOrLandformSubtype _subtype;

        public ClimateOrLandform()
        {
            _subtype = new ClimateOrLandformSubtype();
        }

        public ClimateOrLandform(ISeedGenerator seedGenerator)
        {
            _subtype = new ClimateOrLandformSubtype(seedGenerator);
        }

        public string GetHook()
        {
            var subtype = _subtype.GetCharacteristicSubtype();

            return $@"Characteristic: {CharacteristicType}
Subtype: {subtype}";
        }
    }
}
