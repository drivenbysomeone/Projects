namespace DatingProgram
{
    partial class LoginForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1Login = new System.Windows.Forms.Button();
            this.btn2LostPassword = new System.Windows.Forms.Button();
            this.btn3NewProfile = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtBox1Username = new System.Windows.Forms.TextBox();
            this.txtBox2Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1Login
            // 
            this.btn1Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn1Login.Location = new System.Drawing.Point(105, 196);
            this.btn1Login.Name = "btn1Login";
            this.btn1Login.Size = new System.Drawing.Size(82, 23);
            this.btn1Login.TabIndex = 0;
            this.btn1Login.Text = "Log ind";
            this.btn1Login.UseVisualStyleBackColor = false;
            this.btn1Login.Click += new System.EventHandler(this.btn1Login_Click);
            // 
            // btn2LostPassword
            // 
            this.btn2LostPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn2LostPassword.Location = new System.Drawing.Point(105, 236);
            this.btn2LostPassword.Name = "btn2LostPassword";
            this.btn2LostPassword.Size = new System.Drawing.Size(82, 23);
            this.btn2LostPassword.TabIndex = 1;
            this.btn2LostPassword.Text = "Glemt kodeord";
            this.btn2LostPassword.UseVisualStyleBackColor = false;
            // 
            // btn3NewProfile
            // 
            this.btn3NewProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn3NewProfile.Location = new System.Drawing.Point(105, 265);
            this.btn3NewProfile.Name = "btn3NewProfile";
            this.btn3NewProfile.Size = new System.Drawing.Size(82, 23);
            this.btn3NewProfile.TabIndex = 2;
            this.btn3NewProfile.Text = "Opret ny profil";
            this.btn3NewProfile.UseVisualStyleBackColor = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(26, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(59, 16);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Log ind";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(26, 70);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(77, 16);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Brugernavn";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(29, 118);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(94, 16);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Adgangskode";
            // 
            // txtBox1Username
            // 
            this.txtBox1Username.Location = new System.Drawing.Point(32, 89);
            this.txtBox1Username.Name = "txtBox1Username";
            this.txtBox1Username.Size = new System.Drawing.Size(155, 20);
            this.txtBox1Username.TabIndex = 7;
            // 
            // txtBox2Password
            // 
            this.txtBox2Password.Location = new System.Drawing.Point(32, 137);
            this.txtBox2Password.Name = "txtBox2Password";
            this.txtBox2Password.Size = new System.Drawing.Size(155, 20);
            this.txtBox2Password.TabIndex = 8;
            // 
            // LoginForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(288, 309);
            this.Controls.Add(this.txtBox2Password);
            this.Controls.Add(this.txtBox1Username);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn3NewProfile);
            this.Controls.Add(this.btn2LostPassword);
            this.Controls.Add(this.btn1Login);
            this.Name = "LoginForm2";
            this.Text = "Dating Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1Login;
        private System.Windows.Forms.Button btn2LostPassword;
        private System.Windows.Forms.Button btn3NewProfile;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtBox1Username;
        private System.Windows.Forms.TextBox txtBox2Password;
    }
}