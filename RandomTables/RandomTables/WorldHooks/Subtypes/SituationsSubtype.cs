using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using RandomTables.BaseClasses.WorldHooks;
using System.Collections.Generic;

namespace RandomTables.WorldHooks.Subtypes
{
    public class SituationsSubtype : BaseSubtype
    {
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

        public SituationsSubtype() : base(new D16())
        {
            SubtypeLookup = situations;
        }

        public SituationsSubtype(ISeedGenerator seedGenerator) : base(new D16(seedGenerator))
        {
            SubtypeLookup = situations;
        }
    }
}
