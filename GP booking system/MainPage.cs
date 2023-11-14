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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // when button is clicked sends user to the booking appointment form
        private void BookAppointment_Click(object sender, EventArgs e)
        {
            BookAnAppointment a = new BookAnAppointment();
            a.Show();
            this.Hide();
        }

        private void viewAppointment_Click(object sender, EventArgs e)
        {
            VisitDetails v = new VisitDetails();
            v.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_doctors d = new View_doctors();
            d.Show();
            this.Hide();
        }

        
    }
}
