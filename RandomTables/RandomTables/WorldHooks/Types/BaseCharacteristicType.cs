using RandomTables.Interfaces.WorldHooks;
using RandomTables.WorldHooks.Subtypes;

namespace RandomTables.WorldHooks.Types
{
    public class BaseCharacteristicType : IWorldHook
    {
        public string CharacteristicType { get; private set; }

        public string Subtype { get { return _subtype.GetCharacteristicSubtype(); } }

        private ClimateOrLandformSubtype _subtype;

        public BaseCharacteristicType(string characteristicType, ClimateOrLandformSubtype subtype)
        {
            CharacteristicType = characteristicType;
            _subtype = subtype;
        }

        public string GetHook()
        {
            return $@"Characteristic: {CharacteristicType}
Subtype: {Subtype}";
        }
    }
}
