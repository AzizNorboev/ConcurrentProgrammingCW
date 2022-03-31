using SwipesCollectionManagementService.DAL.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwipesCollectionManagementService.Contracts
{
    internal interface ITerminalRepo
    {
        void AddTerminal(Terminal terminal);
        List<Terminal> GetAllTerminals();
    }
}
