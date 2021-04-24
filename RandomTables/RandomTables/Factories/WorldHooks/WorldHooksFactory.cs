using RandomTables.WorldHooks;
using System;

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
