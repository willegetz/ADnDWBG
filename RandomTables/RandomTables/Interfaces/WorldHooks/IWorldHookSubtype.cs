namespace RandomTables.Interfaces.WorldHooks
{
    public interface IWorldHookSubtype
    {
        string CharacteristicType { get; }
        string GetHook();
    }
}
