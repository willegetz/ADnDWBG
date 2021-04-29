using DiceTypes.Interfaces;
using RandomTables.Interfaces.WorldHooks;

namespace RandomTables.WorldHooks.Types
{
    public class ClimateOrLandform : IWorldHook
    {
        public string CharacteristicType { get { return "Climate or Landform"; } }

        public ClimateOrLandformSubtype Subtype { get; set; }

        private ClimateOrLandformSubtype _subtype;

        public ClimateOrLandform()
        {
            _subtype = new ClimateOrLandformSubtype();
        }

        public ClimateOrLandform(ISeedGenerator seedGenerator)
        {
            Subtype = new ClimateOrLandformSubtype(seedGenerator);
        }

        public string GetHook()
        {
            var subtype = Subtype.GetCharacteristicSubtype();

            return $@"Characteristic: {CharacteristicType}
Subtype: {subtype}";
        }
    }
}
