using RandomTables.Interfaces.WorldHooks;

namespace RandomTables.Interfaces
{
    public interface IFactory
    {
        IWorldHookSubtype Get();
    }
}
