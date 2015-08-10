using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DatingProgram
{
    class Dal
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;

        public DataTable GetData(string sql)

        {
            DataTable dt = new DataTable();
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
            
        }

        internal DataTable GetUserSeekRelationship()
        {
            string queryString = "SELECT * FROM ISeek";
            return GetData(queryString);
        }

        internal DataTable GetStrangerLivesInLocation()
        {
            string queryString = "SELECT * FROM LivesIn";
            return GetData(queryString);
               
        }

        internal DataTable GetStrangersGender()

       {
            string queryString = "SELECT * FROM Sex";
            return GetData(queryString);
       }

        internal DataTable GetUsersPartnerStatus()
        {
            string queryString = "SELECT * FROM PartnerStat";
            return GetData(queryString);

        }

        internal DataTable GetUsersJobType()
        {
            string queryString = "SELECT * FROM JobType";
            return GetData(queryString);

        }

        internal DataTable GetBuisnessBranch()
        {
            string queryString = "SELECT * FROM Branch";
            return GetData(queryString);

        }

        internal DataTable GetUsersSmokingStat()
        {
            string queryString = "SELECT * FROM SmokingStat";
            return GetData(queryString);
        }

        internal DataTable GetUsersKidsStat()
        {
            string queryString = "SELECT * FROM KidsStat";
            return GetData(queryString);

        }

        
        internal DataTable GetAllProfileUsernames(string username)
        {
            string queryString = "SELECT * FROM Profiles WHERE Profiles.Username = " + username;
            return GetData(queryString);
        }
    }
}
