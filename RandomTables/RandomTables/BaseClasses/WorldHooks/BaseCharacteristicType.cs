using RandomTables.Interfaces.WorldHooks;

namespace RandomTables.BaseClasses.WorldHooks
{
    public class BaseCharacteristicType : IWorldHook
    {
        public string CharacteristicType { get; private set; }

        public string Subtype { get { return _subtype.GetLookupTableResult(); } }

        private ILookupTable _subtype;

        public BaseCharacteristicType(string characteristicType, ILookupTable subtype)
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
