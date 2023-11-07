using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GP_booking_system
{
    public partial class BookAnAppointment : Form
    {
        //Declarations
        string timeValue;
        string dateValue;
        string rTimeValue;
        string rDateValue;

        //List
        List<Appointment> lAppointment = new List<Appointment>();
        Appointment currentAppointment;

        public BookAnAppointment()
        {
            
            InitializeComponent();
            TimePicker.Format = DateTimePickerFormat.Time;
            TimePicker.ShowUpDown = true;
            dtRescheduleTime.Format = DateTimePickerFormat.Time;
            dtRescheduleTime.ShowUpDown = true;
            Appointment newAppointment;
            newAppointment = new Appointment("Date", "...");
            lAppointment.Add(newAppointment);
            AddtoCb();
        }

        // saves the appointment in a list
        private void bEnter_Click(object sender, EventArgs e)
        {
            
            timeValue = TimePicker.Text;
            dateValue = DatePicker.Text;
            Appointment newAppointment;
            newAppointment = new Appointment(dateValue, timeValue);
            lAppointment.Add(newAppointment);
            cbSelect.Items.Add(newAppointment.Date);




            //foreach (Appointment appointment in lAppointment)
            // {
            // currentAppointment = appointment;
            //}

            textBox1.Text = "Saved your new appointment at " + currentAppointment.Time + " on the " + currentAppointment.Date;
        }

        private void bRenter_Click(object sender, EventArgs e)
        {
            rDateValue = dtRescheduleDate.Text;
            rTimeValue = dtRescheduleTime.Text;
            Appointment newAppointment;
            newAppointment = new Appointment(rDateValue, rTimeValue);
            lAppointment.Add(newAppointment);
            cbSelect.Items.Add(newAppointment.Date);
            lAppointment.Remove(lAppointment[cbSelect.SelectedIndex]);
            cbSelect.Items.RemoveAt(cbSelect.SelectedIndex);
            cbSelect.ResetText();

        }

        public void AddtoCb()
        {
            foreach (Appointment i in lAppointment)
            {
                cbSelect.Items.Add(i.Date);
            }
            cbSelect.SelectedIndex = 0;
            currentAppointment = lAppointment[0];
            
        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentAppointment = lAppointment[cbSelect.SelectedIndex];
        }

        private void bBook_Click(object sender, EventArgs e)
        {
            gbBook.Visible = true;
        }

        private void bReschedule_Click(object sender, EventArgs e)
        {
            gbSelect.Visible = true;

            
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            gbReschedule.Visible = true;

        }
    }
    
}
