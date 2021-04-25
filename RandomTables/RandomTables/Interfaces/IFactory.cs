using RandomTables.Interfaces.WorldHooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTables.Interfaces
{
    public interface IFactory
    {
        IWorldHookSubtype Get();
    }
}
