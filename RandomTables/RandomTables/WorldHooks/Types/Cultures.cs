using DiceTypes.Interfaces;
using RandomTables.BaseClasses.WorldHooks;
using RandomTables.WorldHooks.Subtypes;

namespace RandomTables.WorldHooks.Types
{
    public class Cultures : BaseCharacteristicType
    {
        public Cultures() : base("Cultures", new CulturesSubtype())
        {

        }

        public Cultures(ISeedGenerator seedGenerator) : base("Cultures", new CulturesSubtype(seedGenerator))
        {

        }
    }
}
