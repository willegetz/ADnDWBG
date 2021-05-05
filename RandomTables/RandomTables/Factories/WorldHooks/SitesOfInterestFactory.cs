using DiceTypes.Interfaces;
using RandomTables.Interfaces.WorldHooks;
using RandomTables.WorldHooks.Types;

namespace RandomTables.Factories.WorldHooks
{
    public class SitesOfInterestFactory : IWorldHookFactory
    {
        public static SitesOfInterest Get()
        {
            return new SitesOfInterest();
        }

        public static IWorldHookFactory GetFactory()
        {
            return new SitesOfInterestFactory();
        }

        public IWorldHook GetWorldHook()
        {
            return new SitesOfInterest();
        }

        public IWorldHook GetWorldHook(ISeedGenerator seedGenerator)
        {
            return new SitesOfInterest(seedGenerator);
        }
    }
}
