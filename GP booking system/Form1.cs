using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_booking_system
{
    public partial class Form1 : Form
    {

        List<Patient_login> mName = new List<Patient_login>();
        List<Patient_login> mPassword = new List<Patient_login>();
        List<Patient_login> mEmail = new List<Patient_login>();


        public Form1()
        {
            InitializeComponent();
        }

        Patient_login newName ;
        newName = new Patient_login("Anna");
        mName.Add(newName);
            foreach (Patient_login p in mName)
            {

            }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
