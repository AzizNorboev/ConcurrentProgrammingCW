using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwipesCollectionManagementService.DAL.DBO
{
    public class Terminal
    {
        public string Ip { get; set; }
        public string Status { get; set; }

        public Terminal(string ip, string status)
        {
            Ip = ip;
            Status = status;
        }
    }
}