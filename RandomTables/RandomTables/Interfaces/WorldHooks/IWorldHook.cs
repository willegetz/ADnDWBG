namespace RandomTables.Interfaces.WorldHooks
{
    public interface IWorldHook
    {
        string CharacteristicType { get; }
        string GetHook();
    }
}
