using DiceTypes.Interfaces;
using RandomTables.BaseClasses.WorldHooks;
using RandomTables.WorldHooks.Subtypes;

namespace RandomTables.WorldHooks.Types
{
    public class ClimateOrLandform : BaseCharacteristicType
    {
        public ClimateOrLandform() : base("Climate or Landform", new ClimateOrLandformSubtype())
        {

        }

        public ClimateOrLandform(ISeedGenerator seedGenerator) : base("Climate or Landform", new ClimateOrLandformSubtype(seedGenerator))
        {

        }
    }
}
