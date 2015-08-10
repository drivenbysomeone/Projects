namespace ParkingLotProgram
{
    partial class Form1
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
            this.btnStandard = new System.Windows.Forms.Button();
            this.btnEventRate = new System.Windows.Forms.Button();
            this.txtBoxHoursParked = new System.Windows.Forms.TextBox();
            this.txtBoxFee = new System.Windows.Forms.TextBox();
            this.lblHoursParked = new System.Windows.Forms.Label();
            this.LblFee = new System.Windows.Forms.Label();
            this.RdbtnCar = new System.Windows.Forms.RadioButton();
            this.RdbtnTruck = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnStandard
            // 
            this.btnStandard.Location = new System.Drawing.Point(103, 189);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(75, 23);
            this.btnStandard.TabIndex = 0;
            this.btnStandard.Text = "Standard";
            this.btnStandard.UseVisualStyleBackColor = true;
            // 
            // btnEventRate
            // 
            this.btnEventRate.Location = new System.Drawing.Point(103, 218);
            this.btnEventRate.Name = "btnEventRate";
            this.btnEventRate.Size = new System.Drawing.Size(75, 23);
            this.btnEventRate.TabIndex = 1;
            this.btnEventRate.Text = "button2";
            this.btnEventRate.UseVisualStyleBackColor = true;
            // 
            // txtBoxHoursParked
            // 
            this.txtBoxHoursParked.Location = new System.Drawing.Point(23, 99);
            this.txtBoxHoursParked.Name = "txtBoxHoursParked";
            this.txtBoxHoursParked.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHoursParked.TabIndex = 2;
            // 
            // txtBoxFee
            // 
            this.txtBoxFee.Location = new System.Drawing.Point(163, 99);
            this.txtBoxFee.Name = "txtBoxFee";
            this.txtBoxFee.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFee.TabIndex = 3;
            // 
            // lblHoursParked
            // 
            this.lblHoursParked.AutoSize = true;
            this.lblHoursParked.Location = new System.Drawing.Point(23, 56);
            this.lblHoursParked.Name = "lblHoursParked";
            this.lblHoursParked.Size = new System.Drawing.Size(71, 13);
            this.lblHoursParked.TabIndex = 4;
            this.lblHoursParked.Text = "Hours parked";
            // 
            // LblFee
            // 
            this.LblFee.AutoSize = true;
            this.LblFee.Location = new System.Drawing.Point(163, 56);
            this.LblFee.Name = "LblFee";
            this.LblFee.Size = new System.Drawing.Size(25, 13);
            this.LblFee.TabIndex = 5;
            this.LblFee.Text = "Fee";
            // 
            // RdbtnCar
            // 
            this.RdbtnCar.AutoSize = true;
            this.RdbtnCar.Location = new System.Drawing.Point(103, 135);
            this.RdbtnCar.Name = "RdbtnCar";
            this.RdbtnCar.Size = new System.Drawing.Size(41, 17);
            this.RdbtnCar.TabIndex = 6;
            this.RdbtnCar.TabStop = true;
            this.RdbtnCar.Text = "Car";
            this.RdbtnCar.UseVisualStyleBackColor = true;
            // 
            // RdbtnTruck
            // 
            this.RdbtnTruck.AutoSize = true;
            this.RdbtnTruck.Location = new System.Drawing.Point(103, 158);
            this.RdbtnTruck.Name = "RdbtnTruck";
            this.RdbtnTruck.Size = new System.Drawing.Size(53, 17);
            this.RdbtnTruck.TabIndex = 7;
            this.RdbtnTruck.TabStop = true;
            this.RdbtnTruck.Text = "Truck";
            this.RdbtnTruck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.RdbtnTruck);
            this.Controls.Add(this.RdbtnCar);
            this.Controls.Add(this.LblFee);
            this.Controls.Add(this.lblHoursParked);
            this.Controls.Add(this.txtBoxFee);
            this.Controls.Add(this.txtBoxHoursParked);
            this.Controls.Add(this.btnEventRate);
            this.Controls.Add(this.btnStandard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStandard;
        private System.Windows.Forms.Button btnEventRate;
        private System.Windows.Forms.TextBox txtBoxHoursParked;
        private System.Windows.Forms.TextBox txtBoxFee;
        private System.Windows.Forms.Label lblHoursParked;
        private System.Windows.Forms.Label LblFee;
        private System.Windows.Forms.RadioButton RdbtnCar;
        private System.Windows.Forms.RadioButton RdbtnTruck;
    }
}

