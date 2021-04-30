namespace RandomTables.Interfaces.WorldHooks
{
    public interface IWorldHook
    {
        string CharacteristicType { get; }
        string Subtype { get; }

        string GetHook();
    }
}
