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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // When login button is pressed and the login details are correct, will be taken to a new form
        private void LoginButton_Click(object sender, EventArgs e)
        {
           MainPage m = new MainPage();
           m.Show();
        }
    }
}
