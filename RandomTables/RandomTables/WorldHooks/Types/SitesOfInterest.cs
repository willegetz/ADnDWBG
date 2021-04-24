using RandomTables.Interfaces.WorldHooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTables.WorldHooks.Types
{
    public class SitesOfInterest : IWorldHookSubtype
    {
        private string _hookType = "Sites of Interest";
        private SitesOfInterestSubtype _subtype;

        public SitesOfInterest(int d8Seed)
        {
            _subtype = new SitesOfInterestSubtype(d8Seed);
        }

        public string GetHook()
        {
            var subtype = _subtype.GetCharacteristicSubtype();

            return $@"Characteristic: {_hookType}
Subtype: {subtype}";
        }
    }
}
