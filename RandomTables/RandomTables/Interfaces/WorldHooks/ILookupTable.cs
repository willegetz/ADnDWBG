using System.Collections.Generic;

namespace RandomTables.Interfaces.WorldHooks
{
    public interface ILookupTable
    {
        Dictionary<int, string> LookupTable { get; set; }
        int RollDie();
        string GetLookupTableResult();
    }
}
