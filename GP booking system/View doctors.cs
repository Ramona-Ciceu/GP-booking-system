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
    public partial class View_doctors : Form
    {
        List<Doctors> doctors= new List<Doctors>();
        Doctors currentDoctor;




        public View_doctors()
        {
            InitializeComponent();


            // made accounts to test the login authorisation 
            Doctors newDoctor;
            newDoctor = new Doctors("Noel White", "Pathology", "Male");
            doctors.Add(newDoctor);
            
            newDoctor = new Doctors("Dana Scully", "Surgeon", "Female");
            doctors.Add(newDoctor);

            newDoctor = new Doctors("Elizabeth Brooks", "Pediatrics", "Female");
            doctors.Add(newDoctor);

            newDoctor = new Doctors("Harry Robbinson", "Cardiology", "Male");
            doctors.Add(newDoctor);

            newDoctor = new Doctors("Diana Parks", "Neurology", "Female");
            doctors.Add(newDoctor);

            foreach (Doctors d in doctors)
            {
               viewDoctorsComboBox.Items.Add(d.Name);
            }

            viewDoctorsComboBox.SelectedIndex = 0;
            currentDoctor = doctors[0];
        }
      

        private void dSpeciality_Click(object sender, EventArgs e)
        {

        }

        private void viewDoctorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDoctor = doctors[viewDoctorsComboBox.SelectedIndex];
            doctorsDetailsGroupBox.Visible = true;
            
           for (int i = 0; i < 5; i++)
            {
                if (currentDoctor == doctors[i])
                {
                    dName.Text = doctors[i].Name;
                    dSpeciality.Text = doctors[i].Speciality;
                    dGender.Text = doctors[i].Gender;   

                }
            }
        }

        private void dName_Click(object sender, EventArgs e)
        {

        }

        private void dGender_Click(object sender, EventArgs e)
        {

        }

        private void doctorsDetailsGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }

}
