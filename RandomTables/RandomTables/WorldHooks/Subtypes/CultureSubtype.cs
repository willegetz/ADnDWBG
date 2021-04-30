using DiceTypes.DieTypes.Basic;
using DiceTypes.Interfaces;
using System.Collections.Generic;

namespace RandomTables.WorldHooks.Subtypes
{
    public class CultureSubtype
    {
        private IDie _d12;

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

        public CultureSubtype()
        {
            _d12 = new D12();
        }

        public CultureSubtype(ISeedGenerator seedGenerator)
        {
            _d12 = new D12(seedGenerator);
        }

        public int RollDie()
        {
            return _d12.RollDie();
        }

        public string GetCharacteristicSubtype()
        {
            var rollResult = RollDie();
            var subtype = cultures[rollResult];

            return subtype;
        }
    }
}
