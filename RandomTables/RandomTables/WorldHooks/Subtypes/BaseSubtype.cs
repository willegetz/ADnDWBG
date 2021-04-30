using DiceTypes.Interfaces;

namespace RandomTables.WorldHooks.Subtypes
{
    public class BaseSubtype
    {
        private IDie die;

        public BaseSubtype(IDie die)
        {
            this.die = die;
        }

        internal int RollDie()
        {
            return die.RollDie();
        }
    }
}
