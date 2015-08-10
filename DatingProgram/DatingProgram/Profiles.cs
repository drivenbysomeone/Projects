using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace DatingProgram
{
    class Profiles
    {
        public int ProfileId { get; set; }
        public string UserName { get; set; }
        public string EmailAdress { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ZipCode { get; set; }
        public int PartnerStatId { get; set; }
        public int Kids { get; set; }
        public int JobTitleId { get; set; }
        public int EducationId { get; set; }
        public int SmokingStatId { get; set; }
        public int SexId { get; set; }
        public int ISeekId { get; set; }
        public int LivesInId { get; set; }
        public int IseekAgeFrom { get; set; }
        public int ISeekAgeTo { get; set; }
        public int ISeekSmokingStatId { get; set; }
        public string AboutMeHeadLine { get; set; }
        public string AboutMeText { get; set; }
        public string ISeekText { get; set; }
        public Image ProfileImage { get; set; } //add Using.System.Drawing;
        

    }

}
