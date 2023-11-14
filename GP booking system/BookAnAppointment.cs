using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GP_booking_system
{
    public partial class BookAnAppointment : Form
    {
        //Declarations
        string timeValue;
        string dateValue;
        string rTimeValue;
        string rDateValue;
        string assignedDoctor;
        

        //List
        List<Appointment> lAppointment = new List<Appointment>();
        Appointment currentAppointment;

        
        List<Doctors> doctors = new List<Doctors>();
        Doctors currentDoctor;
        Doctors firstDoctor;

        public BookAnAppointment()
        {
            
            InitializeComponent();
            TimePicker.Format = DateTimePickerFormat.Time;
            TimePicker.ShowUpDown = true;
            dtRescheduleTime.Format = DateTimePickerFormat.Time;
            dtRescheduleTime.ShowUpDown = true;
            Appointment newAppointment;
            newAppointment = new Appointment("Date", "...");
            lAppointment.Add(newAppointment);
            AddtoCb();


            // made tester doctors for the combo box
            Doctors newDoctor;
            newDoctor = new Doctors("Noel White", "Pathology", "Male");
            doctors.Add(newDoctor);

            newDoctor = new Doctors("Dana Scully", "Dermatology", "Female");
            doctors.Add(newDoctor);

            newDoctor = new Doctors("Elizabeth Brooks", "Pediatrics", "Female");
            doctors.Add(newDoctor);

           newDoctor = new Doctors("Harry Robbinson", "Cardiology", "Male");
            doctors.Add(newDoctor);

            newDoctor = new Doctors("Diana Parks", "Neurology", "Female");
            doctors.Add(newDoctor);

            foreach (Doctors d in doctors)
            {
                cbChangeDoctor.Items.Add(d.Name);
            }

            cbChangeDoctor.SelectedIndex = 0;
            firstDoctor = doctors[0];
        }

        // saves the appointment in a list
        private void bEnter_Click(object sender, EventArgs e)
        {
            
            timeValue = TimePicker.Text;
            dateValue = DatePicker.Text;
            Appointment newAppointment;
            newAppointment = new Appointment(dateValue, timeValue, currentDoctor);
            lAppointment.Add(newAppointment);
            cbSelect.Items.Add(newAppointment.Date);
            currentAppointment = newAppointment;



            //foreach (Appointment appointment in lAppointment)
            // {
            // currentAppointment = appointment;
            //}

            MessageBox.Show( "Your appointment has been booked for :" + currentAppointment.Time + " on the " + currentAppointment.Date);
            tAssignedDoc.Text = currentDoctor.Name;
        }

        private void bRenter_Click(object sender, EventArgs e)
        {
            rDateValue = dtRescheduleDate.Text;
            rTimeValue = dtRescheduleTime.Text;
            Appointment newAppointment;
            newAppointment = new Appointment(rDateValue, rTimeValue, firstDoctor);
            lAppointment.Add(newAppointment);
            cbSelect.Items.Add(newAppointment.Date);
            lAppointment.Remove(lAppointment[cbSelect.SelectedIndex]);
            cbSelect.Items.RemoveAt(cbSelect.SelectedIndex);
            cbSelect.ResetText();
            currentAppointment = newAppointment;
            MessageBox.Show("You appointment has been changed to:" + currentAppointment.Time + " on the " + currentAppointment.Date);

        }

        public void AddtoCb()
        {
            foreach (Appointment i in lAppointment)
            {
                cbSelect.Items.Add(i.Date);
            }
            cbSelect.SelectedIndex = 0;
            currentAppointment = lAppointment[0];
            
        }
        public void AddtoDoctorCb()
        {
            foreach (Appointment i in lAppointment)
            {
                cbSelect.Items.Add(i.Name);
            }
            cbChangeDoctor.SelectedIndex = 0;
           

        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentAppointment = lAppointment[cbSelect.SelectedIndex];
        }

        private void bBook_Click(object sender, EventArgs e)
        {
            gbBook.Visible = true;
        }

        private void bReschedule_Click(object sender, EventArgs e)
        {
            gbSelect.Visible = true;

            
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            gbReschedule.Visible = true;

        }

        private void cbChangeDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDoctor = doctors[cbChangeDoctor.SelectedIndex];

        }

        private void bChangeDoc_Click(object sender, EventArgs e)
        {
            gbChangeDoc.Visible = true;
        }

        private void bChangeDoctor_Click(object sender, EventArgs e)
        { 
            assignedDoctor = cbChangeDoctor.Text;
            tAssignedDoc.Text = assignedDoctor;
            Appointment newAppointment;
            newAppointment = new Appointment(dateValue, timeValue, currentDoctor);
            lAppointment.Add(newAppointment);
            lAppointment.RemoveAt(2);
            currentAppointment = newAppointment;
            MessageBox.Show("Your doctor has been changed to: " + assignedDoctor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage m = new MainPage();
            m.Show();
            this.Hide();
        }
    }
    
}
