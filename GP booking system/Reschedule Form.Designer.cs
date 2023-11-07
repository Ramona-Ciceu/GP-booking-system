namespace GP_booking_system
{
    partial class Reschudule_Form
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
            this.Confirmation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Confirmation
            // 
            this.Confirmation.AutoSize = true;
            this.Confirmation.Location = new System.Drawing.Point(470, 73);
            this.Confirmation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Confirmation.Name = "Confirmation";
            this.Confirmation.Size = new System.Drawing.Size(44, 16);
            this.Confirmation.TabIndex = 0;
            this.Confirmation.Text = "label1";
            this.Confirmation.Click += new System.EventHandler(this.Confirmation_Click);
            // 
            // Reschudule_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Confirmation);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Reschudule_Form";
            this.Text = "Reschudule_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Confirmation;
    }
}