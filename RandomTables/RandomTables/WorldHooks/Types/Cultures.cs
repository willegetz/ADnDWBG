using RandomTables.Interfaces.WorldHooks;

namespace RandomTables.WorldHooks.Types
{
    public class Cultures : IWorldHook
    {
        public string CharacteristicType { get { return "Cultures"; } }

        public string GetHook()
        {
            return "";
        }
    }
}
