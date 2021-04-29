using DiceTypes.DieTypes.Basic;
using System.Collections.Generic;

namespace RandomTables.WorldHooks
{
    class Historical
    {
        private D8 _d8;

        private Dictionary<int, string> historical = new Dictionary<int, string>()
        {
            {1, "Ancient warfare" },
            {2, "Arifact" },
            {3, "Balkanization" },
            {4, "Civil war" },
            {5, "Crusade" },
            {6, "Insurrection" },
            {7, "Migration" },
            {8, "Post-apocolyptic" }
        };

        public Historical(int d8seed)
        {
            _d8 = new D8(d8seed);
        }

        public int RollDie()
        {
            return _d8.RollDie();
        }

        public string LookupSubtype(int rollResult)
        {
            return historical[rollResult];
        }
    }
}
