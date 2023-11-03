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

        //Add patient logins
       List<Patient_login> Patient = new List<Patient_login> { new Patient_login("patient1", "password1"),
            new Patient_login("patient1", "password2")
        };
        Patient_login currentPatient;
      

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
            /*
            Patient_login newpatient;
            newpatient = new Patient_login(UsernameInput.Text, PasswordInput.Text);
            Patient.Add(newpatient);
             */

            MainPage m = new MainPage();
         
            

            string username = UsernameInput.Text;
            string password = PasswordInput.Text;



            if (username == UsernameInput.Text && password == PasswordInput.Text)
                {
                    MessageBox.Show("Login successfully!");
                }
                else
                {
                    MessageBox.Show("Login failed. Username or password incorrect.");
                }






            m.Show();
            this.Hide();


        }
        /// <summary>
        /// Method to Authenticate patient
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool AuthenticatePatient(string userName, string password)
        {
            foreach (var Patient_login in Patient)
            {
                if (Patient_login.Name == userName && Patient_login.Password == password)
                { return true; }

            }
            return false;
        }

    }
    }

