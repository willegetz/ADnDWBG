using DiceTypes.Interfaces;
using RandomTables.WorldHooks.Subtypes;

namespace RandomTables.WorldHooks.Types
{
    public class Cultures : BaseCharacteristicType
    {
        public Cultures() : base("Cultures", new CultureSubtype())
        {

        }

        public Cultures(ISeedGenerator seedGenerator) : base("Cultures", new CultureSubtype(seedGenerator))
        {

        }
    }
}
