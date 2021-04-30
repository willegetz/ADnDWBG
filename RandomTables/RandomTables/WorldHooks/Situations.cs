using DiceTypes.DieTypes.Complex;
using System.Collections.Generic;

namespace RandomTables.WorldHooks
{
    class Situations
    {
        private D16 _d16;

        private Dictionary<int, string> situations = new Dictionary<int, string>()
        {
            {1, "Class dominance" },
            {2, "Court" },
            {3, "Chivalry" },
            {4, "Deity" },
            {5, "Dying world" },
            {6, "Enemies" },
            {7, "Exploration" },
            {8, "Frontier" },
            {9, "Magical" },
            {10, "New world" },
            {11, "Psionics" },
            {12, "Race dominance" },
            {13, "Religious" },
            {14, "Slavery" },
            {15, "Technology" },
            {16, "Warfare" }
        };

        public Situations(int d8seed, int d6seed)
        {
            _d16 = new D16();
        }

        public int RollDie()
        {
            return _d16.RollDie();
        }

        public string LookupSubtype(int rollResult)
        {
            return situations[rollResult];
        }
    }
}
