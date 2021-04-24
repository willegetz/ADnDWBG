using DiceTypes.DieTypes;
using RandomTables.Factories;
using RandomTables.Interfaces.WorldHooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTables.WorldHooks.Types
{
    public class ClimateOrLandform : IWorldHookSubtype
    {
        private string _hookType = "Climate or Landform";
        private ClimateOrLandformSubtype _subtype;

        public ClimateOrLandform(int d8Seed, int d6Seed)
        {
            _subtype = new ClimateOrLandformSubtype(d8Seed, d6Seed);
        }

        public string GetHook()
        {
            var subtype = _subtype.GetCharacteristicSubtype();

            return $@"Characteristic: {_hookType}
Subtype: {subtype}";
        }
    }
}
