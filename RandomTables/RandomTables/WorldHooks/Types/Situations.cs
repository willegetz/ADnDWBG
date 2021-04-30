using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using RandomTables.WorldHooks.Subtypes;

namespace RandomTables.WorldHooks.Types
{
    public class Situations : BaseCharacteristicType
    {
        public Situations() : base("Situation", new SituationsSubtype())
        {

        }

        public Situations(ISeedGenerator seedGenerator): base("Situation", new SituationsSubtype(seedGenerator))
        {
        }
    }
}
