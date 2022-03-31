using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwipesCollectionManagementService.DAL.DBO
{
    public class Swipe
    {
        public string Id { get; set; }
        public string DateTime { get; set; }
        public string Side { get; set; }
        public string Ip { get; set; }
    }
}