using RandomTables.Interfaces.WorldHooks;

namespace RandomTables.WorldHooks.Types
{
    public class BaseCharacteristicType : IWorldHook
    {
        public string CharacteristicType { get; private set; }

        public string Subtype { get { return _subtype.GetCharacteristicSubtype(); } }

        private IWorldHookSubtype _subtype;

        public BaseCharacteristicType(string characteristicType, IWorldHookSubtype subtype)
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
