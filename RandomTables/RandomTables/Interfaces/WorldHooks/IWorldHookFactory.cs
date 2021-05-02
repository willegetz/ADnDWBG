using DiceTypes.Interfaces;

namespace RandomTables.Interfaces.WorldHooks
{
    public interface IWorldHookFactory
    {
        IWorldHook GetWorldHook();
        IWorldHook GetWorldHook(ISeedGenerator seedGenerator);
    }
}
