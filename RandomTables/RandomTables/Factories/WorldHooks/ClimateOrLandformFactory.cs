using RandomTables.WorldHooks.Types;
using System;

namespace RandomTables.Factories.WorldHooks
{
    public class ClimateOrLandformFactory
    {
        public static ClimateOrLandform Get()
        {
            var d8Seed = Guid.NewGuid().GetHashCode();
            var d6Seed = Guid.NewGuid().GetHashCode();

            return new ClimateOrLandform(d8Seed, d6Seed);
        }
    }
}
