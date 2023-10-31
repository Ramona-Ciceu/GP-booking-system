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

        //List
        List<Appointment> lAppointment = new List<Appointment>();
        Appointment currentAppointment;

        public BookAnAppointment()
        {
            
            InitializeComponent();
            TimePicker.Format = DateTimePickerFormat.Time;
            TimePicker.ShowUpDown = true;
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            
            timeValue = TimePicker.Text;
            dateValue = DatePicker.Text;
            Appointment newAppointment;
            newAppointment = new Appointment(dateValue, timeValue);
            lAppointment.Add(newAppointment);

            foreach (Appointment appointment in lAppointment)
            {
                currentAppointment = appointment;
            }

            textBox1.Text = "Saved your new appointment at " + currentAppointment.Time + " on the " + currentAppointment.Date;
        }
    }
    }
}
