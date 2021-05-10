using DiceTypes.DieTypes.Basic;
using DiceTypes.Interfaces;
using RandomTables.BaseClasses.WorldHooks;
using System.Collections.Generic;

namespace RandomTables.ContinentsAndGeography
{
    public class PrevailingWinds : BaseLookupTable
    {
        private Dictionary<int, string> prevailingWindsLookup = new Dictionary<int, string>()
        {
            { 1, "North" },
            { 2, "Northeast" },
            { 3, "East" },
            { 4, "Southeast" },
            { 5, "South" },
            { 6, "Southwest" },
            { 7, "West" },
            { 8, "Northwest" }
        };

        public PrevailingWinds() : base(new D8())
        {
            base.LookupTable = prevailingWindsLookup;
        }
        public PrevailingWinds(ISeedGenerator seedGenerator) : base(new D8(seedGenerator))
        {
            base.LookupTable = prevailingWindsLookup;
        }
    }
