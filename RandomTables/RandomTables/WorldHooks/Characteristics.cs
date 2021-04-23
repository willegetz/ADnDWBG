using DiceTypes.DieTypes;
using IntervalTree;
using System.Linq;

namespace RandomTables.WorldHooks
{
    public class Characteristics
    {
        private PercentileDice0and0 _percentileDice;

        private IntervalTree<int, string> characteristicsTable = new IntervalTree<int, string>()
            {
                {1, 24, "Climate or Landform" },
                {25, 34, "Sites of Interest" },
                {35, 60, "Cultures" },
                {61, 85, "Situation" },
                {86, 99, "Historical" },
                {0, 0, "Historical" }
            };

        public Characteristics(int tensSeed, int onesSeed)
        {
            _percentileDice = new PercentileDice0and0(tensSeed, onesSeed);
        }

        public int RollDice()
        {
            return _percentileDice.RollDice();
        }

        public string LookupType(int rollResult)
        {
            var characteristic = characteristicsTable.Query(rollResult)
                                            .ToList()
                                            .Select(x => x)
                                            .FirstOrDefault();
            return characteristic;
        }
    }
}
