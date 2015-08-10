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
 
    public partial class LoginForm2 : Form
    {
        BL bl = new BL();

        
        public LoginForm2()
        {
            InitializeComponent();

           
        }

        

        public void btn1Login_Click(object sender, EventArgs e)
        {
            
            if(txtBox1Username.Text = )
 
            //check if botth statements are true ex:
            //if(txtBoxUsername.text == loginUsernameFromDB && txtBoxPassword == loginPasswordFromDB)
            //{
                


            //}

                //    -->  TODO ALSO check if username.Id & passwordId Match!!

            //TODO - if false
            //Else - show messagebox and try again!

            //TODO - if successfull
            // if all conditions are true - do the following: 
            Form1 f1 = new Form1();
            Hide();  // this DOESN'T change the primary form!
            f1.Show();
          
            
        }

        
        
   
    }

    
}
