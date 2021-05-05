using DiceTypes.Interfaces;
using RandomTables.Interfaces.WorldHooks;
using RandomTables.WorldHooks.Types;

namespace RandomTables.Factories.WorldHooks
{
    public class SituationsFactory : IWorldHookFactory
    {
        public static IWorldHookFactory GetFactory()
        {
            return new SituationsFactory();
        }

        public IWorldHook GetWorldHook()
        {
            return new Situations();
        }

        public IWorldHook GetWorldHook(ISeedGenerator seedGenerator)
        {
            return new Situations(seedGenerator);
        }
    }
}
