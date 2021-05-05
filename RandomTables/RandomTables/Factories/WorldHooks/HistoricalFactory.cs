using DiceTypes.Interfaces;
using RandomTables.Interfaces.WorldHooks;
using RandomTables.WorldHooks.Types;

namespace RandomTables.Factories.WorldHooks
{
    public class HistoricalFactory : IWorldHookFactory
    {
        public static Historical Get()
        {
            return new Historical();
        }

        public static IWorldHookFactory GetFactory()
        {
            return new HistoricalFactory();
        }

        public IWorldHook GetWorldHook()
        {
            return new Historical();
        }

        public IWorldHook GetWorldHook(ISeedGenerator seedGenerator)
        {
            return new Historical(seedGenerator);
        }
    }
}
