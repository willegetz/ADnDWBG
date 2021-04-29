using DiceTypes.DieTypes.Basic;
using System.Collections.Generic;

namespace RandomTables.WorldHooks
{
    public class Cultures
    {
        private D12 _d12;

        private Dictionary<int, string> cultures = new Dictionary<int, string>()
        {
            {1, "African" },
            {2, "Ancient" },
            {3, "Arabian" },
            {4, "Barbarian" },
            {5, "Feudal" },
            {6, "Mercantile" },
            {7, "Native American" },
            {8, "Oriental" },
            {9, "Renaissance" },
            {10, "Post-Renaissance" },
            {11, "Savage/Tribal" },
            {12, "Seafaring" }
        };

        public Cultures(int d12Seed)
        {
            _d12 = new D12(d12Seed);
        }

        public int RollDie()
        {
            return _d12.RollDie();
        }

        public string LookupSubtype(int rollResult)
        {
            return cultures[rollResult];
        }
    }
}
