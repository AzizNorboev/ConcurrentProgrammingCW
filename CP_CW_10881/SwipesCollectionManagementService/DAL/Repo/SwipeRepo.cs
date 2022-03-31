using SwipesCollectionManagementService.Contracts;
using SwipesCollectionManagementService.DAL.DBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace SwipesCollectionManagementService.DAL.Repo
{
    public class SwipeRepo : ISwipeRepo   
    {
        private string getAll = @"select Id, DateTime, Side, Ip from Swipes";
        private string create = @"INSERT INTO Swipes (Id, DateTime, Side, Ip) VALUES (@Id, @DateTime, @Side, @Ip)";
        private static string MyConnectionString => WebConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        public void Insert(Swipe swipe)
        {
            using (var connection = new SqlConnection(MyConnectionString))
            {
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = create;
                    cmd.Parameters.AddWithValue("@Id", swipe.Id);
                    cmd.Parameters.AddWithValue("@DateTime", swipe.DateTime);
                    cmd.Parameters.AddWithValue("@Side", swipe.Side);
                    cmd.Parameters.AddWithValue("@Ip", swipe.Ip);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public IList<Swipe> GetAllSwipes()
        {
            IList<Swipe> swipes = new List<Swipe>();

            using (var connection = new SqlConnection(MyConnectionString))
            {
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = getAll;

                    connection.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var swipe = new Swipe
                            {
                                Id = reader.GetString(reader.GetOrdinal("Id")),
                                DateTime = reader.GetString(reader.GetOrdinal("DateTime")),
                                Side = reader.GetString(reader.GetOrdinal("Side")),
                                Ip = reader.GetString(reader.GetOrdinal("Ip"))
                            };
                            swipes.Add(swipe);
                        }
                    }
                }
            }
            return swipes;
        }
    }
}