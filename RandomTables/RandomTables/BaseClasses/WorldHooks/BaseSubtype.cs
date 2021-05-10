using DiceTypes.Interfaces;
using RandomTables.Interfaces.WorldHooks;
using System.Collections.Generic;

namespace RandomTables.BaseClasses.WorldHooks
{
    public class BaseSubtype : IWorldHookSubtype
    {
        private IDie die;

        public Dictionary<int, string> SubtypeLookup { get; set; }

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
            var subtype = SubtypeLookup[rollResult];

            return subtype;
        }
    }
}
