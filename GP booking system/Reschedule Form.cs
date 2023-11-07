using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_booking_system
{
    public partial class Reschudule_Form : Form
    {
       List<Reschedule> reschedules= new List<Reschedule>();

        public Reschudule_Form()
        {
            InitializeComponent();
           //onfirmation.Text = "Are you sure you want to cancel youre appointment on" + Appointment.Date

                Reschedule newAppoitnment;
            newAppoitnment = new Reschedule( Patient_login ,BookAnAppointment.currentAppointment);
            reschedules.Add(newAppoitnment);

        }

        private void Confirmation_Click(object sender, EventArgs e)
        {

        }
    }
}
