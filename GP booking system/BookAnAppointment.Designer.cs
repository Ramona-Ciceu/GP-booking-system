namespace GP_booking_system
{
    partial class BookAnAppointment
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
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.bEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.bBook = new System.Windows.Forms.Button();
            this.bReschedule = new System.Windows.Forms.Button();
            this.gbReschedule = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bRenter = new System.Windows.Forms.Button();
            this.dtRescheduleTime = new System.Windows.Forms.DateTimePicker();
            this.dtRescheduleDate = new System.Windows.Forms.DateTimePicker();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.bSelect = new System.Windows.Forms.Button();
            this.gbBook.SuspendLayout();
            this.gbReschedule.SuspendLayout();
            this.gbSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(20, 71);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(265, 22);
            this.DatePicker.TabIndex = 0;
            // 
            // TimePicker
            // 
            this.TimePicker.Location = new System.Drawing.Point(20, 121);
            this.TimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(265, 22);
            this.TimePicker.TabIndex = 1;
            // 
            // bEnter
            // 
            this.bEnter.Location = new System.Drawing.Point(100, 175);
            this.bEnter.Margin = new System.Windows.Forms.Padding(4);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(100, 28);
            this.bEnter.TabIndex = 2;
            this.bEnter.Text = "Enter";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Time and Date";
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.label1);
            this.gbBook.Controls.Add(this.bEnter);
            this.gbBook.Controls.Add(this.DatePicker);
            this.gbBook.Controls.Add(this.TimePicker);
            this.gbBook.Location = new System.Drawing.Point(375, 58);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(292, 386);
            this.gbBook.TabIndex = 5;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "Book an Appointment";
            this.gbBook.Visible = false;
            // 
            // bBook
            // 
            this.bBook.Location = new System.Drawing.Point(66, 74);
            this.bBook.Name = "bBook";
            this.bBook.Size = new System.Drawing.Size(251, 67);
            this.bBook.TabIndex = 6;
            this.bBook.Text = "Book Appointment";
            this.bBook.UseVisualStyleBackColor = true;
            this.bBook.Click += new System.EventHandler(this.bBook_Click);
            // 
            // bReschedule
            // 
            this.bReschedule.Location = new System.Drawing.Point(66, 186);
            this.bReschedule.Name = "bReschedule";
            this.bReschedule.Size = new System.Drawing.Size(251, 67);
            this.bReschedule.TabIndex = 7;
            this.bReschedule.Text = "Reschedule Appointment";
            this.bReschedule.UseVisualStyleBackColor = true;
            this.bReschedule.Click += new System.EventHandler(this.bReschedule_Click);
            // 
            // gbReschedule
            // 
            this.gbReschedule.Controls.Add(this.label2);
            this.gbReschedule.Controls.Add(this.bRenter);
            this.gbReschedule.Controls.Add(this.dtRescheduleTime);
            this.gbReschedule.Controls.Add(this.dtRescheduleDate);
            this.gbReschedule.Location = new System.Drawing.Point(706, 58);
            this.gbReschedule.Name = "gbReschedule";
            this.gbReschedule.Size = new System.Drawing.Size(292, 386);
            this.gbReschedule.TabIndex = 6;
            this.gbReschedule.TabStop = false;
            this.gbReschedule.Text = "Reschedule ";
            this.gbReschedule.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Time and Date";
            // 
            // bRenter
            // 
            this.bRenter.Location = new System.Drawing.Point(100, 175);
            this.bRenter.Margin = new System.Windows.Forms.Padding(4);
            this.bRenter.Name = "bRenter";
            this.bRenter.Size = new System.Drawing.Size(100, 28);
            this.bRenter.TabIndex = 2;
            this.bRenter.Text = "Enter";
            this.bRenter.UseVisualStyleBackColor = true;
            this.bRenter.Click += new System.EventHandler(this.bRenter_Click);
            // 
            // dtRescheduleTime
            // 
            this.dtRescheduleTime.Location = new System.Drawing.Point(20, 121);
            this.dtRescheduleTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtRescheduleTime.Name = "dtRescheduleTime";
            this.dtRescheduleTime.Size = new System.Drawing.Size(265, 22);
            this.dtRescheduleTime.TabIndex = 0;
            // 
            // dtRescheduleDate
            // 
            this.dtRescheduleDate.Location = new System.Drawing.Point(20, 71);
            this.dtRescheduleDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtRescheduleDate.Name = "dtRescheduleDate";
            this.dtRescheduleDate.Size = new System.Drawing.Size(265, 22);
            this.dtRescheduleDate.TabIndex = 1;
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.cbSelect);
            this.gbSelect.Controls.Add(this.bSelect);
            this.gbSelect.Location = new System.Drawing.Point(66, 316);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(251, 113);
            this.gbSelect.TabIndex = 8;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Select Appointment";
            this.gbSelect.Visible = false;
            // 
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Location = new System.Drawing.Point(22, 34);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(199, 24);
            this.cbSelect.TabIndex = 5;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // bSelect
            // 
            this.bSelect.Location = new System.Drawing.Point(62, 65);
            this.bSelect.Margin = new System.Windows.Forms.Padding(4);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(100, 28);
            this.bSelect.TabIndex = 5;
            this.bSelect.Text = "Select";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // BookAnAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 873);
            this.Controls.Add(this.gbSelect);
            this.Controls.Add(this.gbReschedule);
            this.Controls.Add(this.bReschedule);
            this.Controls.Add(this.bBook);
            this.Controls.Add(this.gbBook);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookAnAppointment";
            this.Text = "Ch";
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            this.gbReschedule.ResumeLayout(false);
            this.gbReschedule.PerformLayout();
            this.gbSelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.Button bBook;
        private System.Windows.Forms.Button bReschedule;
        private System.Windows.Forms.GroupBox gbReschedule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bRenter;
        private System.Windows.Forms.DateTimePicker dtRescheduleTime;
        private System.Windows.Forms.DateTimePicker dtRescheduleDate;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.ComboBox cbSelect;
    }
}