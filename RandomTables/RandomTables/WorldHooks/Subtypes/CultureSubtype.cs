using DiceTypes.DieTypes.Basic;
using DiceTypes.Interfaces;
using System.Collections.Generic;

namespace RandomTables.WorldHooks.Subtypes
{
    public class CultureSubtype : BaseSubtype
    {
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

        public CultureSubtype(): base(new D12())
        {
            base.subtypeLookup = cultures;
        }

        public CultureSubtype(ISeedGenerator seedGenerator) : base(new D12(seedGenerator))
        {
            base.subtypeLookup = cultures;
        }
    }
}
