using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DatingProgram
{
    

    public partial class Form1 : Form
    {

        BL bl = new BL();      
        
        public Form1()
        {
            InitializeComponent();

            userSeekRelationshipStat();
            strangersLocation();
            userSeekGender();
            userPartnerStat();
            usersJobType();
            usersBuisnessBranch();
            usersSmokingStat();
            usersKidsStat();


        }

  

        private void userSeekRelationshipStat()
        {
            cmbBox1Iseek.ValueMember = "Id";
            cmbBox1Iseek.DisplayMember = "RelationshipStatus";
            cmbBox1Iseek.DataSource = bl.userSeeksGender();
        }

         private void strangersLocation()
        {
            cmbBox2InLocation.ValueMember = "Id";
            cmbBox2InLocation.DisplayMember = "Location";
            cmbBox2InLocation.DataSource = bl.strangerLivesIn();

        }

         private void userSeekGender()
         {
             cmbBox3Gender.ValueMember = "Id";
             cmbBox3Gender.DisplayMember = "Gender";
             cmbBox3Gender.DataSource = bl.strangersGenderRequirement();
         }

         private void userPartnerStat()
         {
             cmbBox4PartnerStatus.ValueMember = "Id";
             cmbBox4PartnerStatus.DisplayMember = "UsersStatus";
             cmbBox4PartnerStatus.DataSource = bl.usersPartnerStat();
         }

         private void usersJobType()
         {
             cmbBox5JobType.ValueMember = "Id";
             cmbBox5JobType.DisplayMember = "JobType";
             cmbBox5JobType.DataSource = bl.usersJob();
         }

         private void usersBuisnessBranch()
         {
             cmbBox6Buisness.ValueMember = "Id";
             cmbBox6Buisness.DisplayMember = "Branch";
             cmbBox6Buisness.DataSource = bl.buisnessBranch();
         }


         private void usersSmokingStat()
         {
             cmbBox7Smoking.ValueMember = "Id";
             cmbBox7Smoking.DisplayMember = "SmokingStatus";
             cmbBox7Smoking.DataSource = bl.smokingStat();
         }

         private void usersKidsStat()
         {
             cmbBox8Kids.ValueMember = "Id";
             cmbBox8Kids.DisplayMember = "NumberOfKids"; // wherre Id 1 = 0 kids etc etc-.. 
             cmbBox8Kids.DataSource = bl.usersKidsStat();
         }

         private void btn4Close_Click(object sender, EventArgs e)
         {
             Application.Exit();       
         }





    }



}
