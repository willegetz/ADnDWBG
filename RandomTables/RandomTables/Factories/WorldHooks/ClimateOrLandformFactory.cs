using DiceTypes.Interfaces;
using RandomTables.Interfaces.WorldHooks;
using RandomTables.WorldHooks.Types;

namespace RandomTables.Factories.WorldHooks
{
    public class ClimateOrLandformFactory : IWorldHookFactory
    {
        public static IWorldHookFactory GetFactory()
        {
            return new ClimateOrLandformFactory();
        }

        public IWorldHook GetWorldHook()
        {
            return new ClimateOrLandform();
        }

        public IWorldHook GetWorldHook(ISeedGenerator seedGenerator)
        {
            return new ClimateOrLandform(seedGenerator);
        }
    }
}
