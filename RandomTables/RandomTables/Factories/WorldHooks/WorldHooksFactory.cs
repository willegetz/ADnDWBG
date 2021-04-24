using DiceTypes.DieTypes;
using RandomTables.WorldHooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTables.Factories.WorldHooks
{
    public class WorldHooksFactory
    {
        public static Characteristics Get()
        {
            var tensSeed = Guid.NewGuid().GetHashCode();
            var onesSeed = Guid.NewGuid().GetHashCode();

            return new Characteristics(tensSeed, onesSeed);
        }
    }
}
