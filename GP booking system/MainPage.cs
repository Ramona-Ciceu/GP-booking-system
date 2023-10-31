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

        // takes us to the book appointment form
        private void bookAppointment_Click(object sender, EventArgs e)
        {
            BookAnAppointment a = new BookAnAppointment();
            a.Show();
        }
    }
}
