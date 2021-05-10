using DiceTypes.DieTypes.Basic;
using DiceTypes.Interfaces;
using RandomTables.BaseClasses.WorldHooks;
using System.Collections.Generic;

namespace RandomTables.WorldHooks.Subtypes
{
    public class HistoricalSubtype : BaseSubtype
    {
        private Dictionary<int, string> historicalLookup = new Dictionary<int, string>()
        {
            {1, "Ancient warfare" },
            {2, "Artifact" },
            {3, "Balkanization" },
            {4, "Civil war" },
            {5, "Crusade" },
            {6, "Insurrection" },
            {7, "Migration" },
            {8, "Post-apocolyptic" }
        };

        public HistoricalSubtype() : base(new D8())
        {
            SubtypeLookup = historicalLookup;
        }

        public HistoricalSubtype(ISeedGenerator seedGenerator) : base(new D8(seedGenerator))
        {
            SubtypeLookup = historicalLookup;
        }
    }
}
