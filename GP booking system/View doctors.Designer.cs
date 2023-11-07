namespace GP_booking_system
{
    partial class View_doctors
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
            this.viewDoctorsComboBox = new System.Windows.Forms.ComboBox();
            this.viewDoctors = new System.Windows.Forms.Label();
            this.doctorsDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dGender = new System.Windows.Forms.Label();
            this.dSpeciality = new System.Windows.Forms.Label();
            this.dName = new System.Windows.Forms.Label();
            this.selectDoctorLabel1 = new System.Windows.Forms.Label();
            this.doctorsDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewDoctorsComboBox
            // 
            this.viewDoctorsComboBox.FormattingEnabled = true;
            this.viewDoctorsComboBox.Location = new System.Drawing.Point(49, 162);
            this.viewDoctorsComboBox.Name = "viewDoctorsComboBox";
            this.viewDoctorsComboBox.Size = new System.Drawing.Size(121, 21);
            this.viewDoctorsComboBox.TabIndex = 0;
            this.viewDoctorsComboBox.SelectedIndexChanged += new System.EventHandler(this.viewDoctorsComboBox_SelectedIndexChanged);
            // 
            // viewDoctors
            // 
            this.viewDoctors.AutoSize = true;
            this.viewDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDoctors.Location = new System.Drawing.Point(235, 9);
            this.viewDoctors.Name = "viewDoctors";
            this.viewDoctors.Size = new System.Drawing.Size(187, 31);
            this.viewDoctors.TabIndex = 1;
            this.viewDoctors.Text = "View Doctors";
            // 
            // doctorsDetailsGroupBox
            // 
            this.doctorsDetailsGroupBox.Controls.Add(this.pictureBox1);
            this.doctorsDetailsGroupBox.Controls.Add(this.dGender);
            this.doctorsDetailsGroupBox.Controls.Add(this.dSpeciality);
            this.doctorsDetailsGroupBox.Controls.Add(this.dName);
            this.doctorsDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorsDetailsGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.doctorsDetailsGroupBox.Location = new System.Drawing.Point(231, 57);
            this.doctorsDetailsGroupBox.Name = "doctorsDetailsGroupBox";
            this.doctorsDetailsGroupBox.Size = new System.Drawing.Size(310, 360);
            this.doctorsDetailsGroupBox.TabIndex = 2;
            this.doctorsDetailsGroupBox.TabStop = false;
            this.doctorsDetailsGroupBox.Text = "Doctors Details";
            this.doctorsDetailsGroupBox.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(79, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 111);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dGender
            // 
            this.dGender.AutoSize = true;
            this.dGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGender.Location = new System.Drawing.Point(75, 277);
            this.dGender.Name = "dGender";
            this.dGender.Size = new System.Drawing.Size(69, 20);
            this.dGender.TabIndex = 2;
            this.dGender.Text = "Gender";
            this.dGender.Click += new System.EventHandler(this.dGender_Click);
            // 
            // dSpeciality
            // 
            this.dSpeciality.AutoSize = true;
            this.dSpeciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dSpeciality.Location = new System.Drawing.Point(75, 237);
            this.dSpeciality.Name = "dSpeciality";
            this.dSpeciality.Size = new System.Drawing.Size(86, 20);
            this.dSpeciality.TabIndex = 1;
            this.dSpeciality.Text = "Speciality";
            this.dSpeciality.Click += new System.EventHandler(this.dSpeciality_Click);
            // 
            // dName
            // 
            this.dName.AutoSize = true;
            this.dName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dName.Location = new System.Drawing.Point(75, 194);
            this.dName.Name = "dName";
            this.dName.Size = new System.Drawing.Size(55, 20);
            this.dName.TabIndex = 0;
            this.dName.Text = "Name";
            this.dName.Click += new System.EventHandler(this.dName_Click);
            // 
            // selectDoctorLabel1
            // 
            this.selectDoctorLabel1.AutoSize = true;
            this.selectDoctorLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDoctorLabel1.Location = new System.Drawing.Point(44, 105);
            this.selectDoctorLabel1.Name = "selectDoctorLabel1";
            this.selectDoctorLabel1.Size = new System.Drawing.Size(156, 25);
            this.selectDoctorLabel1.TabIndex = 3;
            this.selectDoctorLabel1.Text = "Select a doctor";
            // 
            // View_doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectDoctorLabel1);
            this.Controls.Add(this.doctorsDetailsGroupBox);
            this.Controls.Add(this.viewDoctors);
            this.Controls.Add(this.viewDoctorsComboBox);
            this.Name = "View_doctors";
            this.Text = "View_doctors";
            this.doctorsDetailsGroupBox.ResumeLayout(false);
            this.doctorsDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox viewDoctorsComboBox;
        private System.Windows.Forms.Label viewDoctors;
        private System.Windows.Forms.GroupBox doctorsDetailsGroupBox;
        private System.Windows.Forms.Label dGender;
        private System.Windows.Forms.Label dSpeciality;
        private System.Windows.Forms.Label dName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label selectDoctorLabel1;
    }
}