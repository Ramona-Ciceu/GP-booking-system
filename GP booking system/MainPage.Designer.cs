namespace GP_booking_system
{
    partial class MainPage
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
            this.BookAppointment = new System.Windows.Forms.Button();
            this.viewDoctorsbtn = new System.Windows.Forms.Button();
            this.viewAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookAppointment
            // 
            this.BookAppointment.BackColor = System.Drawing.Color.Honeydew;
            this.BookAppointment.Location = new System.Drawing.Point(62, 91);
            this.BookAppointment.Name = "BookAppointment";
            this.BookAppointment.Size = new System.Drawing.Size(246, 83);
            this.BookAppointment.TabIndex = 0;
            this.BookAppointment.Text = "Book an Appointment";
            this.BookAppointment.UseVisualStyleBackColor = false;
            this.BookAppointment.Click += new System.EventHandler(this.BookAppointment_Click);
            // 
            // viewDoctorsbtn
            // 
            this.viewDoctorsbtn.BackColor = System.Drawing.Color.Cornsilk;
            this.viewDoctorsbtn.Location = new System.Drawing.Point(62, 366);
            this.viewDoctorsbtn.Name = "viewDoctorsbtn";
            this.viewDoctorsbtn.Size = new System.Drawing.Size(246, 83);
            this.viewDoctorsbtn.TabIndex = 2;
            this.viewDoctorsbtn.Text = "View Doctors";
            this.viewDoctorsbtn.UseVisualStyleBackColor = false;
            this.viewDoctorsbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // viewAppointment
            // 
            this.viewAppointment.BackColor = System.Drawing.Color.Thistle;
            this.viewAppointment.Location = new System.Drawing.Point(62, 229);
            this.viewAppointment.Name = "viewAppointment";
            this.viewAppointment.Size = new System.Drawing.Size(246, 83);
            this.viewAppointment.TabIndex = 1;
            this.viewAppointment.Text = "View Appointments";
            this.viewAppointment.UseVisualStyleBackColor = false;
            this.viewAppointment.Click += new System.EventHandler(this.viewAppointment_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(388, 515);
            this.Controls.Add(this.viewDoctorsbtn);
            this.Controls.Add(this.viewAppointment);
            this.Controls.Add(this.BookAppointment);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BookAppointment;
        private System.Windows.Forms.Button viewDoctorsbtn;
        private System.Windows.Forms.Button viewAppointment;
    }
}