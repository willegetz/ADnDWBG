using DiceTypes.Interfaces;
using RandomTables.Interfaces.WorldHooks;
using RandomTables.WorldHooks.Types;

namespace RandomTables.Factories.WorldHooks
{
    public class CulturesFactory : IWorldHookFactory
    {
        public static IWorldHookFactory GetFactory()
        {
            return new CulturesFactory();
        }

        public IWorldHook GetWorldHook()
        {
            return new Cultures();
        }

        public IWorldHook GetWorldHook(ISeedGenerator seedGenerator)
        {
            return new Cultures(seedGenerator);
        }
    }
}
