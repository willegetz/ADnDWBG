using DiceTypes.Interfaces;
using System.Collections.Generic;

namespace RandomTables.WorldHooks.Subtypes
{
    public class BaseSubtype
    {
        private IDie die;

        public Dictionary<int, string> subtypeLookup;

        public BaseSubtype(IDie die)
        {
            this.die = die;
        }

        public int RollDie()
        {
            return die.RollDie();
        }

        public string GetCharacteristicSubtype()
        {
            var rollResult = RollDie();
            var subtype = subtypeLookup[rollResult];

            return subtype;
        }
    }
}
