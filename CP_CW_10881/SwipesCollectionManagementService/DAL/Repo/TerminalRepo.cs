using SwipesCollectionManagementService.Contracts;
using SwipesCollectionManagementService.DAL.DBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwipesCollectionManagementService.DAL.Repo
{
    public class TerminalRepo : ITerminalRepo
    {
        //Singleton implemented
        private static TerminalRepo _instance = null;

        private static readonly List<Terminal> Terminals = new List<Terminal>();
        private TerminalRepo() 
        { }

        public static TerminalRepo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TerminalRepo();
                }
                return _instance;
            }
        }

        public List<Terminal> GetAllTerminals()
        {
            return Terminals;
        }

        public void AddTerminal(Terminal terminal)
        {
            Terminals.Add(terminal);
        }
    }
}