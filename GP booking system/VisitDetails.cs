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
    public partial class VisitDetails : Form
    {
        String pFirstName;
        String pLastName;
        String dFirstName;
        String dLastName;
        String reasonVisit;
        String addNotes;
        String verdict;
        String prescriptionDetails;
        
        public VisitDetails()
        {
            InitializeComponent();
            
        }

        

        private void label6_Click(object sender, EventArgs e){}

        private void label10_Click(object sender, EventArgs e) {}

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage m = new MainPage();
            m.Show();
            this.Hide();
        }
    }
}
