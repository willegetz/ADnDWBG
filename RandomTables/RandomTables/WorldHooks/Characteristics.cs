using DiceTypes.DieTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTables.WorldHooks
{
    public class Characteristics
    {
        private PercentileDice0and0 _percentileDice;

        public Characteristics(int tensSeed, int onesSeed)
        {
            _percentileDice = new PercentileDice0and0(tensSeed, onesSeed);
        }

        public int RollDice()
        {
            return _percentileDice.RollDice();
        }
    }
}
