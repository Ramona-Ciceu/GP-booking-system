using System;
using System.Collections;
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
        // Declarations
        bool verification = false;
        List<Patient_login> Patient = new List<Patient_login>();
        Patient_login currentPatient;
        //ist<Patient_login> mPassword = new List<Patient_login>();
        //List<Patient_login> mEmail = new List<Patient_login>();


        public Form1()
        {
            InitializeComponent();
            // made accounts to test the login authorisation 
            Patient_login newpatient;
            newpatient = new Patient_login("Anna", "password2");
            Patient.Add(newpatient);
            newpatient = new Patient_login("Testing", "password");
            Patient.Add(newpatient);
            foreach (Patient_login p in Patient)
            {
                currentPatient = p;
            }


        }


        //Methods

        /// <summary>
        /// Will check if the username and password inputted is already stored in the list.
        /// </summary>
        /// <returns></returns>

        public bool LoginVerification()
        {

            var userVerification = Patient.Exists(o => o.Name == UsernameInput.Text);
            var passwordVerification = Patient.Exists(p => p.Password == PasswordInput.Text);


            if (userVerification == true && passwordVerification == true)
            {
                verification = true;
                return verification;
            }
            else { return verification; }


        }

        // will be used to sign up account
        //public string NewAccount()
        // {
        // Patient_login newpatient;
        // newpatient = new Patient_login(UsernameInput.Text, PasswordInput.Text);
        // Patient.Add(newpatient);
        // foreach (Patient_login p in Patient)
        // {
        //currentPatient = p;
        //  }
        // }

        //UI EVENTS

        private void LoginButton_Click(object sender, EventArgs e)
        {

            LoginVerification();

            if (verification == true)
            {
                MessageBox.Show("Login successfully!");

                MainPage m = new MainPage();
                m.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login failed. Username or password incorrect.");
            }

        }
    }
}


