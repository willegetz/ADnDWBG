using DiceTypes.Interfaces;
using RandomTables.Interfaces.WorldHooks;

namespace RandomTables.WorldHooks.Types
{
    public class ClimateOrLandform : IWorldHook
    {
        public string CharacteristicType { get { return "Climate or Landform"; } }

        public string Subtype { get { return _subtype.GetCharacteristicSubtype(); } }

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
            return $@"Characteristic: {CharacteristicType}
Subtype: {Subtype}";
        }
    }
}
