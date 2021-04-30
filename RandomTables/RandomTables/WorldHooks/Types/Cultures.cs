using DiceTypes.Interfaces;
using RandomTables.Interfaces.WorldHooks;
using RandomTables.WorldHooks.Subtypes;

namespace RandomTables.WorldHooks.Types
{
    public class Cultures : IWorldHook
    {
        public string CharacteristicType { get { return "Cultures"; } }

        public string Subtype { get { return _subtype.GetCharacteristicSubtype(); } }

        private CultureSubtype _subtype;

        public Cultures()
        {
            _subtype = new CultureSubtype();
        }

        public Cultures(ISeedGenerator seedGenerator)
        {
            _subtype = new CultureSubtype(seedGenerator);
        }

        public string GetHook()
        {
            return $@"Characteristic: {CharacteristicType}
Subtype: {Subtype}";
        }
    }
}
