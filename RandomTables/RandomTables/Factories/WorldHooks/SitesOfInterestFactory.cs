using RandomTables.WorldHooks.Types;
using System;

namespace RandomTables.Factories.WorldHooks
{
    public class SitesOfInterestFactory
    {
        public static SitesOfInterest Get()
        {
            var d8Seed = Guid.NewGuid().GetHashCode();

            return new SitesOfInterest(d8Seed);
        }
    }
}
