using DiceTypes.DieTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTables.WorldHooks.Types
{
    public class ClimateOrLandform
    {
        private string _hookType = "Climate or Landform";
        private ClimateOrLandformsSubType _subtype;

        public ClimateOrLandform(int d8Seed, int d6Seed)
        {
            _subtype = new ClimateOrLandformsSubType(d8Seed, d6Seed);
        }

        public string GetHook()
        {
            var subtype = _subtype.GetCharacteristicSubtype();
            
            return $@"Characteristic: {_hookType}
Subtype: {subtype}";
        }
    }
}
