namespace RandomTables.Interfaces.WorldHooks
{
    public interface IWorldHookSubtype
    {
        string HookType { get; }
        string GetHook();
    }
}
