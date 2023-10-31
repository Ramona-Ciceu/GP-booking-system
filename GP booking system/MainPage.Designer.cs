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
            this.viewAppointment = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookAppointment
            // 
            this.BookAppointment.Location = new System.Drawing.Point(62, 46);
            this.BookAppointment.Name = "BookAppointment";
            this.BookAppointment.Size = new System.Drawing.Size(246, 83);
            this.BookAppointment.TabIndex = 0;
            this.BookAppointment.Text = "Book an Appointment";
            this.BookAppointment.UseVisualStyleBackColor = true;
            this.BookAppointment.Click += new System.EventHandler(this.BookAppointment_Click);
            // 
            // viewAppointment
            // 
            this.viewAppointment.Location = new System.Drawing.Point(62, 152);
            this.viewAppointment.Name = "viewAppointment";
            this.viewAppointment.Size = new System.Drawing.Size(246, 83);
            this.viewAppointment.TabIndex = 1;
            this.viewAppointment.Text = "View Appointments";
            this.viewAppointment.UseVisualStyleBackColor = true;
            this.viewAppointment.Click += new System.EventHandler(this.viewAppointment_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 83);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 413);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.viewAppointment);
            this.Controls.Add(this.BookAppointment);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BookAppointment;
        private System.Windows.Forms.Button viewAppointment;
        private System.Windows.Forms.Button button3;
    }
}