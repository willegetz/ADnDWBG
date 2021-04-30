using DiceTypes.Interfaces;
using RandomTables.Interfaces.WorldHooks;
using RandomTables.WorldHooks.Subtypes;

namespace RandomTables.WorldHooks.Types
{
    public class ClimateOrLandform : BaseCharacteristicType, IWorldHook
    {
        public ClimateOrLandform() : base("Climate or Landform", new ClimateOrLandformSubtype())
        {

        }

        public ClimateOrLandform(ISeedGenerator seedGenerator) : base("Climate or Landform", new ClimateOrLandformSubtype(seedGenerator))
        {

        }
    }
}
