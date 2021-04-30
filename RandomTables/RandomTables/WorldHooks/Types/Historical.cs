using DiceTypes.Interfaces;
using RandomTables.WorldHooks.Subtypes;

namespace RandomTables.WorldHooks.Types
{
    public class Historical : BaseCharacteristicType
    {
        public Historical() : base("Historical", new HistoricalSubtype())
        {

        }

        public Historical(ISeedGenerator seedGenerator) : base("Historical", new HistoricalSubtype(seedGenerator))
        {

        }
    }
}
