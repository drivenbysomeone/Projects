using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace DatingProgram
{
    class BL
    {

        Dal dal = new Dal();

        internal List<RelationshipStat> userSeeksGender()
        {
            DataTable dt = dal.GetUserSeekRelationship();
            var l1 = new List<RelationshipStat>();

            foreach (DataRow item in dt.Rows)
            {
                var relationship = new RelationshipStat();

                relationship.Id = Convert.ToInt32(item["ISeekId"].ToString());
                relationship.RelationshipStatus = item["ISeekText"].ToString();
                l1.Add(relationship);

            }
            return l1;
        }

        internal List<StrangersLocation> strangerLivesIn()
        {
            DataTable dt = dal.GetStrangerLivesInLocation();
            var l1 = new List<StrangersLocation>();

            foreach (DataRow item in dt.Rows)
            {
                var location = new StrangersLocation();

                location.Id = Convert.ToInt32(item["LivesInId"].ToString());
                location.Location = item["LivesInText"].ToString();
                l1.Add(location);

            }
            return l1;
            

        }

        internal List<StrangersGender> strangersGenderRequirement()
        {
            DataTable dt = dal.GetStrangersGender();
            var l1 = new List<StrangersGender>();

            foreach (DataRow item in dt.Rows)
            {
                var gender = new StrangersGender();

                gender.Id = Convert.ToInt32(item["SexId"].ToString());
                gender.Gender = item["SexText"].ToString();
                l1.Add(gender);
                
            }
            return l1;

        }

        internal List<UsersRelationshipStat> usersPartnerStat()
        {
            DataTable dt = dal.GetUsersPartnerStatus();
            var l1 = new List<UsersRelationshipStat>();

            foreach (DataRow item in dt.Rows)
            {
                var partnerStatus = new UsersRelationshipStat();

                partnerStatus.Id = Convert.ToInt32(item["PartnerStatId"].ToString());
                partnerStatus.UsersStatus = item["PartnerStatText"].ToString();
                l1.Add(partnerStatus);
            }
            return l1;

        }

        internal List<UsersJobType> usersJob()
        {
            DataTable dt = dal.GetUsersJobType();
            var l1 = new List<UsersJobType>();

            foreach (DataRow item in dt.Rows)
            {
                var jobType = new UsersJobType();

                jobType.Id = Convert.ToInt32(item["JobTypeId"].ToString());
                jobType.JobType = item["JobTypeText"].ToString();

                l1.Add(jobType);
    
            }

            return l1;
        }

        internal List<BuisnessBranch> buisnessBranch()
        {
            DataTable dt = dal.GetBuisnessBranch();
            var l1 = new List<BuisnessBranch>();

            foreach (DataRow item in dt.Rows)
            {
                var branch = new BuisnessBranch();

                branch.Id = Convert.ToInt32(item["BranchId"].ToString());
                branch.Branch = item["BranchText"].ToString();
                l1.Add(branch);

            }
            return l1;

        }

        internal List<UsersSmokingStat> smokingStat()
        {
            DataTable dt = dal.GetUsersSmokingStat();
            var l1 = new List<UsersSmokingStat>();

            foreach (DataRow item in dt.Rows)
            {
                var smokingStatus = new UsersSmokingStat();

                smokingStatus.Id = Convert.ToInt32(item["SmokingStatId"].ToString());
                smokingStatus.SmokingStatus = item["SmokingStatText"].ToString();
                l1.Add(smokingStatus);

            }
            return l1;

        }

        internal List<UsersKidsStat> usersKidsStat()
        {
            DataTable dt = dal.GetUsersKidsStat();
            var l1 = new List<UsersKidsStat>();

            foreach (DataRow item in dt.Rows)
            {
                var kidsAmount = new UsersKidsStat();

                kidsAmount.Id = Convert.ToInt32(item["KidsId"].ToString());
                kidsAmount.NumberOfKids = Convert.ToInt32(item["KidsAmount"].ToString());
                l1.Add(kidsAmount);
            }
            return l1;

        }

        internal Usernames FindUsername(string username)
        {
            DataTable dt = dal.GetAllProfileUsernames(username);
            var userName = new Usernames();
            foreach (DataRow item in dt.Rows)
            {
                userName.UsernameId = Convert.ToInt32(item["UsernameId"].ToString());
                userName.Username = item["Username"].ToString();

            }
            return userName;
            
        }

   
    }
}
