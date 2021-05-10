using DiceTypes.Interfaces;
using RandomTables.Interfaces.WorldHooks;
using System.Collections.Generic;

namespace RandomTables.BaseClasses.WorldHooks
{
    public class BaseLookupTable : ILookupTable
    {
        private IDie die;

        public Dictionary<int, string> LookupTable { get; set; }

        public BaseLookupTable(IDie die)
        {
            this.die = die;
        }

        public int RollDie()
        {
            return die.RollDie();
        }

        public string GetLookupTableResult()
        {
            var rollResult = RollDie();
            var subtype = LookupTable[rollResult];

            return subtype;
        }
    }
}
