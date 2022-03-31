using SwipesCollectionManagementService.DAL.DBO;
using SwipesCollectionManagementService.DAL.Repo;
using SynConnectDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SwipesCollectionManagementService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private readonly SynConnection _swipesConnection = SynConnection.GetInstance();

        public void CollectSwipes(string IPv4)
        {
            SwipeRepo repo = new SwipeRepo();
            string swipe = _swipesConnection.RetrieveSwipes(IPv4);
            string[] rows = ExtractRows(swipe);
            foreach (var item in rows)
            {
                var components = item.Split(',');
                Swipe newSwipe = GetSwipe(components, IPv4);
                repo.Insert(newSwipe);
            }
        }

        private string[] ExtractRows(string swipe)
        {
            return swipe.Split('\n');
        }

        private Swipe GetSwipe(string[] components, string IPv4)
        {
            return new Swipe
            {
                Id = components[0],
                DateTime = components[1],
                Side = components[2],
                Ip = IPv4
            };
        }
    }
}
