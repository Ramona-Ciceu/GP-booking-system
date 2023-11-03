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
        List<Patient_login> Patient = new List<Patient_login>();

        Patient_login currentPatient;


        public Form1()
        {
            InitializeComponent();

            Patient_login newpatient;
            newpatient = new Patient_login("Anna", "password");
           // Patient.Add(newpatient);

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




          /*   bool AuthenticatePatient(string userName, string Password)
            {
                for (int i = 0; i < Patient.Count; i++)
                {
                    if (Patient[i].Name == userName && Patient[i].Password == Password)
                    { return true; }

                }
                return false;
            } */




            m.Show();
            this.Hide();


        }
    }
}

        
    
    

