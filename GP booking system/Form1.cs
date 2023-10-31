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
using System.Xml.Linq;

namespace GP_booking_system
{
    public partial class Form1 : Form
    {

        List<Patient_login> Patient = new List<Patient_login>();
        Patient_login currentPatient;
       //ist<Patient_login> mPassword = new List<Patient_login>();
      //List<Patient_login> mEmail = new List<Patient_login>();


        public Form1()
        {
            InitializeComponent();

            Patient_login newpatient;
            newpatient = new Patient_login("Anna");
            Patient.Add(newpatient);

            foreach (Patient_login p in Patient)
            {
                currentPatient = p;
            }
        }

       
            

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Patient_login newpatient;
            newpatient = new Patient_login(UsernameInput.Text, PasswordInput.Text);
            Patient.Add(newpatient);

            MainPage m = new MainPage();
            m.Show();
            this.Hide();
        }
    }
}
