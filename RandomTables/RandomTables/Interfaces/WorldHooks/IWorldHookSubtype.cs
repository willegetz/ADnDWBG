using System.Collections.Generic;

namespace RandomTables.Interfaces.WorldHooks
{
    public interface IWorldHookSubtype
    {
        Dictionary<int, string> SubtypeLookup { get; set; }
        int RollDie();
        string GetCharacteristicSubtype();
    }
}
