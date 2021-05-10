using DiceTypes.Interfaces;
using IntervalTree;
using System.Linq;

namespace RandomTables.BaseClasses
{
    public class BaseRandomTable
    {
        private IDie die;

        public IntervalTree<int, string> RandomTable { get; set; }

        public BaseRandomTable(IDie die)
        {
            this.die = die;
        }

        public int RollDie()
        {
            return die.RollDie();
        }

        public string GetRandomTableResult()
        {
            var rollResult = RollDie();
            var result = RandomTable.Query(rollResult)
                                            .ToList()
                                            .Select(x => x)
                                            .FirstOrDefault();
            return result;
        }
    }
}
