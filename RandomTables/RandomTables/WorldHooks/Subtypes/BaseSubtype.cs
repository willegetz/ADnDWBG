using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTables.WorldHooks.Subtypes
{
    public class BaseSubtype
    {
        private IDie die;

        public BaseSubtype(IDie die)
        {
            this.die = die;
        }

        internal int RollDie()
        {
            return die.RollDie();
        }
    }
}
